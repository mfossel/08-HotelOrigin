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
    /// Interaction logic for RoomWindow.xaml
    /// </summary>
    public partial class RoomWindow : Window
    {
        public RoomWindow()
        {
            InitializeComponent();

            RoomGrid.ItemsSource = RoomRepository.GetAll();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (RoomGrid.SelectedIndex > -1)
            {
                try
                {
                    RoomRepository.rooms.RemoveAt(RoomGrid.SelectedIndex);
                }
                catch
                { }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RoomInput Win = new RoomInput();
            Win.Show();
        }

    }
}
