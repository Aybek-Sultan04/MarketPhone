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

        private void CloseOpenPassword_Click(object sender, EventArgs e)
        {
            CloseOpenPassword.Image = Properties.Resources.CloseEyeForSingIn;
            this.PasswordBox.UseSystemPasswordChar = true;
        }

        private void CloseOpenPassword_DoubleClick(object sender, EventArgs e)
        {
            CloseOpenPassword.Image = Properties.Resources.OpenEyeForSingIn;
            this.PasswordBox.UseSystemPasswordChar = false;
        }

        private void SingInButton_MouseEnter(object sender, EventArgs e)
        {
            this.SingInButton.BackColor = Color.RoyalBlue;
        }

        private void SingInButton_MouseLeave(object sender, EventArgs e)
        {
            this.SingInButton.BackColor = Color.FromArgb(223, 220, 59);
        }
    }
}
