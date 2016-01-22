using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using HotelOrigin.Core;
using HotelOrigin.Core.Repository;
using System.IO;

namespace _08_HotelOrigin
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            if (File.Exists("customers.json"))
            {
                CustomerRepository.Load();
            }
            if (File.Exists("rooms.json"))
            {
                RoomRepository.Load();
            }
        }

    }
}
