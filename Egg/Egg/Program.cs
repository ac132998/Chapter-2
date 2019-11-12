using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egg
{
    class Program
    {
        static void Main(string[] args)
        {
            const int EGG_TO_DOZEN = 12;
            int chickenEgg1 = 40;
            int chickenEgg2 = 50;
            int chickenEgg3 = 25;
            int chickenEgg4 = 30;
            int totaleggs;
            double totalremegg1;
            double totalegg;
           
            totaleggs = chickenEgg1 + chickenEgg2 + chickenEgg3 + chickenEgg4;
            totalremegg1 = totaleggs / EGG_TO_DOZEN;
            totalegg = totaleggs % EGG_TO_DOZEN;

            Console.WriteLine("Chicken 1 laid {0} eggs.", chickenEgg1);
            Console.WriteLine("Chicken 2 laid {0} eggs.", chickenEgg2);
            Console.WriteLine("Chicken 3 laid {0} eggs.", chickenEgg3);
            Console.WriteLine("Chicken 4 laid {0} eggs.", chickenEgg4);
            Console.WriteLine("All together there is {0} eggs is {1} dozens and {2} eggs" + 
                ".", totaleggs, totalremegg1, totalegg);

            displayEggsInterActive(); 
        }
        public static void displayEggsInterActive()
        {
            const int EGG_TO_DOZEN = 12;
            int chickenEgg1;
            int chickenEgg2;
            int chickenEgg3;
            int chickenEgg4;
            int totaleggs;
            int totalremegg1;
            int totalegg;
            string chicken1Entry;
            string chicken2Entry;
            string chicken3Entry;
            string chicken4Entry;


            Console.WriteLine("Enter amount of eggs from chicken 1 >>> ");
            chicken1Entry = Console.ReadLine();
            chickenEgg1 = Convert.ToInt32(chicken1Entry);

            Console.WriteLine("Enter amount of eggs from chicken 2 >>> ");
            chicken2Entry = Console.ReadLine();
            chickenEgg2 = Convert.ToInt32(chicken2Entry);

            Console.WriteLine("Enter amount of eggs from chicken 3 >>> ");
            chicken3Entry = Console.ReadLine();
            chickenEgg3 = Convert.ToInt32(chicken3Entry);

            Console.WriteLine("Enter amount of eggs from chicken 4 >>> ");
            chicken4Entry = Console.ReadLine();
            chickenEgg4 = Convert.ToInt32(chicken4Entry);

            totaleggs = chickenEgg1 + chickenEgg2 + chickenEgg3 + chickenEgg4;
            totalremegg1 = totaleggs / EGG_TO_DOZEN;
            totalegg = totaleggs % EGG_TO_DOZEN;

            Console.WriteLine("There are {0} eggs from chicken 1, {1} from chicken 2, {2} from chicken 3, {3}" + 
                " from chicken 4, which totals to {4}. That means there are a total of {5} dozens and {6} eggs" +
                ".", chicken1Entry, chicken2Entry, chicken3Entry, chicken4Entry, totaleggs, totalremegg1, totalegg);






        }

    }

}
