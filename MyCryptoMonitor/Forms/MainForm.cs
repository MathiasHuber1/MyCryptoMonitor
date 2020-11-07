using CoinMarketCap;
using CoinMarketCap.Models.Cryptocurrency;
using MyCryptoMonitor.Configs;
using MyCryptoMonitor.Gui;
using MyCryptoMonitor.Statics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace MyCryptoMonitor.Forms
{
    public partial class MainForm : Form
    {
        #region Private Variables

        private readonly DateTime resetTime = DateTime.Now;
        private string ApiError = "";
        private List<string> coinNames = new List<string>();
        private List<CryptocurrencyWithLatestQuote> coins = new List<CryptocurrencyWithLatestQuote>();
        private bool emptyCoinmarketcapApiKeyNotified = false;
        private DateTime lastRefreshTime = DateTime.Now;
        private bool resetStartupPrice = false;
        private bool updatingCoins = false;
        private List<CoinLine> coinLines { get; set; } = new List<CoinLine>();

        #endregion Private Variables

        #region Constructor

        public MainForm()
        {
            InitializeComponent();
            CoinMarketCapClient.ApiError += ReceiveApiError;
            timerSave.Enabled = true;
        }

        private void ReceiveApiError(object sender, string e)
        {
            ApiError = e;
        }

        #endregion Constructor

        #region Threads

        private void CheckUpdate()
        {
            var checkingUpdate = true;
            var attempts = 0;

            while (checkingUpdate && attempts < 3)
            {
                try
                {
                    using (var webClient = new WebClient())
                    {
                        var currentVersion = new Version(Application.ProductVersion);
                        webClient.Headers.Add("user-agent", "MyCryptoMonitor " + currentVersion.ToString());
                        var release = webClient.DownloadString("https://mycryptomonitor.com/download/latestVersion");
                        Version latestVersion = new Version(release);

                        if (currentVersion.CompareTo(latestVersion) < 0)
                        {
                            if (MessageBox.Show($"Download new version?\n\nCurrent Version: {currentVersion}\nLatest Version {latestVersion}", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                                System.Diagnostics.Process.Start("https://mycryptomonitor.com/download/mycryptomonitor.exe");
                        }

                        checkingUpdate = false;
                    }
                }
                catch (WebException)
                {
                    attempts++;
                    UpdateStatus("Failed checking for update");
                }
            }
        }

        private async void GetCoinData()
        {
            while (true)
            {
                try
                {
                    UpdateStatus("Refreshing");
                    if (string.IsNullOrEmpty(UserConfigService.CoinMarketcapApiKey))
                    {
                        UpdateStatus("CoinMarketCap API key is empty");
                        if (!emptyCoinmarketcapApiKeyNotified)
                        {
                            if (MessageBox.Show(
           "The program will not work without one. Please create a free user and get yours on https://accounts.coinmarketcap.com/signup" +
           Environment.NewLine + "Go there now?", "CoinMarketCap API key is empty", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk
       ) == DialogResult.Yes)
                            {
                                System.Diagnostics.Process.Start("https://accounts.coinmarketcap.com/signup");
                            }
                            emptyCoinmarketcapApiKeyNotified = true;
                        }
                    }
                    else
                    {
                        var coinMarketcapClient = new CoinMarketCapClient(UserConfigService.CoinMarketcapApiKey);
                        var listingLatestParameters = new ListingLatestParameters { Limit = UserConfigService.CoinMarketcapCoinsRequestLimit, Convert = UserConfigService.Currency };
                        var startTime = DateTime.UtcNow;
                        var result = await TimeoutTask.DelayTaskGenAsync(coinMarketcapClient.GetLatestListingsAsync(listingLatestParameters),
                             30 * 1000).ConfigureAwait(false);
                        var seconds = DateTime.UtcNow.Subtract(startTime).TotalSeconds;
                        if (!string.IsNullOrEmpty(ApiError))
                        {
                            var message = "";
                            if (ApiError.Contains("401"))
                                message = "Unauthorized, please check the API key";
                            else if (message.Contains("task was cancelled"))
                                message = "Timeout connecting to CoinmarketCap";
                            else
                                message = ApiError;
                            MessageBox.Show(message, "CoinmarketCap price update error");
                            ApiError = "";
                        }
                        if (result != null)
                        {
                            coins = result.Data;
                            UpdateCoins();
                            MainService.Unsaved = true;
                        }
                    }
                }
                catch (WebException)
                {
                    UpdateStatus("No internet connection");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                UpdateStatus("Sleeping");
                Thread.Sleep(UserConfigService.RefreshTime);
            }
        }

        private void ThreadStarter(Thread thread)
        {
            thread.IsBackground = true;
            thread.Start();
        }

        private void Timers()
        {
            while (true)
            {
                var spanReset = DateTime.Now.Subtract(resetTime);
                var spanRefresh = DateTime.Now.Subtract(lastRefreshTime);
                var runningTime = spanReset.Days > 0 ? $"Running Timer: {spanReset.Days} days {spanReset.Hours}:{spanReset.Minutes:00}:{spanReset.Seconds:00}" : $"Running Timer: {spanReset.Hours}:{spanReset.Minutes:00}:{spanReset.Seconds:00}";
                var refreshTime = $"Refresh Timer: {spanRefresh.Minutes}:{spanRefresh.Seconds:00}";

                if (string.IsNullOrWhiteSpace(txtRefreshTime.Text) || txtRefreshTime.Text.ConvertToInt() < 1)
                    UpdateRefreshTime("60");

                if (UserConfigService.RefreshTime / 1000 != txtRefreshTime.Text.ConvertToInt())
                {
                    UserConfigService.RefreshTime = txtRefreshTime.Text.ConvertToInt() * 1000;
                }

                if (UserConfigService.CoinMarketcapApiKey != txtCoinMarketcapApiKey.Text)
                {
                    UserConfigService.CoinMarketcapApiKey = txtCoinMarketcapApiKey.Text;
                }
                try
                {
                    int numericUpDownCurrenciesToRequestInt = Convert.ToInt32(Math.Round(numericUpDownCurrenciesToRequest.Value, 0));
                    if (UserConfigService.CoinMarketcapCoinsRequestLimit != numericUpDownCurrenciesToRequestInt)
                    {
                        UserConfigService.CoinMarketcapCoinsRequestLimit = numericUpDownCurrenciesToRequestInt;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                UpdateTimers(runningTime, refreshTime);

                Thread.Sleep(500);
            }
        }

        #endregion Threads

        #region Methods

        private void AddLine(CoinConfig coinConfig, CryptocurrencyWithLatestQuote coin, int lineIndex)
        {
            var newLine = new CoinLine(coin.Symbol, coinConfig.Index, lineIndex, Width);

            var quote = coin.Quote[UserConfigService.Currency];
            if (quote == null)
                return;
            var price = quote.Price;
            if (coinConfig.StartupPrice == 0 && price != null)
                coinConfig.StartupPrice = price.Value;

            Invoke((MethodInvoker)delegate
            {
                newLine.SetBoughtText(coinConfig.Bought.ToString());
                newLine.SetPaidText(coinConfig.Paid.ToString());

                Controls.Add(newLine.Table);
                coinLines.Add(newLine);

                Globals.SetTheme(newLine.Table);
            });
        }

        private void LoadPortfolio(string portfolio)
        {
            PortfolioService.PortfolioServiceInstance.CoinConfigs = PortfolioService.PortfolioServiceInstance.Load(portfolio);
            cbCurrency.Text = UserConfigService.Currency;
            UpdateCoins();
        }

        private void RemoveLines()
        {
            Invoke((MethodInvoker)delegate
            {
                UpdateStatus("Loading");

                foreach (var line in coinLines)
                    line.Dispose();

                coinLines = new List<CoinLine>();
                SetHeight(0);
            });
        }

        private void SavePortfolio(string portfolio)
        {
            var configToSave = new List<CoinConfig>();
            foreach (var coinLine in coinLines)
            {
                configToSave.Add(new CoinConfig
                {
                    Name = coinLine.CoinLabel.Text,
                    Bought = coinLine.BoughtTextBox.Text.ConvertToDecimal(),
                    Paid = coinLine.PaidTextBox.Text.ConvertToDecimal(),
                    Index = coinLine.CoinIndex,
                    Currency = cbCurrency.Text
                });
            }

            foreach (var coinConfig in PortfolioService.PortfolioServiceInstance.CoinConfigs)
            {
                var matched = false;
                foreach (var coinLine in coinLines)
                {
                    if (coinConfig.Name == coinLine.CoinName)
                    {
                        matched = true;
                        break;
                    }
                }
                if (!matched || coinLines.Count == 0)
                    configToSave.Add(coinConfig);
            }

            PortfolioService.PortfolioServiceInstance.Save(portfolio, configToSave);
            PortfolioService.PortfolioServiceInstance.CoinConfigs = configToSave;
            MainService.Unsaved = false;
        }

        private void SelectPortfolio(string portfolio)
        {
            if (PortfolioService.PortfolioServiceInstance.CurrentPortfolio != portfolio)
                SavePortfolio(PortfolioService.PortfolioServiceInstance.CurrentPortfolio);
            PortfolioService.PortfolioServiceInstance.CurrentPortfolio = portfolio;
            PortfolioService.PortfolioServiceInstance.CoinConfigs = PortfolioService.PortfolioServiceInstance.Load(portfolio);

            foreach (var item in savePortfolioMenu.DropDownItems.OfType<ToolStripMenuItem>())
                item.Checked = item.Text.ExtEquals(portfolio);

            foreach (var item in loadPortfolioMenu.DropDownItems.OfType<ToolStripMenuItem>())
                item.Checked = item.Text.ExtEquals(portfolio);
            UpdateCoins();
        }

        private void SetHeight(int lines)
        {
            Invoke((MethodInvoker)delegate
            {
                Height = 165 + lines * 25;
            });
        }

        private void SetupPortfolioMenu()
        {
            var portfolios = PortfolioService.PortfolioServiceInstance.GetPortfolios();
            var onePortfolioChecked = false;
            foreach (var portfolio in portfolios)
            {
                var selected = PortfolioService.PortfolioServiceInstance.CurrentPortfolio.ExtEquals(portfolio.Name);
                onePortfolioChecked = selected;
                if (onePortfolioChecked)
                    break;
            }

            for (int i = 0; i < portfolios.Count; i++)
            {
                DataSources.PortfolioDataSource portfolio = (DataSources.PortfolioDataSource)portfolios[i];
                var selected = PortfolioService.PortfolioServiceInstance.CurrentPortfolio.ExtEquals(portfolio.Name);
                var checkFirstPortfolio = !onePortfolioChecked && i == 0;
                if (selected || checkFirstPortfolio || portfolios.Count == 1)
                    selected = true;

                savePortfolioMenu.DropDownItems.Add(new ToolStripMenuItem(portfolio.Name, null, SavePortfolio_Click) { Name = portfolio.Name, Checked = selected });
                loadPortfolioMenu.DropDownItems.Add(new ToolStripMenuItem(portfolio.Name, null, LoadPortfolio_Click) { Name = portfolio.Name, Checked = selected });
            }
        }

        private void UpdateCoins()
        {
            if (updatingCoins)
                return;
            updatingCoins = true;
            //var removeConfigs = new List<CoinConfig>();
            decimal totalPaid = 0;
            decimal totalOverall = 0;
            decimal totalNegativeProfits = 0;
            decimal totalPostivieProfits = 0;
            var lineIndex = 0;

            coinNames = coins.OrderBy(c => c.Symbol).Select(c => c.Symbol).ToList();

            MainService.CheckAlerts(coins);

            RemoveLines();

            foreach (var coinConfig in PortfolioService.PortfolioServiceInstance.CoinConfigs)
            {
                if (!coins.Any(c => c.Symbol == coinConfig.Name))
                {
                    var message = "Sorry, CoinMarket Cap does not have any data for " + coinConfig.Name + ". Please configure a higher numbers of currencies to request, it might have moved to a lower number than the current maximum, " + UserConfigService.CoinMarketcapCoinsRequestLimit.ToString() + ", and try again";
                    MessageBox.Show(message, "Cryptocurrency not available");
                    continue;
                }
                var coin = coins.Find(c => c.Symbol == coinConfig.Name);

                if (resetStartupPrice)
                    coinConfig.StartupPrice = 0;

                AddLine(coinConfig, coin, lineIndex);

                lineIndex++;

                var line = (from c in coinLines where c.CoinName.ExtEquals(coin.Symbol) && c.CoinIndex == coinConfig.Index select c).First();

                var bought = line.BoughtTextBox.Text.ConvertToDecimal();
                var paid = line.PaidTextBox.Text.ConvertToDecimal();
                var quote = coin.Quote[UserConfigService.Currency];
                var price = quote.Price.Value;
                var total = bought * price;
                var profit = total - paid;

                coinConfig.Bought = bought;
                coinConfig.Paid = paid;

                totalPaid += paid;
                totalOverall += paid + profit;

                if (profit >= 0)
                    totalPostivieProfits += profit;
                else
                    totalNegativeProfits += profit;

                var coinIndexLabel = PortfolioService.PortfolioServiceInstance.CoinConfigs.Count(c => c.Name.ExtEquals(coinConfig.Name)) > 1 ? $"[{coinConfig.Index + 1}]" : string.Empty;
                var coinLabel = coin.Symbol;
                var priceLabel = $"{MainService.CurrencySymbol}{price.ConvertToString(8)}";
                var boughtLabel = $"{MainService.CurrencySymbol}{bought.SafeDivision(paid).ConvertToString(8)}";
                var totalLabel = $"{MainService.CurrencySymbol}{total:0.00}";
                var profitLabel = $"{MainService.CurrencySymbol}{profit:0.00}";
                var ratioLabel = paid != 0 ? $"{profit / paid:0.00}" : "0.00";
                var changeDollarLabel = $"{MainService.CurrencySymbol}{(price - coinConfig.StartupPrice):0.000000}";
                var changePercentLabel = $"{coinConfig.StartupPrice.SafeDivision(price - coinConfig.StartupPrice) * 100:0.00}%";
                var change1HrLabel = $"{quote.PercentChange1H.Value:0.00}%";
                var change24HrLabel = $"{quote.PercentChange24H.Value:0.00}%";
                var change7DayLabel = $"{quote.PercentChange7D.Value:0.00}%";

                Invoke((MethodInvoker)delegate
                {
                    line.CoinIndexLabel.Text = coinIndexLabel;
                    line.CoinLabel.Text = coinLabel;
                    line.PriceLabel.Text = priceLabel;
                    line.BoughtPriceLabel.Text = boughtLabel;
                    line.TotalLabel.Text = totalLabel;
                    line.ProfitLabel.Text = profitLabel;
                    line.RatioLabel.Text = ratioLabel;
                    line.ChangeDollarLabel.Text = changeDollarLabel;
                    line.ChangePercentLabel.Text = changePercentLabel;
                    line.Change1HrPercentLabel.Text = change1HrLabel;
                    line.Change24HrPercentLabel.Text = change24HrLabel;
                    line.Change7DayPercentLabel.Text = change7DayLabel;
                });
            }

            resetStartupPrice = false;

            lastRefreshTime = DateTime.Now;
            UpdateStatus("Sleeping");
            SetHeight(PortfolioService.PortfolioServiceInstance.CoinConfigs.Count);

            var totalProfitColor = totalOverall - totalPaid >= 0 ? ColorTranslator.FromHtml(UserConfigService.Theme.PositiveColor) : ColorTranslator.FromHtml(UserConfigService.Theme.NegativeColor);
            var totalProfitLabel = $"{MainService.CurrencySymbol}{totalOverall - totalPaid:0.00}";
            var totalNegativeProfitLabel = $"{MainService.CurrencySymbol}{totalNegativeProfits:0.00}";
            var totalPositiveProfitLabel = $"{MainService.CurrencySymbol}{totalPostivieProfits:0.00}";
            var totalOverallLabel = $"{MainService.CurrencySymbol}{totalOverall:0.00}";
            var totalInvested = $"{MainService.CurrencySymbol}{totalPaid:0.00}";
            var profitPercentage = $"{Math.Abs(((1 - totalPaid.SafeDivision(totalOverall))) * 100):0.00}%";

            Invoke((MethodInvoker)delegate
            {
                lblTotalProfit.ForeColor = totalProfitColor;
                lblProfitPercentage.ForeColor = totalProfitColor;
                lblTotalProfit.Text = totalProfitLabel;
                lblTotalNegativeProfit.Text = totalNegativeProfitLabel;
                lblTotalPositiveProfit.Text = totalPositiveProfitLabel;
                lblOverallTotal.Text = totalOverallLabel;
                lblTotalInvested.Text = totalInvested;
                lblProfitPercentage.Text = profitPercentage;
                alertsToolStripMenuItem.Enabled = true;
                coinsToolStripMenuItem.Enabled = true;
            });
            MainService.LinesNeedUpdating = false;
            updatingCoins = false;
        }

        private void UpdateRefreshTime(string time)
        {
            Invoke((MethodInvoker)delegate
            {
                txtRefreshTime.Text = time;
            });
        }

        private void UpdateStatus(string status)
        {
            Invoke((MethodInvoker)delegate
            {
                lblStatus.Text = $"Status: {status}";
            });
        }

        private void UpdateTimers(string runningTime, string refreshTime)
        {
            Invoke((MethodInvoker)delegate
            {
                lblRunningTime.Text = runningTime;
                lblRefreshTime.Text = refreshTime;
            });
        }

        #endregion Methods

        #region Events

        private void Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCurrency.Text.Contains("-"))
                cbCurrency.Text = "USD";

            coinsToolStripMenuItem.Enabled = false;
            UserConfigService.Currency = cbCurrency.Text;
            resetStartupPrice = true;
            UpdateCoins();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MainService.Unsaved)
                SavePortfolio(PortfolioService.PortfolioServiceInstance.CurrentPortfolio);

            Environment.Exit(Environment.ExitCode);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                MainService.Startup();
                Globals.SetTheme(this);

                PortfolioService.PortfolioServiceInstance.CoinConfigs = PortfolioService.PortfolioServiceInstance.LoadStartup();
                cbCurrency.Text = UserConfigService.Currency;
                txtRefreshTime.Text = (UserConfigService.RefreshTime / 1000).ToString();
                txtCoinMarketcapApiKey.Text = UserConfigService.CoinMarketcapApiKey;
                numericUpDownCurrenciesToRequest.Value = UserConfigService.CoinMarketcapCoinsRequestLimit;
                SetupPortfolioMenu();

                //ThreadStarter(new Thread(new ThreadStart(CheckUpdate)));
                ThreadStarter(new Thread(new ThreadStart(Timers)));
                ThreadStarter(new Thread(new ThreadStart(GetCoinData)));
                ThreadStarter(new Thread(new ThreadStart(CheckUpdate)));
            }
            catch (Exception)
            {
                if (MessageBox.Show($"There was an error starting up. Would you like to reset? \nThis will remove encryption and delete all portfolios and alerts.", "Error on startup", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    MainService.Reset();

                Close();
            }
        }

        #region File Menu

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory());
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            if (MainService.ConfirmReset())
            {
                foreach (var portfolio in PortfolioService.PortfolioServiceInstance.GetPortfolios())
                {
                    savePortfolioMenu.DropDownItems.RemoveByKey(portfolio.Name);
                    loadPortfolioMenu.DropDownItems.RemoveByKey(portfolio.Name);
                }

                MainService.Reset();
            }
        }

        #endregion File Menu

        #region Coins Menu

        private void AddCoin_Click(object sender, EventArgs e)
        {
            using (var form = new ManageCoins(coinNames))
            {
                if (form.ShowDialog() != DialogResult.OK)
                    return;

                if (!coinNames.Any(c => c.ExtEquals(form.InputText)))
                {
                    MessageBox.Show("Coin does not exist.", "Error");
                    return;
                }

                PortfolioService.PortfolioServiceInstance.CoinConfigs.Add(new CoinConfig
                {
                    Name = form.InputText,
                    Bought = 0,
                    Paid = 0,
                    StartupPrice = 0,
                    Index = PortfolioService.PortfolioServiceInstance.CoinConfigs.Count(c => c.Name.ExtEquals(form.InputText))
                });

                UpdateCoins();
            }
            MainService.Unsaved = true;
        }

        private void RemoveAllCoins_Click(object sender, EventArgs e)
        {
            PortfolioService.PortfolioServiceInstance.CoinConfigs = new List<CoinConfig>();
            UpdateCoins();
            MainService.Unsaved = true;
        }

        private void RemoveCoin_Click(object sender, EventArgs e)
        {
            using (var form = new ManageCoins(PortfolioService.PortfolioServiceInstance.CoinConfigs))
            {
                if (form.ShowDialog() != DialogResult.OK)
                    return;

                PortfolioService.PortfolioServiceInstance.CoinConfigs.RemoveAll(a => a.Name.ExtEquals(form.InputText) && a.Index == form.CoinIndex);

                //Reset coin indexes
                foreach (var coinConfig in PortfolioService.PortfolioServiceInstance.CoinConfigs)
                {
                    var index = 0;

                    foreach (var sameCoinConfig in PortfolioService.PortfolioServiceInstance.CoinConfigs.Where(c => c.Name == coinConfig.Name).ToList())
                    {
                        sameCoinConfig.Index = index;
                        index++;
                    }
                }
            }

            UpdateCoins();
            MainService.Unsaved = true;
        }

        #endregion Coins Menu

        #region Alerts Menu

        private void Alerts_Click(object sender, EventArgs e)
        {
            using (var form = new ManageAlerts(coins))
                form.ShowDialog();
        }

        #endregion Alerts Menu

        #region Portfolio Menu

        private void LoadPortfolio_Click(object sender, EventArgs e)
        {
            var portfolio = ((ToolStripMenuItem)sender).Text;
            alertsToolStripMenuItem.Enabled = false;
            coinsToolStripMenuItem.Enabled = false;

            SelectPortfolio(portfolio);
            LoadPortfolio(portfolio);
        }

        private void ManagePortfolios_Click(object sender, EventArgs e)
        {
            foreach (var portfolio in PortfolioService.PortfolioServiceInstance.GetPortfolios())
            {
                savePortfolioMenu.DropDownItems.RemoveByKey(portfolio.Name);
                loadPortfolioMenu.DropDownItems.RemoveByKey(portfolio.Name);
            }

            using (var form = new ManagePortfolios())
                form.ShowDialog();

            SetupPortfolioMenu();
        }

        private void SavePortfolio_Click(object sender, EventArgs e)
        {
            var portfolio = ((ToolStripMenuItem)sender).Text;

            SelectPortfolio(portfolio);
            SavePortfolio(portfolio);
        }

        #endregion Portfolio Menu

        #region Encrypt Menu

        private void Encrypt_Click(object sender, EventArgs e)
        {
            using (var form = new ManageEncryption())
                form.ShowDialog();
        }

        #endregion Encrypt Menu

        #region Themes Menu

        private void Themes_Click(object sender, EventArgs e)
        {
            using (var form = new ManageTheme())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Globals.SetTheme(this);
                    UpdateCoins();
                }
            }
        }

        #endregion Themes Menu

        #region Donate Menu

        private void Donate_Click(object sender, EventArgs e)
        {
            using (var form = new PopupDonate())
                form.ShowDialog();
        }

        #endregion Donate Menu

        #region Help Menu

        private void Help_Click(object sender, EventArgs e)
        {
            using (var form = new Tutorial())
                form.ShowDialog();
        }

        #endregion Help Menu

        #region About Menu

        private void About_Click(object sender, EventArgs e)
        {
            using (var form = new PopupAbout())
                form.ShowDialog();
        }

        #endregion About Menu

        #endregion Events

        private void timerSave_Tick(object sender, EventArgs e)
        {
            {
                if (MainService.Unsaved && !updatingCoins)
                {
                    updatingCoins = true;
                    SavePortfolio(PortfolioService.PortfolioServiceInstance.CurrentPortfolio);
                    updatingCoins = false;
                    MainService.Unsaved = false;
                }
            }
        }

        private void ShowKeyChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked == true)
                txtCoinMarketcapApiKey.UseSystemPasswordChar = false;
            else
                txtCoinMarketcapApiKey.UseSystemPasswordChar = true;
        }
    }
}