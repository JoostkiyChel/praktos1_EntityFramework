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

namespace praktos1_EntityFramework
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Page_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Page1();
        }

        private void Page2_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Page2();
        }

        private void Page3_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Page3();
        }
    }
}
