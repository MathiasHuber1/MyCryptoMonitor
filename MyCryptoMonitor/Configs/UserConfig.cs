using MyCryptoMonitor.Objects;

namespace MyCryptoMonitor.Configs
{
    public class UserConfig
    {
        public string CoinMarketcapApiKey { get; set; } = null;
        public int CoinMarketcapCoinsRequestLimit { get; set; } = 100;
        public string Currency { get; set; } = "USD";
        public string[] CustomCoins { get; set; } = new string[] { "$$$", "MRK" };
        public bool DeleteAlerts { get; set; } = false;
        public bool Encrypted { get; set; } = false;
        public string EncryptionCheck { get; set; } = string.Empty;
        public int RefreshTime { get; set; } = 30000;
        public string SaltKey { get; set; } = "QM4436DL3A259EFXYNZEW4TCVVY5QZJG9CXFEKFW";
        public string StartupPortfolio { get; set; } = "Default";
        public Theme Theme { get; set; } = new Theme();
        public bool TutorialCompleted { get; set; } = false;
    }
}