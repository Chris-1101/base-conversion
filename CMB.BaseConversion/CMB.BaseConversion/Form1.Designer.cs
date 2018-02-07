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
            this.BaseOutHint = new System.Windows.Forms.PictureBox();
            this.BaseInHint = new System.Windows.Forms.PictureBox();
            this.NumberInHint = new System.Windows.Forms.PictureBox();
            this.BaseDropDown = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.base2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base16ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base26ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base36ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseIn = new System.Windows.Forms.Label();
            this.BaseInUnderline = new System.Windows.Forms.Panel();
            this.BaseOut = new System.Windows.Forms.Label();
            this.BaseOutUnderline = new System.Windows.Forms.Panel();
            this.ResultContainer = new System.Windows.Forms.Panel();
            this.ResultEquals = new System.Windows.Forms.Label();
            this.ResultIn = new System.Windows.Forms.Label();
            this.ResultInBase = new System.Windows.Forms.Label();
            this.ResultOutBase = new System.Windows.Forms.Label();
            this.ResultOut = new System.Windows.Forms.Label();
            this.RightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ResetAllFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Convert = new System.Windows.Forms.PictureBox();
            this.WinClose = new System.Windows.Forms.PictureBox();
            this.WinMinimise = new System.Windows.Forms.PictureBox();
            this.TitleImage = new System.Windows.Forms.PictureBox();
            this.BaseOutDropDownArrow = new System.Windows.Forms.PictureBox();
            this.BaseInDropDownArrow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BaseOutHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseInHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberInHint)).BeginInit();
            this.BaseDropDown.SuspendLayout();
            this.ResultContainer.SuspendLayout();
            this.RightClickMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Convert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinMinimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseOutDropDownArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseInDropDownArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(2, 405);
            this.SideBar.TabIndex = 0;
            // 
            // NumberIn
            // 
            this.NumberIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumberIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberIn.Location = new System.Drawing.Point(90, 104);
            this.NumberIn.Name = "NumberIn";
            this.NumberIn.Size = new System.Drawing.Size(259, 22);
            this.NumberIn.TabIndex = 1;
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
            // BaseOutHint
            // 
            this.BaseOutHint.Image = global::CMB.BaseConversion.Properties.Resources.Hint;
            this.BaseOutHint.Location = new System.Drawing.Point(64, 166);
            this.BaseOutHint.Name = "BaseOutHint";
            this.BaseOutHint.Size = new System.Drawing.Size(16, 16);
            this.BaseOutHint.TabIndex = 7;
            this.BaseOutHint.TabStop = false;
            this.HintToolTip.SetToolTip(this.BaseOutHint, "Select the base/radix you\'d like to convert this number to");
            // 
            // BaseInHint
            // 
            this.BaseInHint.Image = global::CMB.BaseConversion.Properties.Resources.Hint;
            this.BaseInHint.Location = new System.Drawing.Point(393, 108);
            this.BaseInHint.Name = "BaseInHint";
            this.BaseInHint.Size = new System.Drawing.Size(16, 16);
            this.BaseInHint.TabIndex = 7;
            this.BaseInHint.TabStop = false;
            this.HintToolTip.SetToolTip(this.BaseInHint, "Select the base/radix of the number you\'d like to convert");
            // 
            // NumberInHint
            // 
            this.NumberInHint.Image = global::CMB.BaseConversion.Properties.Resources.Hint;
            this.NumberInHint.Location = new System.Drawing.Point(64, 108);
            this.NumberInHint.Name = "NumberInHint";
            this.NumberInHint.Size = new System.Drawing.Size(16, 16);
            this.NumberInHint.TabIndex = 7;
            this.NumberInHint.TabStop = false;
            this.HintToolTip.SetToolTip(this.NumberInHint, "Enter the number you\'d like to convert");
            // 
            // BaseDropDown
            // 
            this.BaseDropDown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.BaseDropDown.Name = "contextMenuStrip1";
            this.BaseDropDown.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.BaseDropDown.ShowImageMargin = false;
            this.BaseDropDown.Size = new System.Drawing.Size(181, 268);
            this.BaseDropDown.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.BaseInDropDown_ItemClicked);
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
            // BaseIn
            // 
            this.BaseIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseIn.Location = new System.Drawing.Point(416, 104);
            this.BaseIn.Name = "BaseIn";
            this.BaseIn.Size = new System.Drawing.Size(204, 24);
            this.BaseIn.TabIndex = 2;
            this.BaseIn.Text = "base";
            this.BaseIn.Click += new System.EventHandler(this.BaseIn_Click);
            // 
            // BaseInUnderline
            // 
            this.BaseInUnderline.Location = new System.Drawing.Point(420, 135);
            this.BaseInUnderline.Name = "BaseInUnderline";
            this.BaseInUnderline.Size = new System.Drawing.Size(204, 1);
            this.BaseInUnderline.TabIndex = 6;
            // 
            // BaseOut
            // 
            this.BaseOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseOut.Location = new System.Drawing.Point(87, 162);
            this.BaseOut.Name = "BaseOut";
            this.BaseOut.Size = new System.Drawing.Size(259, 24);
            this.BaseOut.TabIndex = 3;
            this.BaseOut.Text = "convert to";
            this.BaseOut.Click += new System.EventHandler(this.BaseOut_Click);
            // 
            // BaseOutUnderline
            // 
            this.BaseOutUnderline.Location = new System.Drawing.Point(91, 193);
            this.BaseOutUnderline.Name = "BaseOutUnderline";
            this.BaseOutUnderline.Size = new System.Drawing.Size(259, 1);
            this.BaseOutUnderline.TabIndex = 7;
            // 
            // ResultContainer
            // 
            this.ResultContainer.BackgroundImage = global::CMB.BaseConversion.Properties.Resources.ResultBG;
            this.ResultContainer.Controls.Add(this.ResultEquals);
            this.ResultContainer.Controls.Add(this.ResultIn);
            this.ResultContainer.Controls.Add(this.ResultInBase);
            this.ResultContainer.Controls.Add(this.ResultOutBase);
            this.ResultContainer.Controls.Add(this.ResultOut);
            this.ResultContainer.Location = new System.Drawing.Point(90, 280);
            this.ResultContainer.Name = "ResultContainer";
            this.ResultContainer.Size = new System.Drawing.Size(534, 58);
            this.ResultContainer.TabIndex = 4;
            this.ResultContainer.Click += new System.EventHandler(this.ResultContainer_Click);
            // 
            // ResultEquals
            // 
            this.ResultEquals.AutoSize = true;
            this.ResultEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultEquals.Location = new System.Drawing.Point(249, 18);
            this.ResultEquals.Name = "ResultEquals";
            this.ResultEquals.Size = new System.Drawing.Size(0, 24);
            this.ResultEquals.TabIndex = 15;
            // 
            // ResultIn
            // 
            this.ResultIn.AutoSize = true;
            this.ResultIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultIn.Location = new System.Drawing.Point(117, 18);
            this.ResultIn.Name = "ResultIn";
            this.ResultIn.Size = new System.Drawing.Size(0, 24);
            this.ResultIn.TabIndex = 14;
            // 
            // ResultInBase
            // 
            this.ResultInBase.AutoSize = true;
            this.ResultInBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultInBase.Location = new System.Drawing.Point(183, 18);
            this.ResultInBase.Name = "ResultInBase";
            this.ResultInBase.Size = new System.Drawing.Size(0, 13);
            this.ResultInBase.TabIndex = 14;
            // 
            // ResultOutBase
            // 
            this.ResultOutBase.AutoSize = true;
            this.ResultOutBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultOutBase.Location = new System.Drawing.Point(381, 18);
            this.ResultOutBase.Name = "ResultOutBase";
            this.ResultOutBase.Size = new System.Drawing.Size(0, 13);
            this.ResultOutBase.TabIndex = 14;
            // 
            // ResultOut
            // 
            this.ResultOut.AutoSize = true;
            this.ResultOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultOut.Location = new System.Drawing.Point(315, 18);
            this.ResultOut.Name = "ResultOut";
            this.ResultOut.Size = new System.Drawing.Size(0, 24);
            this.ResultOut.TabIndex = 14;
            // 
            // RightClickMenu
            // 
            this.RightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResetAllFieldsToolStripMenuItem});
            this.RightClickMenu.Name = "RightClickMenu";
            this.RightClickMenu.Size = new System.Drawing.Size(153, 26);
            // 
            // ResetAllFieldsToolStripMenuItem
            // 
            this.ResetAllFieldsToolStripMenuItem.Name = "ResetAllFieldsToolStripMenuItem";
            this.ResetAllFieldsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ResetAllFieldsToolStripMenuItem.Text = "Reset All Fields";
            this.ResetAllFieldsToolStripMenuItem.Click += new System.EventHandler(this.ResetAllFieldsToolStripMenuItem_Click);
            // 
            // Convert
            // 
            this.Convert.Image = global::CMB.BaseConversion.Properties.Resources.ConvertButton;
            this.Convert.Location = new System.Drawing.Point(415, 161);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(214, 38);
            this.Convert.TabIndex = 15;
            this.Convert.TabStop = false;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // WinClose
            // 
            this.WinClose.Image = global::CMB.BaseConversion.Properties.Resources.WindowClose;
            this.WinClose.Location = new System.Drawing.Point(688, 15);
            this.WinClose.Name = "WinClose";
            this.WinClose.Size = new System.Drawing.Size(16, 16);
            this.WinClose.TabIndex = 1;
            this.WinClose.TabStop = false;
            this.WinClose.Click += new System.EventHandler(this.WinClose_Click);
            // 
            // WinMinimise
            // 
            this.WinMinimise.Image = global::CMB.BaseConversion.Properties.Resources.WindowMinimise;
            this.WinMinimise.Location = new System.Drawing.Point(655, 15);
            this.WinMinimise.Name = "WinMinimise";
            this.WinMinimise.Size = new System.Drawing.Size(16, 16);
            this.WinMinimise.TabIndex = 1;
            this.WinMinimise.TabStop = false;
            this.WinMinimise.Click += new System.EventHandler(this.WinMinimise_Click);
            // 
            // TitleImage
            // 
            this.TitleImage.Image = ((System.Drawing.Image)(resources.GetObject("TitleImage.Image")));
            this.TitleImage.Location = new System.Drawing.Point(0, 0);
            this.TitleImage.Name = "TitleImage";
            this.TitleImage.Size = new System.Drawing.Size(357, 61);
            this.TitleImage.TabIndex = 6;
            this.TitleImage.TabStop = false;
            // 
            // BaseOutDropDownArrow
            // 
            this.BaseOutDropDownArrow.Enabled = false;
            this.BaseOutDropDownArrow.Image = global::CMB.BaseConversion.Properties.Resources.DropDownArrow;
            this.BaseOutDropDownArrow.Location = new System.Drawing.Point(327, 167);
            this.BaseOutDropDownArrow.Name = "BaseOutDropDownArrow";
            this.BaseOutDropDownArrow.Size = new System.Drawing.Size(23, 15);
            this.BaseOutDropDownArrow.TabIndex = 12;
            this.BaseOutDropDownArrow.TabStop = false;
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
            this.ContextMenuStrip = this.RightClickMenu;
            this.Controls.Add(this.ResultContainer);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.BaseOutUnderline);
            this.Controls.Add(this.BaseInUnderline);
            this.Controls.Add(this.BaseOutHint);
            this.Controls.Add(this.BaseInHint);
            this.Controls.Add(this.NumberInHint);
            this.Controls.Add(this.NumberInUnderline);
            this.Controls.Add(this.WinClose);
            this.Controls.Add(this.NumberIn);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.WinMinimise);
            this.Controls.Add(this.TitleImage);
            this.Controls.Add(this.BaseOutDropDownArrow);
            this.Controls.Add(this.BaseInDropDownArrow);
            this.Controls.Add(this.BaseIn);
            this.Controls.Add(this.BaseOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Base Conversion";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.BaseOutHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseInHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberInHint)).EndInit();
            this.BaseDropDown.ResumeLayout(false);
            this.ResultContainer.ResumeLayout(false);
            this.ResultContainer.PerformLayout();
            this.RightClickMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Convert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinMinimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseOutDropDownArrow)).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip BaseDropDown;
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
        private System.Windows.Forms.PictureBox BaseOutHint;
        private System.Windows.Forms.PictureBox BaseOutDropDownArrow;
        private System.Windows.Forms.Label BaseOut;
        private System.Windows.Forms.Panel BaseOutUnderline;
        private System.Windows.Forms.PictureBox Convert;
        private System.Windows.Forms.Panel ResultContainer;
        private System.Windows.Forms.Label ResultEquals;
        private System.Windows.Forms.Label ResultIn;
        private System.Windows.Forms.Label ResultInBase;
        private System.Windows.Forms.Label ResultOutBase;
        private System.Windows.Forms.Label ResultOut;
        private System.Windows.Forms.ContextMenuStrip RightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem ResetAllFieldsToolStripMenuItem;
    }
}

