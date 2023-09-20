using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketPhone.UI.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void BackLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            SingIn singIn = new SingIn();
            singIn.Show();
        }

        private void BackLabel_Click_1(object sender, EventArgs e)
        {
            Hide();
            SingIn singIn = new SingIn();
            singIn.Show();
        }

        private void SingUpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sign Up");
        }
    }
}
