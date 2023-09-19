namespace MarketPhone.UI.Forms
{
    public partial class SingIn : Form
    {
        public SingIn()
        {
            InitializeComponent();
            this.PasswordBox.Size = new Size(this.LoginBox.Width, this.LoginBox.Height);
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
