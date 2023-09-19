namespace MarketPhone.UI.Forms
{
    partial class SingIn
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
            panel1 = new Panel();
            SingInButton = new Button();
            CloseOpenPassword = new PictureBox();
            PasswordBox = new TextBox();
            label1 = new Label();
            LoginBox = new TextBox();
            ExitLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseOpenPassword).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 220, 59);
            panel1.Controls.Add(SingInButton);
            panel1.Controls.Add(CloseOpenPassword);
            panel1.Controls.Add(PasswordBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LoginBox);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 600);
            panel1.TabIndex = 0;
            // 
            // SingInButton
            // 
            SingInButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SingInButton.Location = new Point(156, 418);
            SingInButton.Name = "SingInButton";
            SingInButton.Size = new Size(121, 46);
            SingInButton.TabIndex = 6;
            SingInButton.Text = "Enter";
            SingInButton.UseVisualStyleBackColor = true;
            SingInButton.MouseEnter += SingInButton_MouseEnter;
            SingInButton.MouseLeave += SingInButton_MouseLeave;
            // 
            // CloseOpenPassword
            // 
            CloseOpenPassword.Image = Properties.Resources.CloseEyeForSingIn;
            CloseOpenPassword.Location = new Point(403, 333);
            CloseOpenPassword.Name = "CloseOpenPassword";
            CloseOpenPassword.Size = new Size(44, 44);
            CloseOpenPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseOpenPassword.TabIndex = 5;
            CloseOpenPassword.TabStop = false;
            CloseOpenPassword.Click += CloseOpenPassword_Click;
            CloseOpenPassword.DoubleClick += CloseOpenPassword_DoubleClick;
            // 
            // PasswordBox
            // 
            PasswordBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordBox.Location = new Point(47, 334);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(350, 43);
            PasswordBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(719, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 38);
            label1.TabIndex = 3;
            label1.Text = "X";
            // 
            // LoginBox
            // 
            LoginBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBox.Location = new Point(47, 222);
            LoginBox.Multiline = true;
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(350, 54);
            LoginBox.TabIndex = 0;
            // 
            // ExitLabel
            // 
            ExitLabel.AutoSize = true;
            ExitLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ExitLabel.Location = new Point(971, 0);
            ExitLabel.Name = "ExitLabel";
            ExitLabel.Size = new Size(34, 38);
            ExitLabel.TabIndex = 1;
            ExitLabel.Text = "X";
            ExitLabel.Click += ExitLabel_Click;
            // 
            // SingIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 154, 209);
            ClientSize = new Size(1000, 600);
            Controls.Add(ExitLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SingIn";
            Text = "SingIn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CloseOpenPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label ExitLabel;
        private TextBox PasswordBox;
        private Label label1;
        private TextBox LoginBox;
        private PictureBox CloseOpenPassword;
        private Button SingInButton;
    }
}