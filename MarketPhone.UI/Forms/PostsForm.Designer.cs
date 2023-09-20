namespace MarketPhone.UI.Forms
{
    partial class PostsForm
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
            openFileDialog1 = new OpenFileDialog();
            panel1 = new Panel();
            button1 = new Button();
            SaveButton = new Button();
            AddButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(SaveButton);
            panel1.Controls.Add(AddButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 575);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 78);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(26, 16);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(680, 13);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(580, 13);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 0;
            AddButton.Text = "add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // PostsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 653);
            Controls.Add(panel1);
            Name = "PostsForm";
            Text = "PostsForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Panel panel1;
        private Button SaveButton;
        private Button AddButton;
        private Button button1;
    }
}