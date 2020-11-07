using MyCryptoMonitor.Configs;
using MyCryptoMonitor.DataSources;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyCryptoMonitor.Statics
{
    public class PortfolioService
    {
        #region Public Variables

        private static PortfolioService portfolioServiceInstance = new PortfolioService();
        private static object portfolioServiceInstanceLocker = new object();

        public static PortfolioService PortfolioServiceInstance
        {
            get
            {
                lock (portfolioServiceInstanceLocker)
                {
                    return portfolioServiceInstance;
                }
            }
        }

        public List<CoinConfig> CoinConfigs { get; set; } = new List<CoinConfig>();
        public string CurrentPortfolio { get; set; }

        #endregion Public Variables

        #region Private Variables

        private const string FILEEXTENSION = ".portfolio";

        #endregion Private Variables

        #region Manage

        public bool Create(string portfolio)
        {
            if (!File.Exists(UserConfigService.DataFolder + portfolio))
            {
                Save(portfolio, new List<CoinConfig>());
                return true;
            }

            return false;
        }

        public void Delete(string portfolio)
        {
            var fullPath = UserConfigService.DataFolder + portfolio + FILEEXTENSION;
            File.Delete(fullPath);
        }

        public void DeleteAll()
        {
            foreach (var portfolio in GetPortfolios())
                File.Delete(UserConfigService.DataFolder + portfolio.FileName);
        }

        public List<PortfolioDataSource> GetPortfolios()
        {
            return (from filePath in Directory.GetFiles(UserConfigService.DataFolder, $"*{FILEEXTENSION}")
                    let name = Path.GetFileNameWithoutExtension(filePath)
                    let fileName = Path.GetFileName(filePath)
                    select new PortfolioDataSource
                    {
                        Name = name,
                        FileName = fileName,
                        Startup = UserConfigService.StartupPortfolio.ExtEquals(name)
                    })
                    .OrderBy(p => p.Name)
                    .ToList();
        }

        public List<CoinConfig> Load(string portfolio)
        {
            CurrentPortfolio = portfolio;
            portfolio += FILEEXTENSION;

            var coinConfigs = File.Exists(UserConfigService.DataFolder + portfolio) ? (UserConfigService.Encrypted ? LoadEncrypted(portfolio) : LoadUnencrypted(portfolio)) : new List<CoinConfig>();

            //Get currency from portfolio
            UserConfigService.Currency = coinConfigs.FirstOrDefault()?.Currency ?? UserConfigService.Currency;

            return coinConfigs;
        }

        public List<CoinConfig> LoadStartup()
        {
            return Load(UserConfigService.StartupPortfolio);
        }

        public void Rename(string oldPortfolio, string newPortfolio)
        {
            oldPortfolio = UserConfigService.DataFolder + oldPortfolio + FILEEXTENSION;
            newPortfolio = UserConfigService.DataFolder + newPortfolio + FILEEXTENSION;
            File.Move(oldPortfolio, newPortfolio);
        }

        public void Save(string portfolio, List<CoinConfig> coinConfigs)
        {
            portfolio += FILEEXTENSION;

            if (UserConfigService.Encrypted)
                File.WriteAllText(UserConfigService.DataFolder + portfolio, EncryptionService.AesEncryptString(JsonConvert.SerializeObject(coinConfigs)));
            else
                File.WriteAllText(UserConfigService.DataFolder + portfolio, JsonConvert.SerializeObject(coinConfigs));
        }

        public void SetStartup(string portfolio)
        {
            UserConfigService.StartupPortfolio = portfolio;
        }

        public void ToggleEncryption()
        {
            foreach (var portfolio in GetPortfolios())
                if (UserConfigService.Encrypted)
                    File.WriteAllText(UserConfigService.DataFolder + portfolio.FileName, JsonConvert.SerializeObject(LoadEncrypted(portfolio.FileName)));
                else
                    File.WriteAllText(UserConfigService.DataFolder + portfolio.FileName, EncryptionService.AesEncryptString(JsonConvert.SerializeObject(LoadUnencrypted(portfolio.FileName))));
        }

        private List<CoinConfig> LoadEncrypted(string portfolio)
        {
            return JsonConvert.DeserializeObject<List<CoinConfig>>(EncryptionService.AesDecryptString(File.ReadAllText(UserConfigService.DataFolder + portfolio))) ?? new List<CoinConfig>();
        }

        private List<CoinConfig> LoadUnencrypted(string portfolio)
        {
            return JsonConvert.DeserializeObject<List<CoinConfig>>(File.ReadAllText(UserConfigService.DataFolder + portfolio)) ?? new List<CoinConfig>();
        }

        #endregion Manage
    }
}