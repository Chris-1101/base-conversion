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

namespace CMB.BaseConversion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            InitialiseCGothicReg();
            InitialiseCustomisations();
            
            // this.ControlBox = false;
            // this.Text = String.Empty;
        }

        // Custom Form Appearance
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

            NumberInUnderline.BackColor = metroBlue;
        }

        private void NumberIn_Leave(object sender, EventArgs e)
        {
            if (NumberIn.Text == String.Empty)
            {
                NumberIn.Text = "number";
                NumberIn.ForeColor = textDimmed;
                isInitialised = false;
            }

            NumberInUnderline.BackColor = underline;
        }

        // BaseIn Input Field Behaviour
        private void BaseIn_Click(object sender, EventArgs e)
        {
            BaseInDropDown.Show(BaseIn, new Point(0, BaseIn.Height));
            BaseInUnderline.BackColor = metroBlue;
        }

        private void BaseInDropDown_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            BaseIn.Text = e.ClickedItem.Text;
            BaseIn.ForeColor = textActive;
        }

        // BaseInUnderline.BackColor = underline; to all other form items click or focus
        // Sort tabbing order
    }
}
