using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera
{
    class Fib
    {

      

        private static long fib(int n) {
            long a = 0;
            long b = 1;
            long c = 0;
            if (n == b) return b;
            for (int i = 2; i <= n; i++)
            {
               c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        static public void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(fib(number));
        }
    }
}
