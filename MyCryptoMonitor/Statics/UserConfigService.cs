using MyCryptoMonitor.Configs;
using MyCryptoMonitor.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyCryptoMonitor.Statics
{
    public class UserConfigService
    {
        #region Public Variables

        public static readonly string DataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MyCryptoMonitor\\";

        static UserConfigService()
        {
            if (!Directory.Exists(DataFolder))
                Directory.CreateDirectory(DataFolder);
        }

        public static string CoinMarketcapApiKey { get { return UserConfig.CoinMarketcapApiKey; } set { UserConfig.CoinMarketcapApiKey = value; Save(); } }
        public static int CoinMarketcapCoinsRequestLimit { get { return UserConfig.CoinMarketcapCoinsRequestLimit; } set { UserConfig.CoinMarketcapCoinsRequestLimit = value; Save(); } }
        public static string Currency { get { return UserConfig.Currency; } set { UserConfig.Currency = value; Save(); MainService.SetCurrencySymbol(); } }
        public static List<string> CustomCoins { get => UserConfig.CustomCoins.ToList(); }
        public static bool DeleteAlerts { get { return UserConfig.DeleteAlerts; } set { UserConfig.DeleteAlerts = value; Save(); } }
        public static bool Encrypted { get { return UserConfig.Encrypted; } set { UserConfig.Encrypted = value; Save(); } }
        public static string EncryptionCheck { get { return UserConfig.EncryptionCheck; } set { UserConfig.EncryptionCheck = value; Save(); } }
        public static int RefreshTime { get { return UserConfig.RefreshTime; } set { UserConfig.RefreshTime = value; Save(); } }
        public static string SaltKey { get => UserConfig.SaltKey; }
        public static string StartupPortfolio { get { return UserConfig.StartupPortfolio; } set { UserConfig.StartupPortfolio = value; Save(); } }
        public static Theme Theme { get { return UserConfig.Theme; } set { UserConfig.Theme = value; Save(); } }
        public static bool TutorialCompleted { get { return UserConfig.TutorialCompleted; } set { UserConfig.TutorialCompleted = value; Save(); } }

        #endregion Public Variables

        #region Private Variables

        private static string FILENAME = DataFolder + "User.config";
        private static UserConfig UserConfig { get; set; }

        #endregion Private Variables

        #region Manage

        public static void Create()
        {
            File.WriteAllText(FILENAME, JsonConvert.SerializeObject(new UserConfig()));
            Load();
        }

        public static void Delete()
        {
            if (File.Exists(FILENAME))
                File.Delete(FILENAME);

            Create();
        }

        public static void Load()
        {
            if (File.Exists(FILENAME))
                UserConfig = JsonConvert.DeserializeObject<UserConfig>(File.ReadAllText(FILENAME));
            else
                Create();
        }

        private static void Save()
        {
            File.WriteAllText(FILENAME, JsonConvert.SerializeObject(UserConfig));
        }

        #endregion Manage
    }
}