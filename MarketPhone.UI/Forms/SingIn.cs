namespace MarketPhone.UI.Forms
{
    public partial class SingIn : Form
    {
        public SingIn()
        {
            InitializeComponent();
            this.PasswordBox.UseSystemPasswordChar = true;
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

        private void SingInButton_Click(object sender, EventArgs e)
        {

        }
        Point lastPoint;
        private void SingIn_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void SingIn_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void SingUpLabel_MouseEnter(object sender, EventArgs e)
        {
            SingUpLabel.ForeColor = Color.Red;
        }

        private void SingUpLabel_MouseLeave(object sender, EventArgs e)
        {
            SingUpLabel.ForeColor = Color.Black;
        }

        private void ExitLabel_MouseEnter(object sender, EventArgs e)
        {
            ExitLabel.ForeColor = Color.Red;
        }

        private void ExitLabel_MouseLeave(object sender, EventArgs e)
        {
            ExitLabel.ForeColor = Color.Black;
        }

        private void SingUpLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
