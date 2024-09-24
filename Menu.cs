using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_hotel
{
    public class Menu
    {
        Hotel hotel = new Hotel();


        public void ShowMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("[1] Lägg till en bokning");
                Console.WriteLine("[2] Visa alla bokningar");
                Console.WriteLine("[3] Avsluta programmet");
                int choice;

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {

                        case 1:

                            hotel.CreateBooking();
                            break;

                        case 2:

                            hotel.ShowAllBooking();
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Ogiltigt val");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ogilitigt inmatinning");

                    Console.ReadKey();
                }

                //int choice;
                //do
                //{

                //    Console.WriteLine("[1] Lägg till en bokning");
                //    Console.WriteLine("[2] Visa alla bokningar");
                //    Console.WriteLine("[3] Avsluta programmet");

                //    if (int.TryParse(Console.ReadLine(), out choice))
                //    {
                //        switch (choice)
                //        {

                //            case 1:

                //                hotel.CreateBooking();
                //                break;

                //            case 2:

                //                hotel.ShowAllBooking();
                //                break;
                //            case 3:
                //                Environment.Exit(0);
                //                break;
                //            default:
                //                Console.WriteLine("Ogiltigt val");
                //                break;
                //        }
                //    }
                //    else
                //    {
                //        Console.WriteLine("Ogilitigt inmatinning");
                //    }



                //} while (choice > 0);
            }


        }
    }
}
