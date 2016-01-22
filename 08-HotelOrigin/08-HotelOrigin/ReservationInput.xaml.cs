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
using HotelOrigin.Core.Domain;

namespace _08_HotelOrigin
{
    /// <summary>
    /// Interaction logic for ReservationInput.xaml
    /// </summary>
    public partial class ReservationInput : Window
    {
        public ReservationInput()
        {
            InitializeComponent();


            var cust = CustomerRepository.GetAll();

            try
            {
                for (int i = 0; i < cust.Count; i++)
                {
                    CustomerCombo.Items.Add(cust[i].LastName);
                }
            }
            catch { }
            
            var room = RoomRepository.GetAll();

            try
            {
                for (int i = 0; i < cust.Count; i++)
                {
                    RoomCombo.Items.Add(room[i].RoomNumber);
                }
            }
            catch { }
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddResButton_Click(object sender, RoutedEventArgs e)
        {
            try
           {
                int id = int.Parse(IdBox.Text.ToString());
                DateTime CheckIn = CheckInCal.DisplayDate;
                DateTime CheckOut = CheckOutCal.DisplayDate;
                int room = (int)RoomCombo.SelectedItem;
                string customer = (string)CustomerCombo.SelectedItem;
                ReservationRepository.Create(id, CheckIn, CheckOut, customer, room);

                IdBox.Clear();
                CheckInCal.SelectedDate = DateTime.Today;
                CheckOutCal.SelectedDate = DateTime.Today;
                RoomCombo.SelectedItem = null;
                CustomerCombo.SelectedItem = null;

            }
            catch { }
        }
    }
}
