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

        private void Button_add(object sender, RoutedEventArgs e)
        {
            Users c = new Users();
            c.UserName = Nametbx2.Text;
            c.Email = Nametbx3.Text;
            c.UserID = Convert.ToInt32(Nametbx.Text);

            context.Users.Add(c);
            context.SaveChanges();
            datasetik.ItemsSource = context.Users.ToList() ;    
        }

        private void button_delete(object sender, RoutedEventArgs e)
        {
            if (datasetik.SelectedItem != null)
            {
                context.Users.Remove(datasetik.SelectedItem as  Users);
                context.SaveChanges();
                datasetik.ItemsSource = context.Users.ToList();
            }
        }

        private void Button_change(object sender, RoutedEventArgs e)
        {
            if (datasetik.SelectedItem != null)
            {
                var selected = datasetik.SelectedItem as Users;
                selected.Email = Nametbx3.Text;
                selected.UserName = Nametbx2.Text;
                selected.UserID = Convert.ToInt32(Nametbx.Text);
                context.SaveChanges();
                datasetik.SelectedItem = context.Users.ToList();
                datasetik.ItemsSource = context.Users.ToList();
            }
        }

        private void datasetik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datasetik.SelectedItem != null)
            {
                var selected = datasetik.SelectedItem as Users;
                Nametbx.Text = selected.UserID.ToString();
                Nametbx2.Text = selected.UserName.ToString();
                Nametbx3.Text = selected.Email.ToString();
            }
        }
    }
}
