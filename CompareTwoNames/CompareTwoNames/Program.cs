using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTwoNames
{
    using System;
    using static System.Console;
    class CompareTwoNames
    {
        static void Main()
        {
            string name1 = "Amy";
            string name2 = "Amy";
            string name3 = "Matthew";
            WriteLine("Using Equals() method");
            WriteLine("Compare {0} to {1}: {2}" + 
            name1, name2, String.Equals(name1, name2));
            WriteLine("Compare {0} to {1}: {2}" +
           name1, name3, String.Equals(name1, name3));

            WriteLine("Using Compare() method");
            WriteLine("Compare {0} to {1}: {2}" +
           name1, name2, String.Compare(name1, name2));
            WriteLine("Compare {0} to {1}: {2}" +
           name1, name3, String.Compare(name1, name3));

            WriteLine("Using CompareTo() method");
            WriteLine("Compare {0} to {1}: {2}" +
           name1, name2, name1.CompareTo(name2));
            WriteLine("Compare {0} to {1}: {2}" +
           name1, name3, name1.CompareTo(name3));

        }
    }
}
