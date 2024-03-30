using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private practos1Entities context = new practos1Entities();
        public Page1()
        {
            InitializeComponent();
            datasetik.ItemsSource = context.Users.ToList();
            combo_datasetic.ItemsSource = context.Users.ToList();
            combo_datasetic.DisplayMemberPath = "UserName";
        }

        private void combo_datasetic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = combo_datasetic.SelectedItem as Users;
            MessageBox.Show(selected.UserID.ToString());
        }
    }
}
