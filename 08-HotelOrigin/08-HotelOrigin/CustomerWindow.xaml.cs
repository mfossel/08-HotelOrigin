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
using System.Windows.Shapes;
using HotelOrigin.Core.Domain;
using HotelOrigin.Core.Repository;
using System.Collections.ObjectModel;

namespace _08_HotelOrigin
{
    /// <summary>
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        public CustomerWindow()
        {
            InitializeComponent();

            CustomerGrid.ItemsSource = CustomerRepository.GetAll();
            CustomerGrid.ScrollIntoView(CustomerRepository.customers[CustomerRepository.customers.Count - 1]);

        }



       


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newWindow4 = new CustomerInput();
            newWindow4.Show();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (CustomerGrid.SelectedIndex > -1)
            {
                try
                {
                    CustomerRepository.customers.RemoveAt(CustomerGrid.SelectedIndex);
                }
                catch (Exception)
                { }
            }
        }
    }      
}
