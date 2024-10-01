using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace oop_hotel
{
    public class Hotel
    {
        private List<HotelBookning> _hotelBookings = new();

        //public void AddBooking(HotelBookning hotelBookning)
        //{

        //    _hotelBookings.Add(hotelBookning);
        //}
        public void ShowAllBooking()
        {
            foreach (var i in _hotelBookings)
            {
                Console.WriteLine(i.ToString());
               
            }
            Console.ReadLine();
        }
        public void CreateBooking()
        {
            HotelBookning hotelBookning = new HotelBookning();

            _hotelBookings.Add(hotelBookning);
        }

      
    }
}
