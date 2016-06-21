using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera
{
    class FibonacciLastDigit
    {
        private static int fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            if (n == b) return b;
            for (int i = 2; i <= n; i++)
            {
                c = (a + b)%10;
                a = b;
                b = c;
            }
            return c;
        }
        static public void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(fibonacci(number));
        }
    }
}
