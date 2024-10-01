using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_hotel
{
    public class HotelBookning
    {

        public string Name {  get; set; }

        public DateTime StartTime {  get; set; }

        public DateTime EndTime { get; set; }

        public HotelBookning()
        {
           this.Name = SetName();
            this.StartTime = SetDate(true);
           this.EndTime = SetDate(false);

        }
        public string SetName()
        {
            Console.WriteLine("Enter namen: ");
            return Console.ReadLine();
        }
        public DateTime SetDate(bool isStart)
        {
            string date = " ";
            if (isStart)
            {
                Console.WriteLine("Skriv datumet du vill checka in");
                 date = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Skriv datumet du vill checka ut");
                 date = Console.ReadLine();
            }

            DateTime parsedDate;
            bool success = DateTime.TryParseExact(date, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out parsedDate);
            if (success)
            {
                return parsedDate;
            }
            else
            {
                Console.WriteLine("Fel datumformat");
            }
            return parsedDate;

        }
        public override string ToString()
        {
            return $"Name: {Name}, Start: {StartTime.ToShortDateString()}, end: {EndTime.ToShortDateString()} ";
        }


    }
    
}
