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
        EmployeesManager employees = new EmployeesManager();

        public void ShowMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("[1] Book");
                Console.WriteLine("[2] Show bookings");
                Console.WriteLine("[3] Show the list of the staff");
                Console.WriteLine("[4] Close programm");
                
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
                            employees.ShowMenuStaff();
                            break;
                        case 4:
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


            }


        }
    }
}
