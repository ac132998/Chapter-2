using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVariables.cs
{
    using static System.Console;
    class DemoVariables 
    {
        static void Main()
        {
            long anInt = -123456789000;
            uint anUnsignedInt = 567;
            Console.WriteLine("The int is {0} and the unsigned int is {1}.", anInt, anUnsignedInt);

            short Int = 12345;
            ushort unInt = 65535;
            Console.WriteLine("The int is {0} and the unsigned int is {1}.", Int, unInt);

            byte anBy = 250;
            sbyte anUnsBy = 120;
            Console.WriteLine("The byte is {0} and the unsigned byte is {1}.", anBy, anUnsBy);
        }
    }
}
