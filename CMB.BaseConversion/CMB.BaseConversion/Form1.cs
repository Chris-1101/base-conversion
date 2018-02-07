using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace CMB.BaseConversion
{
    public partial class MainForm : Form
    {
        // Main Form Constructor
        public MainForm()
        {
            InitializeComponent();

            InitialiseCGothicReg();
            InitialiseCustomisations();
            
            // this.ControlBox = false;
            // this.Text = String.Empty;
        }

        // Initialise Embedded Font
        private void InitialiseCGothicReg()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();

            int fontLength = Properties.Resources.CGothicReg.Length;
            byte[] fontData = Properties.Resources.CGothicReg;

            IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontData, 0, data, fontLength);

            pfc.AddMemoryFont(data, fontLength);

            NumberIn.Font = new Font(pfc.Families[0], NumberIn.Font.Size);
            BaseIn.Font = new Font(pfc.Families[0], BaseIn.Font.Size);
            BaseOut.Font = new Font(pfc.Families[0], BaseOut.Font.Size);

            ResultIn.Font = new Font(pfc.Families[0], ResultIn.Font.Size);
            ResultInBase.Font = new Font(pfc.Families[0], ResultInBase.Font.Size);
            ResultEquals.Font = new Font(pfc.Families[0], ResultEquals.Font.Size);
            ResultOut.Font = new Font(pfc.Families[0], ResultOut.Font.Size);
            ResultOutBase.Font = new Font(pfc.Families[0], ResultOutBase.Font.Size);
        }

        // Initialise Custom Form Appearance
        private Color metroGrey = Color.FromArgb(59, 68, 78);
        private Color metroBlue = Color.FromArgb(49, 202, 252);
        private Color textDimmed = Color.FromArgb(94, 105, 116);
        private Color textActive = Color.FromArgb(216, 219, 220);
        private Color underline = Color.FromArgb(163, 172, 178);

        private void InitialiseCustomisations()
        {
            this.BackColor = metroGrey;
            SideBar.BackColor = metroBlue;

            NumberIn.BackColor = metroGrey;
            NumberIn.ForeColor = textDimmed;
            NumberInUnderline.BackColor = underline;
            BaseIn.ForeColor = textDimmed;
            BaseInUnderline.BackColor = underline;
            BaseOut.ForeColor = textDimmed;
            BaseOutUnderline.BackColor = underline;
            
            ResultIn.ForeColor = textActive;
            ResultInBase.ForeColor = underline;
            ResultEquals.ForeColor = textActive;
            ResultOut.ForeColor = metroBlue;
            ResultOutBase.ForeColor = underline;

            ResultContainer.Hide();
        }

        // Make the Main Form Draggable
        private bool mouseDown;
        private Point lastLocation;

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        // Window Controls
        private void WinClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WinMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Control Which Elements Gain Highlight
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = TitleImage;
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            UpdateControlHighlight(sender);
        }

        private void ResultContainer_Click(object sender, EventArgs e)
        {
            UpdateControlHighlight(sender);
        }

        private void UpdateControlHighlight(object sender)
        {
            NumberInUnderline.BackColor = underline;
            BaseInUnderline.BackColor = underline;
            BaseOutUnderline.BackColor = underline;

            if (!sender.Equals(NumberIn))
                this.ActiveControl = TitleImage;

            if (sender.Equals(NumberIn))
                NumberInUnderline.BackColor = metroBlue;

            if (sender.Equals(BaseIn))
                BaseInUnderline.BackColor = metroBlue;

            if (sender.Equals(BaseOut))
                BaseOutUnderline.BackColor = metroBlue;
        }

        // Number Input Field Bheaviour
        bool isInitialised = false;

        private void NumberIn_Enter(object sender, EventArgs e)
        {
            if (!isInitialised)
            {
                NumberIn.Text = String.Empty;
                NumberIn.ForeColor = textActive;
                isInitialised = true;
            }

            UpdateControlHighlight(sender);
        }

        private void NumberIn_Leave(object sender, EventArgs e)
        {
            if (NumberIn.Text == String.Empty)
            {
                NumberIn.Text = "number";
                NumberIn.ForeColor = textDimmed;
                isInitialised = false;
            }
        }

        // BaseIn/BaseOut Input Field Behaviour
        bool isFromBaseIn;

        private void BaseIn_Click(object sender, EventArgs e)
        {
            BaseDropDown.Show(BaseInUnderline, new Point(0, BaseInUnderline.Height + 1));
            isFromBaseIn = true;

            UpdateControlHighlight(sender);
        }

        private void BaseOut_Click(object sender, EventArgs e)
        {
            BaseDropDown.Show(BaseOutUnderline, new Point(0, BaseOutUnderline.Height + 1));
            isFromBaseIn = false;

            UpdateControlHighlight(sender);
        }

        private void BaseInDropDown_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (isFromBaseIn)
            {
                BaseIn.Text = e.ClickedItem.Text;
                BaseIn.ForeColor = textActive;
            }
            else
            {
                BaseOut.Text = e.ClickedItem.Text;
                BaseOut.ForeColor = textActive;
            }
        }

        // Convert Button Behaviour
        private void Convert_Click(object sender, EventArgs e)
        {
            if (isInitialised)
            {
                ResultIn.Text = NumberIn.Text;
                ResultInBase.Text = ExtractBaseDigits(BaseIn.Text);
                ResultEquals.Text = "  =  ";
                ResultOut.Text = "placeholder result";
                ResultOutBase.Text = ExtractBaseDigits(BaseOut.Text);

                UpdateResultPosition();
                UpdateControlHighlight(sender);

                ResultContainer.Show();
            }
            else
            {
                MessageBox.Show("Please enter a number to be converted!", "Chris MB's Base Conversion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // Needs more work after base conversion class has been implemented
        }

        private string ExtractBaseDigits(string str)
        {
            return Regex.Match(str, "(\\d+)").Groups[1].Value;
        }

        private void UpdateResultPosition()
        {
            int totalWidth = ResultContainer.Width;
            int labelWidth = ResultIn.Width + ResultInBase.Width + ResultEquals.Width + ResultOut.Width + ResultOutBase.Width;
            int newPositionX = (totalWidth - labelWidth) / 2;
            int newPositionY = (ResultContainer.Height - ResultIn.Height) / 2;

            int baseOffsetX = 3;
            int subscriptOffset = 10;

            ResultIn.Location = new Point(newPositionX, newPositionY);
            ResultInBase.Location = new Point(ResultIn.Right - baseOffsetX, newPositionY + subscriptOffset);
            ResultEquals.Location = new Point(ResultInBase.Right, newPositionY);
            ResultOut.Location = new Point(ResultEquals.Right, newPositionY);
            ResultOutBase.Location = new Point(ResultOut.Right - baseOffsetX, newPositionY + subscriptOffset);
        }

        // Reset Form
        private void ResetAllFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumberIn.Clear();
            NumberIn_Leave(sender, EventArgs.Empty);
            BaseIn.Text = "base";
            BaseIn.ForeColor = textDimmed;
            BaseOut.Text = "convert to";
            BaseOut.ForeColor = textDimmed;
            ResultContainer.Hide();

            // MainForm newForm = new MainForm();
            // newForm.Show();
            // this.Dispose(false);
        }
    }
}
