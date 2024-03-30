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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {

        private practos1Entities context = new practos1Entities();
        public Page2()
        {
            InitializeComponent();
            datasetik.ItemsSource = context.Addresses.ToList();
            combo_datasetic.ItemsSource = context.Addresses.ToList();
            combo_datasetic.DisplayMemberPath = "City";
        }

        private void combo_datasetic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = combo_datasetic.SelectedItem as Addresses;
            MessageBox.Show(selected.PostalCode.ToString());
        }
    }
}
