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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
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
    }
}
