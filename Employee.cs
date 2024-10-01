using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_hotel
{
    public class Employee : Manager
    {
        List<Employee> EmployeeList = new List<Employee>();
        public string JobTitle { get; set; }

        public Employee(string name, int age, int idnumber, (int year, int month, int day) startDate, double salary, string department, string jobtitle) : base(name, age, idnumber, startDate, salary, department)
        {
            JobTitle = jobtitle;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"The employee´s name is {Name}.\nThe person's age is {Age}.\nThe ID-Number is {IdNumber}.\nThe person started the {StartDate.ToShortDateString()} and the salary is {Salary}.\n The employee jobtitel is {JobTitle} and their working department is {Department}.");
        }
        public virtual void Work()
        {
            Console.WriteLine($"This employee is currently working. ");
        }

    }

}
