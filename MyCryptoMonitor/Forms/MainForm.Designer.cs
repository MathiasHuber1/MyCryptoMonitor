namespace MyCryptoMonitor.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePortfolioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addPortfolioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.loadPortfolioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addPortfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProfitPercentage = new System.Windows.Forms.Label();
            this.lblTotalInvested = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTotalPositiveProfit = new System.Windows.Forms.Label();
            this.lblTotalNegativeProfit = new System.Windows.Forms.Label();
            this.lblOverallTotal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRefreshTime = new System.Windows.Forms.Label();
            this.lblRunningTime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.timerSave = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxShow = new System.Windows.Forms.CheckBox();
            this.txtCoinMarketcapApiKey = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownCurrenciesToRequest = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.txtRefreshTime = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrenciesToRequest)).BeginInit();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.coinsToolStripMenuItem,
            this.alertsToolStripMenuItem,
            this.savePortfolioMenu,
            this.loadPortfolioMenu,
            this.encryptToolStripMenuItem,
            this.themesToolStripMenuItem,
            this.donateToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1348, 28);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.Open_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.Reset_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // coinsToolStripMenuItem
            // 
            this.coinsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.removeAllToolStripMenuItem});
            this.coinsToolStripMenuItem.Enabled = false;
            this.coinsToolStripMenuItem.Name = "coinsToolStripMenuItem";
            this.coinsToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.coinsToolStripMenuItem.Text = "Coins";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.addToolStripMenuItem.Text = "Add Coin";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddCoin_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.removeToolStripMenuItem.Text = "Remove Coin";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveCoin_Click);
            // 
            // removeAllToolStripMenuItem
            // 
            this.removeAllToolStripMenuItem.Name = "removeAllToolStripMenuItem";
            this.removeAllToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.removeAllToolStripMenuItem.Text = "Remove All";
            this.removeAllToolStripMenuItem.Click += new System.EventHandler(this.RemoveAllCoins_Click);
            // 
            // alertsToolStripMenuItem
            // 
            this.alertsToolStripMenuItem.Enabled = false;
            this.alertsToolStripMenuItem.Name = "alertsToolStripMenuItem";
            this.alertsToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.alertsToolStripMenuItem.Text = "Alerts";
            this.alertsToolStripMenuItem.Click += new System.EventHandler(this.Alerts_Click);
            // 
            // savePortfolioMenu
            // 
            this.savePortfolioMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPortfolioToolStripMenuItem1,
            this.toolStripMenuItem2});
            this.savePortfolioMenu.Name = "savePortfolioMenu";
            this.savePortfolioMenu.Size = new System.Drawing.Size(116, 24);
            this.savePortfolioMenu.Text = "Save Portfolio";
            // 
            // addPortfolioToolStripMenuItem1
            // 
            this.addPortfolioToolStripMenuItem1.Name = "addPortfolioToolStripMenuItem1";
            this.addPortfolioToolStripMenuItem1.Size = new System.Drawing.Size(214, 26);
            this.addPortfolioToolStripMenuItem1.Text = "Manage Portfolios";
            this.addPortfolioToolStripMenuItem1.Click += new System.EventHandler(this.ManagePortfolios_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(211, 6);
            // 
            // loadPortfolioMenu
            // 
            this.loadPortfolioMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPortfolioToolStripMenuItem,
            this.toolStripMenuItem1});
            this.loadPortfolioMenu.Name = "loadPortfolioMenu";
            this.loadPortfolioMenu.Size = new System.Drawing.Size(118, 24);
            this.loadPortfolioMenu.Text = "Load Portfolio";
            // 
            // addPortfolioToolStripMenuItem
            // 
            this.addPortfolioToolStripMenuItem.Name = "addPortfolioToolStripMenuItem";
            this.addPortfolioToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.addPortfolioToolStripMenuItem.Text = "Manage Portfolios";
            this.addPortfolioToolStripMenuItem.Click += new System.EventHandler(this.ManagePortfolios_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 6);
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            this.encryptToolStripMenuItem.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.themesToolStripMenuItem.Text = "Themes";
            this.themesToolStripMenuItem.Click += new System.EventHandler(this.Themes_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.donateToolStripMenuItem.Text = "Donate";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.Donate_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.Help_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.About_Click);
            // 
            // toolTips
            // 
            this.toolTips.AutomaticDelay = 1500;
            this.toolTips.AutoPopDelay = 15000;
            this.toolTips.InitialDelay = 250;
            this.toolTips.ReshowDelay = 0;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Coin";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTips.SetToolTip(this.label7, "Coin name");
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Price";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTips.SetToolTip(this.label8, "Current price of coin");
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(219, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Bought";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTips.SetToolTip(this.label9, "Amount of coin owned");
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Bought Price";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTips.SetToolTip(this.label5, "Price of coin when bought. If multiple payments, this will be average bought pric" +
        "e. (Paid ÷ Bought)");
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(452, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Total";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTips.SetToolTip(this.label10, "Current value of coins (Price × Bought)");
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Paid";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTips.SetToolTip(this.label1, "Amount of fiat invested");
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(652, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 20);
            this.label16.TabIndex = 33;
            this.label16.Text = "Profit";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTips.SetToolTip(this.label16, "(Total − Paid)");
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(752, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 51;
            this.label12.Text = "Ratio";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTips.SetToolTip(this.label12, "(Profit ÷ Paid)");
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(852, 0);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 20);
            this.label17.TabIndex = 39;
            this.label17.Text = "Change ($)";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTips.SetToolTip(this.label17, "Change since last reset");
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(961, 0);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 20);
            this.label18.TabIndex = 45;
            this.label18.Text = "Change (%)";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTips.SetToolTip(this.label18, "Change since last reset");
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1070, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "1/hr (%)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTips.SetToolTip(this.label2, "Change in the last hour");
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1162, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "24/hr (%)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTips.SetToolTip(this.label3, "Change in the last 24 hours");
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1254, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "7/d (%)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTips.SetToolTip(this.label6, "Change in the last 7 days");
            // 
            // lblProfitPercentage
            // 
            this.lblProfitPercentage.AutoSize = true;
            this.lblProfitPercentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProfitPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfitPercentage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProfitPercentage.Location = new System.Drawing.Point(170, 0);
            this.lblProfitPercentage.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lblProfitPercentage.Name = "lblProfitPercentage";
            this.lblProfitPercentage.Size = new System.Drawing.Size(143, 14);
            this.lblProfitPercentage.TabIndex = 48;
            this.lblProfitPercentage.Tag = "NegativeProfit";
            this.lblProfitPercentage.Text = "0.00";
            this.lblProfitPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTips.SetToolTip(this.lblProfitPercentage, "Profit Percentage ((1 - (Portfolio Value ÷ Total Invested)) ⋅ 100)");
            // 
            // lblTotalInvested
            // 
            this.lblTotalInvested.AutoSize = true;
            this.lblTotalInvested.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalInvested.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInvested.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalInvested.Location = new System.Drawing.Point(0, 0);
            this.lblTotalInvested.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblTotalInvested.Name = "lblTotalInvested";
            this.lblTotalInvested.Size = new System.Drawing.Size(142, 14);
            this.lblTotalInvested.TabIndex = 50;
            this.lblTotalInvested.Tag = "PositiveProfit";
            this.lblTotalInvested.Text = "0.00";
            this.lblTotalInvested.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTips.SetToolTip(this.lblTotalInvested, "Total Invested (Sum of Paid)");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 14);
            this.label4.TabIndex = 49;
            this.label4.Text = "|";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTips.SetToolTip(this.label4, "Total Profits");
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.Location = new System.Drawing.Point(128, 0);
            this.lblTotalProfit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(56, 15);
            this.lblTotalProfit.TabIndex = 1;
            this.lblTotalProfit.Text = "0.00";
            this.lblTotalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTips.SetToolTip(this.lblTotalProfit, "Total Profits");
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(108, 0);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(12, 15);
            this.label20.TabIndex = 51;
            this.label20.Text = "|";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTips.SetToolTip(this.label20, "Total Profits");
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(192, 0);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(12, 15);
            this.label19.TabIndex = 49;
            this.label19.Text = "|";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTips.SetToolTip(this.label19, "Total Profits");
            // 
            // lblTotalPositiveProfit
            // 
            this.lblTotalPositiveProfit.AutoSize = true;
            this.lblTotalPositiveProfit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPositiveProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPositiveProfit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalPositiveProfit.Location = new System.Drawing.Point(208, 0);
            this.lblTotalPositiveProfit.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblTotalPositiveProfit.Name = "lblTotalPositiveProfit";
            this.lblTotalPositiveProfit.Size = new System.Drawing.Size(101, 15);
            this.lblTotalPositiveProfit.TabIndex = 50;
            this.lblTotalPositiveProfit.Tag = "PositiveProfit";
            this.lblTotalPositiveProfit.Text = "0.00";
            this.lblTotalPositiveProfit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTips.SetToolTip(this.lblTotalPositiveProfit, "Total Positive Profits");
            // 
            // lblTotalNegativeProfit
            // 
            this.lblTotalNegativeProfit.AutoSize = true;
            this.lblTotalNegativeProfit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalNegativeProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNegativeProfit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalNegativeProfit.Location = new System.Drawing.Point(4, 0);
            this.lblTotalNegativeProfit.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lblTotalNegativeProfit.Name = "lblTotalNegativeProfit";
            this.lblTotalNegativeProfit.Size = new System.Drawing.Size(100, 15);
            this.lblTotalNegativeProfit.TabIndex = 48;
            this.lblTotalNegativeProfit.Tag = "NegativeProfit";
            this.lblTotalNegativeProfit.Text = "0.00";
            this.lblTotalNegativeProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTips.SetToolTip(this.lblTotalNegativeProfit, "Total Negative Profits");
            // 
            // lblOverallTotal
            // 
            this.lblOverallTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOverallTotal.AutoSize = true;
            this.lblOverallTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallTotal.Location = new System.Drawing.Point(4, 0);
            this.lblOverallTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOverallTotal.Name = "lblOverallTotal";
            this.lblOverallTotal.Size = new System.Drawing.Size(313, 29);
            this.lblOverallTotal.TabIndex = 0;
            this.lblOverallTotal.Text = "0.00";
            this.lblOverallTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTips.SetToolTip(this.lblOverallTotal, "Current portfolio value");
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(4, 48);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(152, 26);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status: Loading";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTips.SetToolTip(this.lblStatus, "Current status of the monitor.");
            // 
            // lblRefreshTime
            // 
            this.lblRefreshTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRefreshTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefreshTime.Location = new System.Drawing.Point(4, 24);
            this.lblRefreshTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefreshTime.Name = "lblRefreshTime";
            this.lblRefreshTime.Size = new System.Drawing.Size(152, 24);
            this.lblRefreshTime.TabIndex = 19;
            this.lblRefreshTime.Text = "Refresh Timer: 00:00";
            this.lblRefreshTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTips.SetToolTip(this.lblRefreshTime, "New data is loaded every 5 seconds. After data is refreshed this timer will reset" +
        ". If the refresh is taking longer than 5 seconds there could be a connection iss" +
        "ue.");
            // 
            // lblRunningTime
            // 
            this.lblRunningTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRunningTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunningTime.Location = new System.Drawing.Point(4, 0);
            this.lblRunningTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRunningTime.Name = "lblRunningTime";
            this.lblRunningTime.Size = new System.Drawing.Size(152, 24);
            this.lblRunningTime.TabIndex = 18;
            this.lblRunningTime.Text = "Running Timer: 00:00";
            this.lblRunningTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTips.SetToolTip(this.lblRunningTime, "The length of time that the current portfolio has been running. Loading a new por" +
        "tfolio will reset this timer.");
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 32);
            this.label11.TabIndex = 52;
            this.label11.Text = "Currency:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTips.SetToolTip(this.label11, "This will change the display currency.");
            // 
            // cbCurrency
            // 
            this.cbCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCurrency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Items.AddRange(new object[] {
            "BTC",
            "ETH",
            "------------",
            "AED",
            "AFN",
            "ALL",
            "ARS",
            "AUD",
            "AZN",
            "BAM",
            "BDT",
            "BGN",
            "BHD",
            "BIF",
            "BND",
            "BOB",
            "BRL",
            "BWP",
            "BYR",
            "CAD",
            "CHF",
            "CLP",
            "CNY",
            "COP",
            "CRC",
            "CZK",
            "DKK",
            "DOP",
            "DZD",
            "EGP",
            "ETB",
            "EUR",
            "GBP",
            "GEL",
            "GHS",
            "GTQ",
            "HKD",
            "HNL",
            "HRK",
            "HUF",
            "IDR",
            "ILS",
            "INR",
            "IQD",
            "IRR",
            "ISK",
            "JMD",
            "JOD",
            "JPY",
            "KES",
            "KHR",
            "KRW",
            "KWD",
            "KZT",
            "LBP",
            "LKR",
            "MAD",
            "MDL",
            "MGA",
            "MMK",
            "MOP",
            "MUR",
            "MXN",
            "MYR",
            "MZN",
            "NAD",
            "NGN",
            "NIO",
            "NOK",
            "NPR",
            "NZD",
            "OMR",
            "PAB",
            "PEN",
            "PHP",
            "PKR",
            "PLN",
            "PYG",
            "QAR",
            "RON",
            "RSD",
            "RUB",
            "RWF",
            "SAR",
            "SEK",
            "SGD",
            "THB",
            "TND",
            "TOP",
            "TRY",
            "TTD",
            "TWD",
            "TZS",
            "UAH",
            "UGX",
            "USD",
            "UYU",
            "UZS",
            "VEF",
            "VND",
            "XAF",
            "XOF",
            "ZAR"});
            this.cbCurrency.Location = new System.Drawing.Point(103, 2);
            this.cbCurrency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(94, 24);
            this.cbCurrency.TabIndex = 53;
            this.toolTips.SetToolTip(this.cbCurrency, "Changes the conversion currency.");
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.tableLayoutPanel6.SetRowSpan(this.label14, 2);
            this.label14.Size = new System.Drawing.Size(267, 32);
            this.label14.TabIndex = 54;
            this.label14.Text = "Number of currencies to request to CoinmarketCap";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTips.SetToolTip(this.label14, "This will change the display currency.");
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 14;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.143149F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.257668F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.572034F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.05566F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.572034F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.572034F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.572034F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.572034F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.30207F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.30207F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.026408F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.026408F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.026408F));
            this.tableLayoutPanel7.Controls.Add(this.label6, 13, 0);
            this.tableLayoutPanel7.Controls.Add(this.label3, 12, 0);
            this.tableLayoutPanel7.Controls.Add(this.label2, 11, 0);
            this.tableLayoutPanel7.Controls.Add(this.label18, 10, 0);
            this.tableLayoutPanel7.Controls.Add(this.label17, 9, 0);
            this.tableLayoutPanel7.Controls.Add(this.label12, 8, 0);
            this.tableLayoutPanel7.Controls.Add(this.label16, 7, 0);
            this.tableLayoutPanel7.Controls.Add(this.label1, 6, 0);
            this.tableLayoutPanel7.Controls.Add(this.label10, 5, 0);
            this.tableLayoutPanel7.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.label9, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 124);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1348, 20);
            this.tableLayoutPanel7.TabIndex = 52;
            // 
            // timerSave
            // 
            this.timerSave.Interval = 500;
            this.timerSave.Tick += new System.EventHandler(this.timerSave_Tick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblOverallTotal, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel9, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(333, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(321, 74);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 5;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.21899F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.56201F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.219F));
            this.tableLayoutPanel9.Controls.Add(this.lblTotalNegativeProfit, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.lblTotalPositiveProfit, 4, 0);
            this.tableLayoutPanel9.Controls.Add(this.label19, 3, 0);
            this.tableLayoutPanel9.Controls.Add(this.label20, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.lblTotalProfit, 2, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(4, 55);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(313, 15);
            this.tableLayoutPanel9.TabIndex = 53;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblTotalInvested, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblProfitPercentage, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 33);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(313, 14);
            this.tableLayoutPanel4.TabIndex = 48;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.lblRunningTime, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblRefreshTime, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblStatus, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(321, 74);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel10, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel12, 1, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(662, 4);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00002F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(650, 74);
            this.tableLayoutPanel5.TabIndex = 51;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel8.Controls.Add(this.checkBoxShow, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.txtCoinMarketcapApiKey, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(4, 40);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(425, 30);
            this.tableLayoutPanel8.TabIndex = 57;
            // 
            // checkBoxShow
            // 
            this.checkBoxShow.Location = new System.Drawing.Point(344, 3);
            this.checkBoxShow.Name = "checkBoxShow";
            this.checkBoxShow.Size = new System.Drawing.Size(78, 21);
            this.checkBoxShow.TabIndex = 0;
            this.checkBoxShow.Text = "Show";
            this.checkBoxShow.UseVisualStyleBackColor = true;
            this.checkBoxShow.CheckedChanged += new System.EventHandler(this.ShowKeyChanged);
            // 
            // txtCoinMarketcapApiKey
            // 
            this.txtCoinMarketcapApiKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCoinMarketcapApiKey.Location = new System.Drawing.Point(194, 4);
            this.txtCoinMarketcapApiKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoinMarketcapApiKey.Name = "txtCoinMarketcapApiKey";
            this.txtCoinMarketcapApiKey.Size = new System.Drawing.Size(143, 22);
            this.txtCoinMarketcapApiKey.TabIndex = 57;
            this.txtCoinMarketcapApiKey.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(182, 30);
            this.label13.TabIndex = 53;
            this.label13.Text = "CoinMarketcap API key";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel6.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.numericUpDownCurrenciesToRequest, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(427, 32);
            this.tableLayoutPanel6.TabIndex = 52;
            // 
            // numericUpDownCurrenciesToRequest
            // 
            this.numericUpDownCurrenciesToRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownCurrenciesToRequest.Location = new System.Drawing.Point(332, 3);
            this.numericUpDownCurrenciesToRequest.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownCurrenciesToRequest.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCurrenciesToRequest.Name = "numericUpDownCurrenciesToRequest";
            this.numericUpDownCurrenciesToRequest.Size = new System.Drawing.Size(92, 22);
            this.numericUpDownCurrenciesToRequest.TabIndex = 55;
            this.numericUpDownCurrenciesToRequest.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.txtRefreshTime, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(436, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(200, 30);
            this.tableLayoutPanel10.TabIndex = 55;
            // 
            // txtRefreshTime
            // 
            this.txtRefreshTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRefreshTime.Location = new System.Drawing.Point(104, 4);
            this.txtRefreshTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtRefreshTime.Name = "txtRefreshTime";
            this.txtRefreshTime.Size = new System.Drawing.Size(92, 22);
            this.txtRefreshTime.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 30);
            this.label15.TabIndex = 54;
            this.label15.Text = "Refresh Interval (sec):";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.cbCurrency, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(436, 39);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(200, 32);
            this.tableLayoutPanel12.TabIndex = 56;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 34);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1316, 82);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 723);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "My Crypto Monitor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrenciesToRequest)).EndInit();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePortfolioMenu;
        private System.Windows.Forms.ToolStripMenuItem loadPortfolioMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alertsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addPortfolioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addPortfolioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Timer timerSave;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblOverallTotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label lblTotalNegativeProfit;
        private System.Windows.Forms.Label lblTotalPositiveProfit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalInvested;
        private System.Windows.Forms.Label lblProfitPercentage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblRunningTime;
        private System.Windows.Forms.Label lblRefreshTime;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TextBox txtRefreshTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDownCurrenciesToRequest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TextBox txtCoinMarketcapApiKey;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBoxShow;
    }
}

