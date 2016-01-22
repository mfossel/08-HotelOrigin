using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelOrigin.Core.Domain;
using System.Collections.ObjectModel;

namespace HotelOrigin.Core.Repository
{
    public class ReservationRepository
    {
        public static ObservableCollection<Reservation> reservations = new ObservableCollection<Reservation>();

        //Create
        public static Reservation Create(int id, DateTime checkin, DateTime checkout, string customer, int room)
        {
            Reservation reservation = new Reservation();
            reservation.id = id;
            reservation.CheckInDate = checkin;
            reservation.CheckOutDate = checkout;
            reservation.customer = customer;
            reservation.room = room;



            reservations.Add(reservation);
            return reservation;

        }

        //Read      
        public static Reservation GetById(int id)
        {
            return reservations.FirstOrDefault(c => c.id == id);


        }

        public static ObservableCollection<Reservation> GetAll()
        {
            return reservations;
        }
    



        //Delete
        public static void Delete(int id)
        {
            var reservation = GetById(id);
            reservations.Remove(reservation);
        }


        }
    }

