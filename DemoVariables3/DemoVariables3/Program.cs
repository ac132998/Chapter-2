using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVariables3
{
    using static System.Console;
    class DemoVariables3
    {
        static void Main()
        {
            int value = 4;
            bool isSixMore = 6 > value;
            WriteLine("When value is {0} isSixMore is {1}", value, isSixMore);
            value = 55;
            isSixMore = 6 > value;
            WriteLine("When value is {0} isSixMore is {1}", value, isSixMore);


        }
    }
}
