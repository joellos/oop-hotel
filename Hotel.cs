using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_hotel
{
    internal class Hotel
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
        }
        public void CreateBooking()
        {
            HotelBookning hotelBookning = new HotelBookning();

            _hotelBookings.Add(hotelBookning);
        }
        //public void ContinueBooking()
        //{
        //    bool continueBooking = true;

        //   while (continueBooking)
        //    {
        //        Console.WriteLine();
        //        string response = Console.ReadLine();
        //        AddBooking(new HotelBookning());

        //        if (response == "ja")
        //        {
        //            continueBooking = true;
        //        }
        //        else if ( response == "nej")
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Skriv ja eller nej");
        //        }
        //    }
        //}
    }
}
