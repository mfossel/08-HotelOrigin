using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrigin.Core.Domain
{
    public class Reservation
    {
        public int id { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public String customer { get; set; }
        public int room { get; set; }
    }
}
