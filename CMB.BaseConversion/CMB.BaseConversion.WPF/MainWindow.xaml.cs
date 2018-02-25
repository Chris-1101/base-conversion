using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace CMB.BaseConversion.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Constructor
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
            // Reset InputNumber
            SetNumberPlaceholder("number", textDimmed, false);

            // Clear InputBaseIn
            InputBaseIn.SelectedIndex = -1;
            InputBaseInPlaceholder.Visibility = Visibility.Visible;

            // Clear InputBaseOut
            InputBaseOut.SelectedIndex = -1;
            InputBaseOutPlaceholder.Visibility = Visibility.Visible;

            // Hide Result
            ResultContainer.Visibility = Visibility.Hidden;

            // Update Status Bar
            SetStatus("Form reset");
            PingStatusBar(Status.Flash);
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
        private bool isInitialisedNumber = false;
        private SolidColorBrush textActive = new SolidColorBrush(Color.FromRgb(69, 230, 233));
        private SolidColorBrush textDimmed = new SolidColorBrush(Color.FromRgb(35,  86, 110));

        private void InputNumber_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!isInitialisedNumber)
            {
                SetNumberPlaceholder(String.Empty, textActive, true);
            }
        }

        private void InputNumber_LostFocus(object sender, RoutedEventArgs e)
        {
            if (InputNumber.Text == String.Empty)
            {
                SetNumberPlaceholder("number", textDimmed, false);
            }
        }

        private void SetNumberPlaceholder(string str, SolidColorBrush scb, bool init)
        {
            InputNumber.Text = str;
            InputNumber.Foreground = scb;
            isInitialisedNumber = init;
        }

        // BaseIn/Out Field Behaviour
        private void InputBase_DropDown(object sender, EventArgs e)
        {
            double fadeOpacity = 0.2;
            Duration fadeDuration = TimeSpan.FromMilliseconds(300);

            DoubleAnimation da = new DoubleAnimation
            {
                To = (ConvertInput.Opacity == 1.0) ? fadeOpacity : 1.0,
                Duration = fadeDuration
            };

            ConvertInput.BeginAnimation(OpacityProperty, da);

            if (sender.Equals(InputBaseIn))
            {
                ResultLabel.BeginAnimation(OpacityProperty, da);
            }
        }

        private void InputBaseIn_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InputBaseInPlaceholder.Visibility = Visibility.Hidden;
        }

        private void InputBaseOut_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InputBaseOutPlaceholder.Visibility = Visibility.Hidden;
        }

        // Convert Button Behaviour
        BaseConversion bc = new BaseConversion();

        private void ConvertInput_Click(object sender, RoutedEventArgs e)
        {
            string num = InputNumber.Text.Trim(' ').ToUpper();
            bool isInitialisedBaseIn = Int32.TryParse(ExtractBaseDigits(InputBaseIn.Text), out int baseIn);
            bool isInitialisedBaseOut = Int32.TryParse(ExtractBaseDigits(InputBaseOut.Text), out int baseOut);

            // Validate user input
            if (!isInitialisedNumber)
            {
                SetStatus("Please enter a number to be converted.");
                PingStatusBar(Status.Warning);
            }
            else if (!isInitialisedBaseIn)
            {
                SetStatus("Please specify the number's base/radix.");
                PingStatusBar(Status.Warning);
            }
            else if (!isInitialisedBaseOut)
            {
                SetStatus("Please specify the base/radix to convert the number to.");
                PingStatusBar(Status.Warning);
            }
            else if (!bc.IsValidInput(num, baseIn))
            {
                string invalidText = String.Format("Invalid input. Valid symbols (base-{0}): {1}", baseIn.ToString(), GetSymbols());
                SetStatus(invalidText);
                PingStatusBar(Status.Error);
            }
            else // Send data to result fields
            {
                ResultNumberIn.Content = num;
                ResultBaseIn.Content = baseIn.ToString();
                ResultNumberOut.Content = bc.Convert(num, baseIn, baseOut);
                ResultBaseOut.Content = baseOut.ToString();
                ResultContainer.Visibility = Visibility.Visible;

                SetStatus("Conversion successful");
                PingStatusBar(Status.Flash);
            }
        }

        private string GetSymbols()
        {
            int baseIn = Int32.Parse(ExtractBaseDigits(InputBaseIn.Text));
            char[] charPool = bc.RequestBaseNSymbols(baseIn);
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

        // Status Bar Behaviour
        private void SetStatus(string status)
        {
            StatusBarLabel.Content = status;
        }

        private void PingStatusBar(Status type)
        {
            DoubleAnimation da = new DoubleAnimation
            {
                From = 1.0, To = 0.0,
                Duration = new Duration(TimeSpan.FromMilliseconds(700)),
            };

            switch(type)
            {
                case Status.Flash:
                    StatusFlash.BeginAnimation(OpacityProperty, da);
                    break;

                case Status.Warning:
                    StatusWarning.BeginAnimation(OpacityProperty, da);
                    break;

                case Status.Error:
                    StatusError.BeginAnimation(OpacityProperty, da);
                    break;

                default:
                    StatusFlash.BeginAnimation(OpacityProperty, da);
                    break;
            }
        }

        private enum Status
        {
            Flash,
            Warning,
            Error
        }
    }
}
