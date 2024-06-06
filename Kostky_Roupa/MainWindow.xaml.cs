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
using System.Windows.Threading;

namespace Kostky_Roupa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private kostky kostka = new kostka(6);
        private hra Hra;
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void vykreslitkostku(int x, int y, int vzdalenost, int hodnota)
        {
            Rectangle obryskostky = new Rectangle
            {
                Width = vzdalenost,
                Height = vzdalenost,
                Fill = Brushes.DeepSkyBlue,
                StrokeThickness = 2
            };

        }
        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
          //  Hra = new hra();
          //  timer = new DispatcherTimer();
          //  timer.Interval = TimeSpan.FromMilliseconds(30);
          //  timer.Tick += Timer_Tick;
           // timer.Start();
      //  }
       // private void Timer_Tick(object? sender, EventArgs e)
        //{
            //platno.Children.Clear();
            //Hra.Draw(platno);
        //}

       // private void btnhod_Click(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
