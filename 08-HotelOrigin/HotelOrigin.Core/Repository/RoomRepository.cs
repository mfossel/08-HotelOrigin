using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelOrigin.Core.Domain;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.IO;

namespace HotelOrigin.Core.Repository
{
    public class RoomRepository
    {
        public static ObservableCollection<Room> rooms = new ObservableCollection<Room>();

        //Create Method
        public static Room Create(int number, int bed, bool tv)
        {
            Room room = new Room();
            room.RoomNumber = number;
            room.NumberOfBeds = bed;
            room.HasTv = tv;

            rooms.Add(room);

            return room;

        }

        //Read Methods
        public static Room GetByRoomNumber(int RoomNumber)
        {
            return rooms.FirstOrDefault(c => c.RoomNumber == RoomNumber);


        }

        public static ObservableCollection<Room> GetAll()
        {
            return rooms;
        }

        //Delete Method
        public static void Delete(int RoomNumber)
        {
            var room = GetByRoomNumber(RoomNumber);
            rooms.Remove(room);
        }

        //Save Data
        public static void Save()
        {
            string json = JsonConvert.SerializeObject(rooms);
            File.WriteAllText("rooms.json", json);
        }

        //Load Data
        public static void Load()
        {
            string json = File.ReadAllText("rooms.json");

            rooms = JsonConvert.DeserializeObject<ObservableCollection<Room>>(json);
        }

    }
}
