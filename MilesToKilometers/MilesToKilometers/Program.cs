using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            const double KILO_TO_MILE = 1.6; 
            double mileEntry = 5;
            double kilo;

            kilo = KILO_TO_MILE * mileEntry;
            
            Console.WriteLine("The miles entered was {0}, "+ 
                "and that equals {1} kilometers.", mileEntry, kilo);

            displayInterActiveConversion(); 
            
        }
        public static void displayInterActiveConversion()
        {
            const double KILO_TO_MILE = 1.6;
            double milesEntry;
            double kilo;
            string milesEntryString; 

            Console.WriteLine("Please enter the number of miles now!!! >>>>> ");
            milesEntryString = Console.ReadLine();
            milesEntry = Convert.ToDouble(milesEntryString);
            kilo = KILO_TO_MILE * milesEntry;

            Console.WriteLine("The miles entered was {0}, " +
                "and that equals {1} kilometers.", milesEntry, kilo);


        }
    }
}
