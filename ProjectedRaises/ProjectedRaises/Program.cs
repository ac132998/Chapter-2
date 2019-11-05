using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectedRaises
{
    class Program
    {
        static void Main(string[] args)
        {
            const double RAISE = 0.04;
            double emploSalary1 = 1000;
            double emploSalary2 = 2500;
            double emploSalary3 = 1500;
            double raiseSalEmply1;
            double raiseSalEmply2;
            double raiseSalEmply3;

            raiseSalEmply1 = emploSalary1 * RAISE;
            raiseSalEmply2 = emploSalary2 * RAISE;
            raiseSalEmply3 = emploSalary3 * RAISE;

            Console.WriteLine("The salary of employee one is {0} " + 
                "with the raise of {1}, employee one's raise is {2}" , emploSalary1, RAISE, raiseSalEmply1);
            Console.WriteLine("The salary of employee two is {0} " +
                "with the raise of {1}, employee two's raise is {2}", emploSalary2, RAISE, raiseSalEmply2);
            Console.WriteLine("The salary of employee three is {0} " +
                "with the raise of {1}, employee three's raise is {2}", emploSalary3, RAISE, raiseSalEmply3);

            displayInterActiveRaises();

        }
        public static void displayInterActiveRaises()
        {
            const double RAISE = 0.04;
            double emploSalary1;
            double emploSalary2;
            double emploSalary3;
            double raiseSalEmply1;
            double raiseSalEmply2;
            double raiseSalEmply3;
            string employSal1Entry;
            string employSal2Entry;
            string employSal3Entry; 

            Console.WriteLine("Enter employee one salary >>> ");
            employSal1Entry = Console.ReadLine();
            emploSalary1 = Convert.ToDouble(employSal1Entry); 
            
            
            raiseSalEmply1 = emploSalary1 * RAISE;
            raiseSalEmply2 = emploSalary2 * RAISE;
            raiseSalEmply3 = emploSalary3 * RAISE;

            Console.WriteLine("The salary of employee one is {0} " +
                "with the raise of {1}, employee one's raise is {2}", emploSalary1, RAISE, raiseSalEmply1);
            Console.WriteLine("The salary of employee two is {0} " +
                "with the raise of {1}, employee two's raise is {2}", emploSalary2, RAISE, raiseSalEmply2);
            Console.WriteLine("The salary of employee three is {0} " +
                "with the raise of {1}, employee three's raise is {2}", emploSalary3, RAISE, raiseSalEmply3);

        }
    }
}
