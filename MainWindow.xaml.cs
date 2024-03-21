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

namespace ZOOBD
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void EFButton_Click(object sender, RoutedEventArgs e)
        {
            EFZOO productsWindow = new EFZOO(); productsWindow.ShowDialog();
        }
        private void DSButton_Click(object sender, RoutedEventArgs e)
        {
            DSZOO categoriesWindow = new DSZOO(); categoriesWindow.ShowDialog();
        }
    }
}
