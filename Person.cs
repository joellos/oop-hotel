using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_hotel
{
     public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int IdNumber { get; set; }
        public DateTime StartDate { get; set; }
        public double Salary { get; set; }

        public Person(string name, int age, int idnumber,(int year, int month, int day)startDate, double salary)
        {
            Age = age;
            Name = name;
            IdNumber = idnumber;
            Salary = salary;
            StartDate = new DateTime(startDate.year, startDate.month, startDate.day);

        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"The person name is {Name}. The person's age is {Age}. The ID-Number is {IdNumber}. The person started the job {StartDate.ToShortDateString} and the salary is {Salary}. ");
        }

    }

}
