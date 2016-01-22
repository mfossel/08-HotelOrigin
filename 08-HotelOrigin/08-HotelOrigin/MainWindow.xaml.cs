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
using HotelOrigin.Core;
using HotelOrigin.Core.Repository;


namespace _08_HotelOrigin
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

        private void CustomerButton_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new CustomerWindow();
            newWindow.Show();
        }

        private void ReservationButton_Click(object sender, RoutedEventArgs e)
        {
            var newWindow2 = new ReservationWindow();
            newWindow2.Show();
        }

        private void RoomButton_Click(object sender, RoutedEventArgs e)
        {
            var newWindow3 = new RoomWindow();
            newWindow3.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            CustomerRepository.Save();
            RoomRepository.Save();
        }
    }
}
