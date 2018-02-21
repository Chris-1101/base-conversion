using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CMB.BaseConversion.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Window Drag Control
        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        // Window Controls
        private void MinimiseWin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void CloseWin_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Side Bar Tabs
        private void ResetTab_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("<Placeholder> Reset Clicked </Placeholder>");
        }

        private void ExitTab_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Clear Focus
        private void LayoutContainer_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MinimiseWin.Focus();
        }

        // Number Field Behaviour
        bool isInitialisedNumber = false;
        private SolidColorBrush textActive = new SolidColorBrush(Color.FromRgb(116, 203, 211));
        private SolidColorBrush textDimmed = new SolidColorBrush(Color.FromRgb( 35,  86, 110));

        private void InputNumber_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!isInitialisedNumber)
            {
                InputNumber.Text = String.Empty;
                InputNumber.Foreground = textActive;
                InputNumber.CaretBrush = textActive;
                isInitialisedNumber = true;
            }
        }

        private void InputNumber_LostFocus(object sender, RoutedEventArgs e)
        {
            if (InputNumber.Text == String.Empty)
            {
                InputNumber.Text = "number";
                InputNumber.Foreground = textDimmed;
                isInitialisedNumber = false;
            }
        }

        // BaseIn/Out Field Behaviour
        private void InputBase_DropDownOpened(object sender, EventArgs e)
        {
            ToggleVisibility();
        }

        private void InputBase_DropDownClosed(object sender, EventArgs e)
        {
            ToggleVisibility(false);
        }

        private void ToggleVisibility(bool fade = true)
        {
            DoubleAnimation da = new DoubleAnimation
            {
                To = fade ? 0.1 : 1.0,
                Duration = new Duration(TimeSpan.FromMilliseconds(300))
            };

            ConvertInput.BeginAnimation(OpacityProperty, da);
        }

        // Convert Button Behaviour
        private void ConvertInput_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("<Placeholder> Convert Clicked </Placeholder>");
        }
    }
}
