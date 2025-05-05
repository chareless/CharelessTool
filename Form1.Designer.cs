namespace CharelessTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripButtonAbout = new ToolStripButton();
            toolStripButtonUpdate = new ToolStripButton();
            toolStripButtonContact = new ToolStripButton();
            buttonDigitalDiary = new Button();
            buttonRandomTools = new Button();
            buttonOrtalama = new Button();
            buttonInstaApp = new Button();
            buttonBackpack = new Button();
            buttonTombala = new Button();
            buttonEarthquakeApp = new Button();
            buttonEarthquakeConsole = new Button();
            buttonInstaConsole = new Button();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonAbout, toolStripButtonUpdate, toolStripButtonContact });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAbout
            // 
            toolStripButtonAbout.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonAbout.Image = (Image)resources.GetObject("toolStripButtonAbout.Image");
            toolStripButtonAbout.ImageTransparentColor = Color.Magenta;
            toolStripButtonAbout.Name = "toolStripButtonAbout";
            toolStripButtonAbout.Size = new Size(61, 22);
            toolStripButtonAbout.Text = "Hakkında";
            toolStripButtonAbout.Click += toolStripButtonAbout_Click;
            // 
            // toolStripButtonUpdate
            // 
            toolStripButtonUpdate.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonUpdate.Image = (Image)resources.GetObject("toolStripButtonUpdate.Image");
            toolStripButtonUpdate.ImageTransparentColor = Color.Magenta;
            toolStripButtonUpdate.Name = "toolStripButtonUpdate";
            toolStripButtonUpdate.Size = new Size(133, 22);
            toolStripButtonUpdate.Text = "Güncellemeleri Denetle";
            toolStripButtonUpdate.Click += toolStripButtonUpdate_Click;
            // 
            // toolStripButtonContact
            // 
            toolStripButtonContact.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonContact.Image = (Image)resources.GetObject("toolStripButtonContact.Image");
            toolStripButtonContact.ImageTransparentColor = Color.Magenta;
            toolStripButtonContact.Name = "toolStripButtonContact";
            toolStripButtonContact.Size = new Size(72, 22);
            toolStripButtonContact.Text = "Sorun Bildir";
            toolStripButtonContact.Click += toolStripButtonContact_Click;
            // 
            // buttonDigitalDiary
            // 
            buttonDigitalDiary.BackColor = Color.Teal;
            buttonDigitalDiary.FlatStyle = FlatStyle.Flat;
            buttonDigitalDiary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonDigitalDiary.Location = new Point(50, 100);
            buttonDigitalDiary.Name = "buttonDigitalDiary";
            buttonDigitalDiary.Size = new Size(200, 50);
            buttonDigitalDiary.TabIndex = 1;
            buttonDigitalDiary.Text = "Digital Diary";
            buttonDigitalDiary.UseVisualStyleBackColor = true;
            buttonDigitalDiary.Click += buttonDigitalDiary_Click;
            // 
            // buttonRandomTools
            // 
            buttonRandomTools.BackColor = Color.Teal;
            buttonRandomTools.FlatStyle = FlatStyle.Flat;
            buttonRandomTools.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonRandomTools.Location = new Point(300, 100);
            buttonRandomTools.Name = "buttonRandomTools";
            buttonRandomTools.Size = new Size(200, 50);
            buttonRandomTools.TabIndex = 2;
            buttonRandomTools.Text = "Random Tools";
            buttonRandomTools.UseVisualStyleBackColor = true;
            buttonRandomTools.Click += buttonRandomTools_Click;
            // 
            // buttonOrtalama
            // 
            buttonOrtalama.BackColor = Color.Teal;
            buttonOrtalama.FlatStyle = FlatStyle.Flat;
            buttonOrtalama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonOrtalama.Location = new Point(550, 100);
            buttonOrtalama.Name = "buttonOrtalama";
            buttonOrtalama.Size = new Size(200, 50);
            buttonOrtalama.TabIndex = 3;
            buttonOrtalama.Text = "Ortalama Hesaplama";
            buttonOrtalama.UseVisualStyleBackColor = true;
            buttonOrtalama.Click += buttonOrtalama_Click;
            // 
            // buttonInstaApp
            // 
            buttonInstaApp.BackColor = Color.Teal;
            buttonInstaApp.FlatStyle = FlatStyle.Flat;
            buttonInstaApp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonInstaApp.Location = new Point(550, 180);
            buttonInstaApp.Name = "buttonInstaApp";
            buttonInstaApp.Size = new Size(200, 50);
            buttonInstaApp.TabIndex = 6;
            buttonInstaApp.Text = "Insta-Followers App";
            buttonInstaApp.UseVisualStyleBackColor = true;
            buttonInstaApp.Click += buttonInsta_Click;
            // 
            // buttonBackpack
            // 
            buttonBackpack.BackColor = Color.Teal;
            buttonBackpack.FlatStyle = FlatStyle.Flat;
            buttonBackpack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonBackpack.Location = new Point(300, 180);
            buttonBackpack.Name = "buttonBackpack";
            buttonBackpack.Size = new Size(200, 50);
            buttonBackpack.TabIndex = 5;
            buttonBackpack.Text = "Sırt Çantası Problemi";
            buttonBackpack.UseVisualStyleBackColor = true;
            buttonBackpack.Click += buttonBackpack_Click;
            // 
            // buttonTombala
            // 
            buttonTombala.BackColor = Color.Teal;
            buttonTombala.FlatStyle = FlatStyle.Flat;
            buttonTombala.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonTombala.Location = new Point(50, 180);
            buttonTombala.Name = "buttonTombala";
            buttonTombala.Size = new Size(200, 50);
            buttonTombala.TabIndex = 4;
            buttonTombala.Text = "E-Tombala";
            buttonTombala.UseVisualStyleBackColor = true;
            buttonTombala.Click += buttonTombala_Click;
            // 
            // buttonEarthquakeApp
            // 
            buttonEarthquakeApp.BackColor = Color.Teal;
            buttonEarthquakeApp.FlatStyle = FlatStyle.Flat;
            buttonEarthquakeApp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonEarthquakeApp.Location = new Point(50, 260);
            buttonEarthquakeApp.Name = "buttonEarthquakeApp";
            buttonEarthquakeApp.Size = new Size(200, 50);
            buttonEarthquakeApp.TabIndex = 7;
            buttonEarthquakeApp.Text = "Earthquake Monitor App";
            buttonEarthquakeApp.UseVisualStyleBackColor = true;
            buttonEarthquakeApp.Click += buttonEarthquake_Click;
            // 
            // buttonEarthquakeConsole
            // 
            buttonEarthquakeConsole.BackColor = Color.Teal;
            buttonEarthquakeConsole.FlatStyle = FlatStyle.Flat;
            buttonEarthquakeConsole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonEarthquakeConsole.Location = new Point(300, 260);
            buttonEarthquakeConsole.Name = "buttonEarthquakeConsole";
            buttonEarthquakeConsole.Size = new Size(200, 50);
            buttonEarthquakeConsole.TabIndex = 8;
            buttonEarthquakeConsole.Text = "Earthquake Console";
            buttonEarthquakeConsole.UseVisualStyleBackColor = true;
            buttonEarthquakeConsole.Click += buttonEarthquakeConsole_Click;
            // 
            // buttonInstaConsole
            // 
            buttonInstaConsole.BackColor = Color.Teal;
            buttonInstaConsole.FlatStyle = FlatStyle.Flat;
            buttonInstaConsole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonInstaConsole.Location = new Point(550, 260);
            buttonInstaConsole.Name = "buttonInstaConsole";
            buttonInstaConsole.Size = new Size(200, 50);
            buttonInstaConsole.TabIndex = 9;
            buttonInstaConsole.Text = "Insta-Followers Console";
            buttonInstaConsole.UseVisualStyleBackColor = true;
            buttonInstaConsole.Click += buttonInstaConsole_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 407);
            Controls.Add(buttonInstaConsole);
            Controls.Add(buttonEarthquakeConsole);
            Controls.Add(buttonEarthquakeApp);
            Controls.Add(buttonInstaApp);
            Controls.Add(buttonBackpack);
            Controls.Add(buttonTombala);
            Controls.Add(buttonOrtalama);
            Controls.Add(buttonRandomTools);
            Controls.Add(buttonDigitalDiary);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CharelessTool";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonAbout;
        private ToolStripButton toolStripButtonUpdate;
        private ToolStripButton toolStripButtonContact;
        private Button buttonDigitalDiary;
        private Button buttonRandomTools;
        private Button buttonOrtalama;
        private Button buttonInstaApp;
        private Button buttonBackpack;
        private Button buttonTombala;
        private Button buttonEarthquakeApp;
        private Button buttonEarthquakeConsole;
        private Button buttonInstaConsole;
    }
}
