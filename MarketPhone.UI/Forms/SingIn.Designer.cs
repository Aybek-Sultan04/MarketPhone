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
            PasswordBox = new TextBox();
            label1 = new Label();
            LoginBox = new TextBox();
            ExitLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 220, 59);
            panel1.Controls.Add(PasswordBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LoginBox);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 600);
            panel1.TabIndex = 0;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(47, 334);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(350, 27);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label ExitLabel;
        private TextBox PasswordBox;
        private Label label1;
        private TextBox LoginBox;
    }
}