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
using System.Collections.ObjectModel;


namespace _08_HotelOrigin
{
    /// <summary>
    /// Interaction logic for ReservationWindow.xaml
    /// </summary>
    public partial class ReservationWindow : Window
    {
        public ReservationWindow()
        {
            InitializeComponent();
            ReservationGrid.ItemsSource = ReservationRepository.GetAll();
            


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReservationInput win = new ReservationInput();
            win.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ReservationGrid.SelectedIndex > -1)
            {
                try
                {
                    ReservationRepository.reservations.RemoveAt(ReservationGrid.SelectedIndex);                    
                }
                catch (Exception)
                { }
            }
        }

    }
}
