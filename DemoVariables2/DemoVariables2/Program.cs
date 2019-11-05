using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVariables2
{
    using static System.Console; 
    class DemoVariables2
    {
        static void Main()
        {
            int value1 = 50, value2 = 5;
            int sum, diff, product, quotient, remainder; 

            sum = value1 + value2;
            diff = value1 - value2;
            product = value1 * value2;
            quotient = value1 / value2;
            remainder = value1 % value2;

            Console.WriteLine("The sum of {0} and {1} is {2}", value1, value2, sum);
            Console.WriteLine("The difference of {0} and {1}" + " is {2}", value1, value2, diff);
            Console.WriteLine("The product of {0} and {1} is {2}", value1, value2, product);
            Console.WriteLine("The quotient of {0} and {1} is {2}", value1, value2, quotient);
            Console.WriteLine("and the remainder is {0}", remainder);

        }
    }
}
