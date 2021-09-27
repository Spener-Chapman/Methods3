using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    
    class Program
    {
        static int count = 0;
        static void Loop()
        {
            count = count + 1;
            Console.WriteLine("this is loop" + count);
            Loop(); // creates infiite loop of death

        }
        static void Main(string[] args)
        {
            Console.WriteLine("methods3");
            
            Loop();

            Console.ReadKey(true);
        }
    }
}
