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
    /// Interaction logic for RoomInput.xaml
    /// </summary>
    public partial class RoomInput : Window
    {
        public RoomInput()
        {
            InitializeComponent();
        }

        private void CancelRoomButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddRoomButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                int room = int.Parse(RoomNumberBox.Text.ToString());
                int bed = int.Parse(BedBox.Text.ToString());
                bool tv = false;
                if (HasTvCheck.IsChecked == true)
                {
                    tv = true;
                }
                RoomRepository.Create(room, bed, tv);
            }
            catch { }

           
            
        }
    }
}
