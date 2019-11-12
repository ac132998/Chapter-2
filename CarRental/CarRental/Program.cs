using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {

            const double CAR_RENTAL_MILE = 0.25;
            const double CAR_RENTAL_DAY = 20;
            double carRentalTotal; 
            double miles; 
            double day;
            string dayEntry;
            string milesEntry; 

            Console.WriteLine("Enter the amount of miles traveled >> ");
            milesEntry = Console.ReadLine();
            miles = Convert.ToDouble(milesEntry);

            Console.WriteLine("Enter the amount of days traveled >> ");
            dayEntry = Console.ReadLine();
            day = Convert.ToDouble(dayEntry);

            carRentalTotal = CAR_RENTAL_DAY + CAR_RENTAL_MILE * miles;

            Console.WriteLine("The total cost of your car rental with {0} miles and {1} days, " + 
                "with the rate of $20 a day and 0.25 per mile equals {2}", miles, day, carRentalTotal);



        }
    }
}
