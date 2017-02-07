using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            int n2 = 1;

            Console.WriteLine("Please specify a number:");

            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please specify one more number:");

            n2 = Convert.ToInt32(Console.ReadLine());

            if ( n1 % n2 == 0)
            {
                Console.WriteLine("Second value is divider of first!");
            }

            else
            {
                Console.WriteLine("Second value is NOT divider of first!");
            }

            Console.ReadKey();
        }
    }
}
