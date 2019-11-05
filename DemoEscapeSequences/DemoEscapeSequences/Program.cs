using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEscapeSequences
{
    using static System.Console;
    class DemoEscapeSequences
    {
        static void Main(string[] args)
        {
            WriteLine("This line\tcontains two\ttabs");
            WriteLine("This statement\ncontains a new line");
            WriteLine("This statement sounds three alerts\a\a\a"); 

        }
    }
}
