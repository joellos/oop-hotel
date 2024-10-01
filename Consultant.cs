using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_hotel
{
    public class Consultant : Person
    {
        public double HourlyRate { get; set; }
        public string ConsultingFirm { get; set; }
        public string Expertise { get; set; }

        public Consultant(string name, int age, int idnumber, (int year, int month, int day) startDate, double salary, double hourlyRate, string consultingFirm, string expertise) : base(name, age, idnumber, startDate, salary)
        {
            HourlyRate = hourlyRate;
            ConsultingFirm = consultingFirm;
            Expertise = expertise;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"The consultant´s name is {Name}.\nThe person's age is {Age}.\nThe ID-Number is {IdNumber}.\nThe person started the {StartDate.ToShortDateString()}.\nThe consultant is from the firm {ConsultingFirm} and has the salary of {HourlyRate} sek per hour ");
        }
        public void GiveAdvice()
        {
            Console.WriteLine($"His advice is to get a life. My expertise is {Expertise}.");
        }
    }
}
        
    

