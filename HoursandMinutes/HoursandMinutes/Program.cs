using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursandMinutes
{
    class Program
    {
        static void Main(string[] args)
        {

            int minutes = 197; 
            const int MIN_TO_HRS = 60;
            int totalHours;
            double totalMinutes;

            totalHours = minutes / MIN_TO_HRS;
            totalMinutes = minutes % MIN_TO_HRS;
            Console.WriteLine("The total is {0} hours and {1} minutes.", totalHours, totalMinutes);


        }
    }
}
