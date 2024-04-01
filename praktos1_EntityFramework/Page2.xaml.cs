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

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            Addresses c = new Addresses();

            c.AddressID = Convert.ToInt32(Nametbx.Text);
            c.UserID = Convert.ToInt32(Nametbx2.Text);
            c.AddressLine = Nametbx3.Text;
            c.City = Nametbx4.Text;
            c.PostalCode = Nametbx5.Text;

            context.Addresses.Add(c);
            context.SaveChanges();
            datasetik.ItemsSource = context.Addresses.ToList();

        }

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            if (datasetik.SelectedItem != null)
            {
                context.Addresses.Remove(datasetik.SelectedItem as Addresses);
                context.SaveChanges();
                datasetik.ItemsSource = context.Addresses.ToList();
            }
        }

        private void Button_Change(object sender, RoutedEventArgs e)
        {
            if (datasetik.SelectedItem != null)
            {
                var selected = datasetik.SelectedItem as Addresses;
                selected.AddressLine = Nametbx3.Text;
                selected.UserID = Convert.ToInt32(Nametbx2.Text);
                selected.AddressID = Convert.ToInt32(Nametbx.Text);
                selected.City = Nametbx4.Text;
                selected.PostalCode = Nametbx5.Text;
                context.SaveChanges();
                datasetik.SelectedItem = context.Addresses.ToList();
                datasetik.ItemsSource = context.Addresses.ToList();
            }
        }

        private void datasetik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datasetik.SelectedItem != null)
            {
                var selected = datasetik.SelectedItem as Addresses;
                Nametbx.Text = selected.AddressID.ToString();
                Nametbx2.Text = selected.UserID.ToString();
                Nametbx3.Text = selected.AddressLine.ToString();
                Nametbx4.Text = selected.City.ToString();
                Nametbx5.Text = selected.PostalCode.ToString();
            }
        }
    }
}
