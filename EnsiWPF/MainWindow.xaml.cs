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

namespace EnsiWPF
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

        private void Yhdista(object sender, RoutedEventArgs e)
        {
           string Kokeilu = "";
            Hei.Content = $"Ekassa tekstilaatikossa oli {Eka.Text+Kokeilu} ja toisessa tekstilaatikossa oli {Toka.Text+Kokeilu}";
        }
    }
}
