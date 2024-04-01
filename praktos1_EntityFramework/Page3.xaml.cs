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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {

        private practos1Entities context = new practos1Entities();
        public Page3()
        {
            InitializeComponent();
            datasetik.ItemsSource = context.Orders.ToList();
            combo_datasetic.ItemsSource = context.Orders.ToList();
            combo_datasetic.DisplayMemberPath = "TotalAmount";
        }

        private void combo_datasetic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = combo_datasetic.SelectedItem as Orders;
            MessageBox.Show(selected.OrderDate.ToString());
        }

        private void Button_add(object sender, RoutedEventArgs e)
        {
            Orders c = new Orders();
            c.OrderID = Convert.ToInt32(Nametbx.Text);
            c.UserID = Convert.ToInt32(Nametbx2.Text);
            c.OrderDate = Convert.ToDateTime(Nametbx3.Text);
            c.TotalAmount = Convert.ToInt32(Nametbx4.Text);

            context.Orders.Add(c);
            context.SaveChanges();
            datasetik.ItemsSource = context.Orders.ToList();
        }

        private void Button_delete(object sender, RoutedEventArgs e)
        {
            if (datasetik.SelectedItem != null)
            {
                context.Orders.Remove(datasetik.SelectedItem as Orders);
                context.SaveChanges();
                datasetik.ItemsSource = context.Orders.ToList();
            }
        }

        private void Button_change(object sender, RoutedEventArgs e)
        {
            if (datasetik.SelectedItem != null)
            {
                var selected = datasetik.SelectedItem as Orders;
                selected.OrderID = Convert.ToInt32(Nametbx.Text);
                selected.UserID = Convert.ToInt32(Nametbx2.Text);
                selected.OrderDate = Convert.ToDateTime(Nametbx3.Text);
                selected.TotalAmount = Convert.ToInt32(Nametbx4.Text);
                context.SaveChanges();
                datasetik.SelectedItem = context.Addresses.ToList();
                datasetik.ItemsSource = context.Addresses.ToList();
            }
        }

        private void datasetik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datasetik.SelectedItem != null)
            {
                var selected = datasetik.SelectedItem as Orders;
                Nametbx.Text = selected.OrderID.ToString();
                Nametbx2.Text = selected.UserID.ToString();
                Nametbx3.Text = selected.OrderDate.ToString();
                Nametbx4.Text = selected.TotalAmount.ToString();

            }
        }

        
    }
}
