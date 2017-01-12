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
using System.ComponentModel;


namespace Conway
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int GridSize = 20;
        private System.Timers.Timer timer = new System.Timers.Timer(200);

        private int[,] n = new int[GridSize,GridSize];
        private Cell[,] cells = new Cell[GridSize, GridSize];

        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            for (int i = 0; i < GridSize; i++)
            {
                grid1.ColumnDefinitions.Add(
                    new ColumnDefinition());
                grid1.RowDefinitions.Add(
                    new RowDefinition());
            }

            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    cells[i, j] = new Cell { state = false };
                    Rectangle rect = new Rectangle();

                    Grid.SetColumn(rect,j);
                    Grid.SetRow(rect,i);
                    rect.Fill = Brushes.White;

                    rect.DataContext = cells[i,j];
                    rect.SetBinding(OpacityProperty,"state");

                    grid1.Children.Add(rect);
                }
            }
            setupTimer();
        }

        private void grid1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.OriginalSource is Rectangle)
            {
                Rectangle temp = ((Rectangle)e.OriginalSource);
                Cell C = (Cell)temp.DataContext;
                C.state = !C.state;
            }
        }

        private void setupTimer()
        {
            timer.Elapsed += (sender2, e2) =>
            {
                counter();
                nextgen();
            };
        }

        private void nextgen()
        {
             for (int i = 1; i < GridSize - 1; i++)
 {
  for (int j = 1; j < GridSize - 1; j++)
  {
   if(n[i, j]==3) cells[i, j].state = true;
   if (n[i, j]>=4) cells[i, j].state = false;
   if (n[i, j] <= 1) cells[i, j].state =false;
  }
 }
        }

        private void counter()
        {
            for (int i = 1; i < GridSize-1; i++)
            {
                for (int j = 1; j < GridSize-1; j++)
                {
                    n[i, j] = cells[i - 1, j] +
                              cells[i + 1, j] +
                              cells[i, j - 1] +
                              cells[i, j + 1];

                   n[i, j] += cells[i - 1, j - 1] +
                              cells[i + 1, j - 1] +
                              cells[i + 1, j + 1] +
                              cells[i - 1, j + 1];
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Button1.Content.ToString() == "Run")
            {
                Button1.Content = "Stop";
                timer.Start();
            }  else
            {
                Button1.Content = "Run";
                timer.Stop();
            }
        }
    }
}
