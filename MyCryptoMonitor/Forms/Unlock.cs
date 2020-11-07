using MyCryptoMonitor.Statics;
using System.Windows.Forms;

namespace MyCryptoMonitor.Forms
{
    public partial class Unlock : Form
    {
        #region Public Variables

        public string PasswordInput { get { return txtPassword.Text; } }

        #endregion Public Variables

        #region Constructor

        public Unlock()
        {
            InitializeComponent();
        }

        #endregion Constructor

        #region Events

        private void btnForgot_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }

        private void btnUnlock_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Unlock_Load(object sender, System.EventArgs e)
        {
            Globals.SetTheme(this);
        }

        #endregion Events
    }
}