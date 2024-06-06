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
        private kostky[] kostka = new kostky[6];
        private hra Hra;
        private DispatcherTimer timer;

        public MainWindow()
        {
            for(int i = 0; i < kostka.Length; i++)
            {
                kostka[i] = new kostky();
            }
            vykreslitkostky();
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
        private void vykreslitkostky()
        {
            platno.Children.Clear();
            int vzdalenost = 100;
            for(int i = 0; i < 20; i++)
            {
                vykreslitkostku(i * (vzdalenost + 10), 10, vzdalenost, kostky[i]);
            }
        }
        private async Task animacehodu()
        {
            for (int i = 0; i < 20; i++)
            {
                foreach(var kostky in kostka)
                {
                    
                }
            }
        }
        private async void btnhod_Click(object sender, RoutedEventArgs e)
        {
            await animacehodu();
            vykreslitkostky();
        }
    }
}
