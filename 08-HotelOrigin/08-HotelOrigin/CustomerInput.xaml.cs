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
using HotelOrigin.Core.Repository;

namespace _08_HotelOrigin
{
    /// <summary>
    /// Interaction logic for CustomerInput.xaml
    /// </summary>
    public partial class CustomerInput : Window
    {
        public CustomerInput()
        {
            InitializeComponent();
        }

        private void CustomerAddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int idInt = int.Parse(IdTextBox.Text.ToString());

                CustomerRepository.Create(idInt, FirstNameBox.Text, LastNameBox.Text, EmailBox.Text, PhoneNumberBox.Text);
                FirstNameBox.Clear();
                IdTextBox.Clear();
                LastNameBox.Clear();
                EmailBox.Clear();
                PhoneNumberBox.Clear();
              

            }
            catch { }

         
        }

        private void CustomerCancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
