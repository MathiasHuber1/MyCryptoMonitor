using MyCryptoMonitor.Statics;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace MyCryptoMonitor.Forms
{
    public partial class PopupAbout : Form
    {
        #region Constructor

        public PopupAbout()
        {
            InitializeComponent();
        }

        #endregion Constructor

        #region Events

        private void btnFreepik_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.freepik.com/free-icon/coin-stack_778388.htm");
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/MathiasHuber1/MyCryptoMonitor");
        }

        private void PopupAbout_Load(object sender, EventArgs e)
        {
            Globals.SetTheme(this);
            txtVersion.Text = $"Version: {Assembly.GetExecutingAssembly().GetName().Version.ToString()}";
        }

        #endregion Events
    }
}