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
        // Base Conversion Instantiation
        private BaseConversion bc = new BaseConversion();
        
        // Main WinForms Constructor
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
        bool isInitialisedNumber = false;

        private void NumberIn_Enter(object sender, EventArgs e)
        {
            if (!isInitialisedNumber)
            {
                NumberIn.Text = String.Empty;
                NumberIn.ForeColor = textActive;
                isInitialisedNumber = true;
            }

            UpdateControlHighlight(sender);
        }

        private void NumberIn_Leave(object sender, EventArgs e)
        {
            if (NumberIn.Text == String.Empty)
            {
                NumberIn.Text = "number";
                NumberIn.ForeColor = textDimmed;
                isInitialisedNumber = false;
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
            string numberInValue = NumberIn.Text.Trim(' ').ToUpper();
            bool isInitialisedBaseIn = Int32.TryParse(ExtractBaseDigits(BaseIn.Text), out int baseInValue);
            bool isInitialisedBaseOut = Int32.TryParse(ExtractBaseDigits(BaseOut.Text), out int baseOutValue);

            string myTitle = "Chris MB's Base Conversion";

            // Validate user input
            if (!isInitialisedNumber)
            {
                MessageBox.Show("Please enter a number to be converted.", myTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!isInitialisedBaseIn)
            {
                MessageBox.Show("Please specify the number's base/radix.", myTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!isInitialisedBaseOut)
            {
                MessageBox.Show("Please specify the base/radix to convert the number to.", myTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!bc.IsValidInput(numberInValue, baseInValue))
            {
                string invalidText = String.Format("You entered an invalid number/base combination.\nValid symbols for base-{0}: {1}", baseInValue.ToString(), GetSymbols());
                MessageBox.Show(invalidText, myTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Send data to result fields
            {
                ResultIn.Text = numberInValue;
                ResultInBase.Text = baseInValue.ToString();
                ResultEquals.Text = "  =  ";
                ResultOut.Text = bc.Convert(numberInValue, baseInValue, baseOutValue);
                ResultOutBase.Text = baseOutValue.ToString();

                UpdateResultPosition();
                UpdateControlHighlight(sender);

                ResultContainer.Show();
            }
        }
        
        private string GetSymbols()
        {
            int baseInValue = Int32.Parse(ExtractBaseDigits(BaseIn.Text));
            char[] charPool = bc.RequestBaseNSymbols(baseInValue);
            StringBuilder sb = new StringBuilder();

            foreach (char c in charPool)
            {
                sb.Append(c + ", ");
            }

            sb.Length -= 2;
            return sb.Append(".").ToString();
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
