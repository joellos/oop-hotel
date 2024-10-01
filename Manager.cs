using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_hotel
{
    public class Manager : Person
    {
        public string Department { get; set; }

        public Manager(string name, int age, int idnumber, (int year, int month, int day)startDate, double salary, string department) : base (name, age, idnumber, startDate, salary)
        {
            Department = department;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"The manager´s name is {Name}.\nThe person's age is {Age}.\nThe ID-Number is {IdNumber}.\nThe person started the {StartDate.ToShortDateString()} and the salary is {Salary}.\nThe manager is responsible for the {Department} department.");
        }
        public void HoldMeeting()
        {
            Console.WriteLine("I am calling all employees to a meeting!");
        }

        public void PlanBudget()
        {
            Console.WriteLine("This manager keeps track of the hotell budget.");
        }

    }
}
