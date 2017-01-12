using MahApps.Metro.Controls;
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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameOfLife
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void A1Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(A1Button.Background == Brushes.Black))
            {
                A1Button.Background = Brushes.Black;
                A1Button.Foreground = Brushes.Black;
               
            }else
            {
                A1Button.ClearValue(Button.BackgroundProperty);
                A1Button.ClearValue(Button.ForegroundProperty);
            }
        }

        private void A2Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(A2Button.Background == Brushes.Black))
            {
                A2Button.Background = Brushes.Black;
                A2Button.Foreground = Brushes.Black;

            }
            else
            {
                A2Button.ClearValue(Button.BackgroundProperty);
                A2Button.ClearValue(Button.ForegroundProperty);
            }
        }

        private void A3Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(A3Button.Background == Brushes.Black))
            {
                A3Button.Background = Brushes.Black;
                A3Button.Foreground = Brushes.Black;

            }
            else
            {
                A3Button.ClearValue(Button.BackgroundProperty);
                A3Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void A4Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(A4Button.Background == Brushes.Black))
            {
                A4Button.Background = Brushes.Black;
                A4Button.Foreground = Brushes.Black;

            }
            else
            {
                A4Button.ClearValue(Button.BackgroundProperty);
                A4Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void A5Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(A5Button.Background == Brushes.Black))
            {
                A5Button.Background = Brushes.Black;
                A5Button.Foreground = Brushes.Black;

            }
            else
            {
                A5Button.ClearValue(Button.BackgroundProperty);
                A5Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void A6Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(A6Button.Background == Brushes.Black))
            {
                A6Button.Background = Brushes.Black;
                A6Button.Foreground = Brushes.Black;

            }
            else
            {
                A6Button.ClearValue(Button.BackgroundProperty);
                A6Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void A7Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(A7Button.Background == Brushes.Black))
            {
                A7Button.Background = Brushes.Black;
                A7Button.Foreground = Brushes.Black;

            }
            else
            {
                A7Button.ClearValue(Button.BackgroundProperty);
                A7Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void A8Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(A8Button.Background == Brushes.Black))
            {
                A8Button.Background = Brushes.Black;
                A8Button.Foreground = Brushes.Black;

            }
            else
            {
                A8Button.ClearValue(Button.BackgroundProperty);
                A8Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void B1Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(B1Button.Background == Brushes.Black))
            {
                B1Button.Background = Brushes.Black;
                B1Button.Foreground = Brushes.Black;

            }
            else
            {
                B1Button.ClearValue(Button.BackgroundProperty);
                B1Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void B2Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(B2Button.Background == Brushes.Black))
            {
                B2Button.Background = Brushes.Black;
                B2Button.Foreground = Brushes.Black;
            }
            else
            {
                B2Button.ClearValue(Button.BackgroundProperty);
                B2Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void B3Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(B3Button.Background == Brushes.Black))
            {
                B3Button.Background = Brushes.Black;
                B3Button.Foreground = Brushes.Black;

            }
            else
            {
                B3Button.ClearValue(Button.BackgroundProperty);
                B3Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void B4Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(B4Button.Background == Brushes.Black))
            {
                B4Button.Background = Brushes.Black;
                B4Button.Foreground = Brushes.Black;

            }
            else
            {
                B4Button.ClearValue(Button.BackgroundProperty);
                B4Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void B5Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(B5Button.Background == Brushes.Black))
            {
                B5Button.Background = Brushes.Black;
                B5Button.Foreground = Brushes.Black;

            }
            else
            {
                B5Button.ClearValue(Button.BackgroundProperty);
                B5Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void B6Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(B6Button.Background == Brushes.Black))
            {
                B6Button.Background = Brushes.Black;
                B6Button.Foreground = Brushes.Black;

            }
            else
            {
                B6Button.ClearValue(Button.BackgroundProperty);
                B6Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void B7Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(B7Button.Background == Brushes.Black))
            {
                B7Button.Background = Brushes.Black;
                B7Button.Foreground = Brushes.Black;

            }
            else
            {
                B7Button.ClearValue(Button.BackgroundProperty);
                B7Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void B8Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(B8Button.Background == Brushes.Black))
            {
                B8Button.Background = Brushes.Black;
                B8Button.Foreground = Brushes.Black;

            }
            else
            {
                B8Button.ClearValue(Button.BackgroundProperty);
                B8Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void C1Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(C1Button.Background == Brushes.Black))
            {
                C1Button.Background = Brushes.Black;
                C1Button.Foreground = Brushes.Black;

            }
            else
            {
                C1Button.ClearValue(Button.BackgroundProperty);
                C1Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void C2Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(C2Button.Background == Brushes.Black))
            {
                C2Button.Background = Brushes.Black;
                C2Button.Foreground = Brushes.Black;

            }
            else
            {
                C2Button.ClearValue(Button.BackgroundProperty);
                C2Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void C3Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(C3Button.Background == Brushes.Black))
            {
                C3Button.Background = Brushes.Black;
                C3Button.Foreground = Brushes.Black;

            }
            else
            {
                C3Button.ClearValue(Button.BackgroundProperty);
                C3Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void C4Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(C4Button.Background == Brushes.Black))
            {
                C4Button.Background = Brushes.Black;
                C4Button.Foreground = Brushes.Black;

            }
            else
            {
                C4Button.ClearValue(Button.BackgroundProperty);
                C4Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void C5Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(C5Button.Background == Brushes.Black))
            {
                C5Button.Background = Brushes.Black;
                C5Button.Foreground = Brushes.Black;

            }
            else
            {
                C5Button.ClearValue(Button.BackgroundProperty);
                C5Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void C6Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(C6Button.Background == Brushes.Black))
            {
                C6Button.Background = Brushes.Black;
                C6Button.Foreground = Brushes.Black;

            }
            else
            {
                C6Button.ClearValue(Button.BackgroundProperty);
                C6Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void C7Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(C7Button.Background == Brushes.Black))
            {
                C7Button.Background = Brushes.Black;
                C7Button.Foreground = Brushes.Black;

            }
            else
            {
                C7Button.ClearValue(Button.BackgroundProperty);
                C7Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void C8Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(C8Button.Background == Brushes.Black))
            {
                C8Button.Background = Brushes.Black;
                C8Button.Foreground = Brushes.Black;

            }
            else
            {
                C8Button.ClearValue(Button.BackgroundProperty);
                C8Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void D1Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(D1Button.Background == Brushes.Black))
            {
                D1Button.Background = Brushes.Black;
                D1Button.Foreground = Brushes.Black;

            }
            else
            {
                D1Button.ClearValue(Button.BackgroundProperty);
                D1Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void D2Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(D2Button.Background == Brushes.Black))
            {
                D2Button.Background = Brushes.Black;
                D2Button.Foreground = Brushes.Black;

            }
            else
            {
                D2Button.ClearValue(Button.BackgroundProperty);
                D2Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void D3Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(D3Button.Background == Brushes.Black))
            {
                D3Button.Background = Brushes.Black;
                D3Button.Foreground = Brushes.Black;

            }
            else
            {
                D3Button.ClearValue(Button.BackgroundProperty);
                D3Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void D4Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(D4Button.Background == Brushes.Black))
            {
                D4Button.Background = Brushes.Black;
                D4Button.Foreground = Brushes.Black;

            }
            else
            {
                D4Button.ClearValue(Button.BackgroundProperty);
                D4Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void D5Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(D5Button.Background == Brushes.Black))
            {
                D5Button.Background = Brushes.Black;
                D5Button.Foreground = Brushes.Black;

            }
            else
            {
                D5Button.ClearValue(Button.BackgroundProperty);
                D5Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void D6Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(D6Button.Background == Brushes.Black))
            {
                D6Button.Background = Brushes.Black;
                D6Button.Foreground = Brushes.Black;

            }
            else
            {
                D6Button.ClearValue(Button.BackgroundProperty);
                D6Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void D7Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(D7Button.Background == Brushes.Black))
            {
                D7Button.Background = Brushes.Black;
                D7Button.Foreground = Brushes.Black;

            }
            else
            {
                D7Button.ClearValue(Button.BackgroundProperty);
                D7Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void D8Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(D8Button.Background == Brushes.Black))
            {
                D8Button.Background = Brushes.Black;
                D8Button.Foreground = Brushes.Black;

            }
            else
            {
                D8Button.ClearValue(Button.BackgroundProperty);
                D8Button.ClearValue(Button.ForegroundProperty);
            }
        }

        private void E1Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(E1Button.Background == Brushes.Black))
            {
                E1Button.Background = Brushes.Black;
                E1Button.Foreground = Brushes.Black;

            }
            else
            {
                E1Button.ClearValue(Button.BackgroundProperty);
                E1Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void E2Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(E2Button.Background == Brushes.Black))
            {
                E2Button.Background = Brushes.Black;
                E2Button.Foreground = Brushes.Black;

            }
            else
            {
                E2Button.ClearValue(Button.BackgroundProperty);
                E2Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void E3Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(E3Button.Background == Brushes.Black))
            {
                E3Button.Background = Brushes.Black;
                E3Button.Foreground = Brushes.Black;

            }
            else
            {
                E3Button.ClearValue(Button.BackgroundProperty);
                E3Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void E4Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(E4Button.Background == Brushes.Black))
            {
                E4Button.Background = Brushes.Black;
                E4Button.Foreground = Brushes.Black;

            }
            else
            {
                E4Button.ClearValue(Button.BackgroundProperty);
                E4Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void E5Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(E5Button.Background == Brushes.Black))
            {
                E5Button.Background = Brushes.Black;
                E5Button.Foreground = Brushes.Black;

            }
            else
            {
                E5Button.ClearValue(Button.BackgroundProperty);
                E5Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void E6Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(E6Button.Background == Brushes.Black))
            {
                E6Button.Background = Brushes.Black;
                E6Button.Foreground = Brushes.Black;

            }
            else
            {
                E6Button.ClearValue(Button.BackgroundProperty);
                E6Button.ClearValue(Button.ForegroundProperty);
            }
        }
        private void E7Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(E7Button.Background == Brushes.Black))
            {
                E7Button.Background = Brushes.Black;
                E7Button.Foreground = Brushes.Black;

            }
            else
            {
                E7Button.ClearValue(Button.BackgroundProperty);
                E7Button.ClearValue(Button.ForegroundProperty);
            }
        }

        private void E8Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(E8Button.Background == Brushes.Black))
            {
                E8Button.Background = Brushes.Black;
                E8Button.Foreground = Brushes.Black;

            }
            else
            {
                E8Button.ClearValue(Button.BackgroundProperty);
                E8Button.ClearValue(Button.ForegroundProperty);
            }
        }
    }
}
