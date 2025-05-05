namespace CharelessTool
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            labelVersion = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 112);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(194, 37);
            label1.TabIndex = 0;
            label1.Text = "CharelessTool";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 140);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 1;
            label2.Text = "CharelessTool";
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelVersion.ForeColor = SystemColors.Control;
            labelVersion.Location = new Point(12, 170);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(64, 21);
            labelVersion.TabIndex = 2;
            labelVersion.Text = "Sürüm: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 210);
            label3.Name = "label3";
            label3.Size = new Size(173, 21);
            label3.TabIndex = 3;
            label3.Text = "© 2025 Deniz Sarıbayır";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(12, 240);
            label4.Name = "label4";
            label4.Size = new Size(149, 21);
            label4.TabIndex = 4;
            label4.Text = "Tüm hakları saklıdır.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(12, 280);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 5;
            label5.Text = "Detaylar";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            richTextBox1.Location = new Point(12, 320);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(776, 118);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(212, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labelVersion);
            Controls.Add(label2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hakkında";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label labelVersion;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
    }
}