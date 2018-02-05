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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SideBar = new System.Windows.Forms.Panel();
            this.NumberIn = new System.Windows.Forms.TextBox();
            this.NumberInUnderline = new System.Windows.Forms.Panel();
            this.HintToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BaseInDropDown = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.base2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseIn = new System.Windows.Forms.Label();
            this.BaseInUnderline = new System.Windows.Forms.Panel();
            this.base5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base16ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base26ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base36ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseInHint = new System.Windows.Forms.PictureBox();
            this.NumberInHint = new System.Windows.Forms.PictureBox();
            this.WinClose = new System.Windows.Forms.PictureBox();
            this.WinMinimise = new System.Windows.Forms.PictureBox();
            this.TitleImage = new System.Windows.Forms.PictureBox();
            this.BaseInDropDownArrow = new System.Windows.Forms.PictureBox();
            this.BaseInDropDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaseInHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberInHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinMinimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseInDropDownArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(2, 405);
            this.SideBar.TabIndex = 2;
            // 
            // NumberIn
            // 
            this.NumberIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumberIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberIn.Location = new System.Drawing.Point(90, 104);
            this.NumberIn.Name = "NumberIn";
            this.NumberIn.Size = new System.Drawing.Size(259, 22);
            this.NumberIn.TabIndex = 3;
            this.NumberIn.Text = "number";
            this.NumberIn.Enter += new System.EventHandler(this.NumberIn_Enter);
            this.NumberIn.Leave += new System.EventHandler(this.NumberIn_Leave);
            // 
            // NumberInUnderline
            // 
            this.NumberInUnderline.Location = new System.Drawing.Point(91, 135);
            this.NumberInUnderline.Name = "NumberInUnderline";
            this.NumberInUnderline.Size = new System.Drawing.Size(259, 1);
            this.NumberInUnderline.TabIndex = 5;
            // 
            // HintToolTip
            // 
            this.HintToolTip.AutomaticDelay = 0;
            this.HintToolTip.AutoPopDelay = 5000;
            this.HintToolTip.InitialDelay = 0;
            this.HintToolTip.IsBalloon = true;
            this.HintToolTip.ReshowDelay = 100;
            this.HintToolTip.UseAnimation = false;
            this.HintToolTip.UseFading = false;
            // 
            // BaseInDropDown
            // 
            this.BaseInDropDown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.base2ToolStripMenuItem,
            this.base3ToolStripMenuItem,
            this.base4ToolStripMenuItem,
            this.base5ToolStripMenuItem,
            this.base6ToolStripMenuItem,
            this.base8ToolStripMenuItem,
            this.base10ToolStripMenuItem,
            this.base12ToolStripMenuItem,
            this.base16ToolStripMenuItem,
            this.base20ToolStripMenuItem,
            this.base26ToolStripMenuItem,
            this.base36ToolStripMenuItem});
            this.BaseInDropDown.Name = "contextMenuStrip1";
            this.BaseInDropDown.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.BaseInDropDown.ShowImageMargin = false;
            this.BaseInDropDown.Size = new System.Drawing.Size(181, 268);
            this.BaseInDropDown.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.BaseInDropDown_ItemClicked);
            // 
            // base2ToolStripMenuItem
            // 
            this.base2ToolStripMenuItem.Name = "base2ToolStripMenuItem";
            this.base2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.base2ToolStripMenuItem.Text = "Base-2 (Binary)";
            // 
            // base3ToolStripMenuItem
            // 
            this.base3ToolStripMenuItem.Name = "base3ToolStripMenuItem";
            this.base3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.base3ToolStripMenuItem.Text = "Base-3 (Ternary)";
            // 
            // base4ToolStripMenuItem
            // 
            this.base4ToolStripMenuItem.Name = "base4ToolStripMenuItem";
            this.base4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.base4ToolStripMenuItem.Text = "Base-4 (Quaternary)";
            // 
            // BaseIn
            // 
            this.BaseIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseIn.Location = new System.Drawing.Point(416, 104);
            this.BaseIn.Name = "BaseIn";
            this.BaseIn.Size = new System.Drawing.Size(204, 24);
            this.BaseIn.TabIndex = 10;
            this.BaseIn.Text = "base";
            this.BaseIn.Click += new System.EventHandler(this.BaseIn_Click);
            // 
            // BaseInUnderline
            // 
            this.BaseInUnderline.Location = new System.Drawing.Point(420, 135);
            this.BaseInUnderline.Name = "BaseInUnderline";
            this.BaseInUnderline.Size = new System.Drawing.Size(204, 1);
            this.BaseInUnderline.TabIndex = 11;
            // 
            // base5ToolStripMenuItem
            // 
            this.base5ToolStripMenuItem.Name = "base5ToolStripMenuItem";
            this.base5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.base5ToolStripMenuItem.Text = "Base-5 (Quinary)";
            // 
            // base6ToolStripMenuItem
            // 
            this.base6ToolStripMenuItem.Name = "base6ToolStripMenuItem";
            this.base6ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.base6ToolStripMenuItem.Text = "Base-6 (Senary)";
            // 
            // base8ToolStripMenuItem
            // 
            this.base8ToolStripMenuItem.Name = "base8ToolStripMenuItem";
            this.base8ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.base8ToolStripMenuItem.Text = "Base-8 (Octal)";
            // 
            // base10ToolStripMenuItem
            // 
            this.base10ToolStripMenuItem.Name = "base10ToolStripMenuItem";
            this.base10ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.base10ToolStripMenuItem.Text = "Base-10 (Decimal)";
            // 
            // base12ToolStripMenuItem
            // 
            this.base12ToolStripMenuItem.Name = "base12ToolStripMenuItem";
            this.base12ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.base12ToolStripMenuItem.Text = "Base-12 (Duodecimal)";
            // 
            // base16ToolStripMenuItem
            // 
            this.base16ToolStripMenuItem.Name = "base16ToolStripMenuItem";
            this.base16ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.base16ToolStripMenuItem.Text = "Base-16 (Hexadecimal)";
            // 
            // base20ToolStripMenuItem
            // 
            this.base20ToolStripMenuItem.Name = "base20ToolStripMenuItem";
            this.base20ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.base20ToolStripMenuItem.Text = "Base-20 (Vigesimal)";
            // 
            // base26ToolStripMenuItem
            // 
            this.base26ToolStripMenuItem.Name = "base26ToolStripMenuItem";
            this.base26ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.base26ToolStripMenuItem.Text = "Base-26 (Hexavigesimal)";
            // 
            // base36ToolStripMenuItem
            // 
            this.base36ToolStripMenuItem.Name = "base36ToolStripMenuItem";
            this.base36ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.base36ToolStripMenuItem.Text = "Base-36 (Hexatridecimal)";
            // 
            // BaseInHint
            // 
            this.BaseInHint.Image = global::CMB.BaseConversion.Properties.Resources.Hint;
            this.BaseInHint.Location = new System.Drawing.Point(393, 108);
            this.BaseInHint.Name = "BaseInHint";
            this.BaseInHint.Size = new System.Drawing.Size(16, 16);
            this.BaseInHint.TabIndex = 7;
            this.BaseInHint.TabStop = false;
            this.HintToolTip.SetToolTip(this.BaseInHint, "Select the base/radix of the number you wish to convert");
            // 
            // NumberInHint
            // 
            this.NumberInHint.Image = global::CMB.BaseConversion.Properties.Resources.Hint;
            this.NumberInHint.Location = new System.Drawing.Point(64, 108);
            this.NumberInHint.Name = "NumberInHint";
            this.NumberInHint.Size = new System.Drawing.Size(16, 16);
            this.NumberInHint.TabIndex = 7;
            this.NumberInHint.TabStop = false;
            this.HintToolTip.SetToolTip(this.NumberInHint, "Enter the number you wish to convert");
            // 
            // WinClose
            // 
            this.WinClose.Image = global::CMB.BaseConversion.Properties.Resources.WindowClose;
            this.WinClose.Location = new System.Drawing.Point(689, 16);
            this.WinClose.Name = "WinClose";
            this.WinClose.Size = new System.Drawing.Size(16, 16);
            this.WinClose.TabIndex = 1;
            this.WinClose.TabStop = false;
            this.WinClose.Click += new System.EventHandler(this.WinClose_Click);
            // 
            // WinMinimise
            // 
            this.WinMinimise.Image = global::CMB.BaseConversion.Properties.Resources.WindowMinimise;
            this.WinMinimise.Location = new System.Drawing.Point(655, 16);
            this.WinMinimise.Name = "WinMinimise";
            this.WinMinimise.Size = new System.Drawing.Size(16, 16);
            this.WinMinimise.TabIndex = 1;
            this.WinMinimise.TabStop = false;
            this.WinMinimise.Click += new System.EventHandler(this.WinMinimise_Click);
            // 
            // TitleImage
            // 
            this.TitleImage.Image = global::CMB.BaseConversion.Properties.Resources.CMBBaseConversion;
            this.TitleImage.Location = new System.Drawing.Point(0, 0);
            this.TitleImage.Name = "TitleImage";
            this.TitleImage.Size = new System.Drawing.Size(357, 61);
            this.TitleImage.TabIndex = 6;
            this.TitleImage.TabStop = false;
            // 
            // BaseInDropDownArrow
            // 
            this.BaseInDropDownArrow.Enabled = false;
            this.BaseInDropDownArrow.Image = global::CMB.BaseConversion.Properties.Resources.DropDownArrow;
            this.BaseInDropDownArrow.Location = new System.Drawing.Point(601, 109);
            this.BaseInDropDownArrow.Name = "BaseInDropDownArrow";
            this.BaseInDropDownArrow.Size = new System.Drawing.Size(23, 15);
            this.BaseInDropDownArrow.TabIndex = 12;
            this.BaseInDropDownArrow.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(720, 405);
            this.Controls.Add(this.BaseInUnderline);
            this.Controls.Add(this.BaseInHint);
            this.Controls.Add(this.NumberInHint);
            this.Controls.Add(this.NumberInUnderline);
            this.Controls.Add(this.WinClose);
            this.Controls.Add(this.NumberIn);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.WinMinimise);
            this.Controls.Add(this.TitleImage);
            this.Controls.Add(this.BaseInDropDownArrow);
            this.Controls.Add(this.BaseIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Base Conversion";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.BaseInDropDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseInHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberInHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinMinimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseInDropDownArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox WinMinimise;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.TextBox NumberIn;
        private System.Windows.Forms.PictureBox WinClose;
        private System.Windows.Forms.Panel NumberInUnderline;
        private System.Windows.Forms.PictureBox TitleImage;
        private System.Windows.Forms.PictureBox NumberInHint;
        private System.Windows.Forms.ToolTip HintToolTip;
        private System.Windows.Forms.ContextMenuStrip BaseInDropDown;
        private System.Windows.Forms.ToolStripMenuItem base2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem base3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem base4ToolStripMenuItem;
        private System.Windows.Forms.Label BaseIn;
        private System.Windows.Forms.Panel BaseInUnderline;
        private System.Windows.Forms.PictureBox BaseInHint;
        private System.Windows.Forms.ToolStripMenuItem base5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem base6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem base8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem base10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem base12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem base16ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem base20ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem base26ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem base36ToolStripMenuItem;
        private System.Windows.Forms.PictureBox BaseInDropDownArrow;
    }
}

