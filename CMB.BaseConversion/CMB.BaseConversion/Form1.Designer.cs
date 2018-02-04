namespace CMB.BaseConversion
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.WinClose = new System.Windows.Forms.PictureBox();
            this.WinMinimise = new System.Windows.Forms.PictureBox();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinMinimise)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.SystemColors.Control;
            this.TitleBar.Controls.Add(this.WinClose);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(720, 30);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // WinClose
            // 
            this.WinClose.Image = ((System.Drawing.Image)(resources.GetObject("WinClose.Image")));
            this.WinClose.Location = new System.Drawing.Point(696, 6);
            this.WinClose.Name = "WinClose";
            this.WinClose.Size = new System.Drawing.Size(18, 18);
            this.WinClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.WinClose.TabIndex = 1;
            this.WinClose.TabStop = false;
            this.WinClose.Click += new System.EventHandler(this.WinClose_Click);
            // 
            // WinMinimise
            // 
            this.WinMinimise.Image = ((System.Drawing.Image)(resources.GetObject("WinMinimise.Image")));
            this.WinMinimise.Location = new System.Drawing.Point(674, 6);
            this.WinMinimise.Name = "WinMinimise";
            this.WinMinimise.Size = new System.Drawing.Size(18, 18);
            this.WinMinimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.WinMinimise.TabIndex = 1;
            this.WinMinimise.TabStop = false;
            this.WinMinimise.Click += new System.EventHandler(this.WinMinimise_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(720, 405);
            this.Controls.Add(this.WinMinimise);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Base Conversion";
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WinClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinMinimise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.PictureBox WinClose;
        private System.Windows.Forms.PictureBox WinMinimise;
    }
}

