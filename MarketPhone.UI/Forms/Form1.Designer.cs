namespace MarketPhone.UI.Forms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            NameLabel = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SingUpButton = new Button();
            BackLabel = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // NameLabel
            // 
            resources.ApplyResources(NameLabel, "NameLabel");
            NameLabel.Name = "NameLabel";
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // textBox3
            // 
            resources.ApplyResources(textBox3, "textBox3");
            textBox3.Name = "textBox3";
            // 
            // textBox4
            // 
            resources.ApplyResources(textBox4, "textBox4");
            textBox4.Name = "textBox4";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // SingUpButton
            // 
            resources.ApplyResources(SingUpButton, "SingUpButton");
            SingUpButton.Name = "SingUpButton";
            SingUpButton.UseVisualStyleBackColor = true;
            SingUpButton.Click += SingUpButton_Click;
            // 
            // BackLabel
            // 
            resources.ApplyResources(BackLabel, "BackLabel");
            BackLabel.ForeColor = Color.FromArgb(239, 4, 4);
            BackLabel.Name = "BackLabel";
            BackLabel.Click += BackLabel_Click_1;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(94, 153, 219);
            Controls.Add(BackLabel);
            Controls.Add(SingUpButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(NameLabel);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label NameLabel;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Button SingUpButton;
        private Label BackLabel;
    }
}