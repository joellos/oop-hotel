using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_hotel
{
    public class EmployeesManager
    {

        List<Manager> KitchenStaffManagers = new List<Manager>();
        List<Manager> CleaningStaffManagers = new List<Manager>();
        List<Employee> CleaningStaffEmployees = new List<Employee>();
        List<Employee> KitchenStaffEmployees = new List<Employee>();

        Manager manager1 = new Manager("Lisa Ledarsson", 40, 1, (2022, 03, 15), 40000.00, "Kitchen");
        Manager manager3 = new Manager("Abdi Ledarsson", 35, 2, (2022, 03, 15), 40000.00, "Cleaning Firm");
        Manager manager2 = new Manager("Alfons Åberg", 45, 2, (2020, 03, 15), 40000.00, "Cleaning Firm");
        Employee employee1 = new Employee("Abdul Abdulsson", 40, 1, (2022, 03, 15), 5000.00, "Kitchen", "Cook");
        Employee employee2 = new Employee("Abdul Abdulsson", 40, 1, (2022, 03, 15), 5000.00, "Cleaning Firm", "Cleaner");

        public void ShowMenuStaff()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("[1] Print all Kitchen Managers");
                Console.WriteLine("[2] Print all Cleaning Managers");
                Console.WriteLine("[3] Print all Kitchen Staff");
                Console.WriteLine("[4] Print all Cleaning Staff");
                Console.WriteLine("[5] Print Consult list");
                Console.WriteLine("[6] Go back to booking menu");
                Console.WriteLine("[7] Close the program");
                int choice;

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {

                        case 1:
                            AddToLIst();
                            PrintKitchenStaffManager();
                            Console.ReadKey();
                            break;

                        case 2:
                            AddToLIst();
                            PrintCleaningStaffManagers();
                            Console.ReadKey();
                            break;
                        case 3:
                            AddToLIst();
                            PrintKitchenStaffEmployees();
                            Console.ReadKey();
                            break;
                        case 4:
                            AddToLIst();
                            PrintCleaningStaffEmployees();
                            Console.ReadKey();
                            break;
                        case 5:
                            Consultant consult1 = new Consultant("Ivan Olsson", 25, 1, (2022, 08, 15), 0, 500, "AdviceMaster", "Kitchen developping");

                            consult1.DisplayInfo();
                            consult1.GiveAdvice();
                            Console.ReadKey();
                            break;
                        case 6:
                            Menu menu = new Menu();
                            menu.ShowMenu();
                            break;
                            case 7:
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

        public void AddToLIst()
        {
            KitchenStaffManagers.Add(manager1);
            CleaningStaffManagers.Add(manager2);
            CleaningStaffManagers.Add(manager3);
            KitchenStaffEmployees.Add(employee1);
            CleaningStaffEmployees.Add(employee2);

        }


        public bool PrintKitchenStaffManager()
        {
            if (KitchenStaffManagers.Count > 0)
            {
                foreach (Manager i in KitchenStaffManagers)
                {
                    Console.WriteLine();
                    i.DisplayInfo();
                    i.HoldMeeting();

                }
                return true;
            }
            else
            {
                Console.WriteLine("Du har inga anställda.");
                return false;
            }
        }
        public bool PrintKitchenStaffEmployees()
        {
            if (KitchenStaffEmployees.Count > 0)
            {
                foreach (Employee i in KitchenStaffEmployees)
                {
                    Console.WriteLine();
                    i.DisplayInfo();
                    i.Work();



                }
                return true;
            }
            else
            {
                Console.WriteLine("Du har inga anställda.");
                return false;
            }
        }
        public bool PrintCleaningStaffEmployees()
        {
            if (KitchenStaffManagers.Count > 0)
            {
                foreach (Employee i in CleaningStaffEmployees)
                {
                    Console.WriteLine();
                    i.DisplayInfo();

                }
                return true;
            }
            else
            {
                Console.WriteLine("Du har inga anställda.");
                return false;
            }
        }
        public bool PrintCleaningStaffManagers()
        {
            if (KitchenStaffManagers.Count > 0)
            {
                foreach (Manager i in CleaningStaffManagers)
                {
                    Console.WriteLine();
                    i.DisplayInfo();

                }
                return true;
            }
            else
            {
                Console.WriteLine("Du har inga anställda.");
                return false;
            }
        }


    }
}
