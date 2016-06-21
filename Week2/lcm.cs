using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera
{
    class lcm
    {
        static public void Main()
        {
            string[] stringArray = Console.ReadLine().Split(' ');
            long[] intArray = Array.ConvertAll(stringArray, Int64.Parse);
            Console.WriteLine(leastCommonMultiplier(intArray[0], intArray[1]));

            string[] strin2gArray = Console.ReadLine().Split(' ');

        }

        private static long leastCommonMultiplier(long a, long b)
        {

            long lcm = (a * b) / (euclidGCD(a, b));

            return lcm;
        }

        private static long euclidGCD(long a, long b)
        {
            if (b == 0)
                return a;
            long aPrime = a % b;
            return euclidGCD(b, aPrime);
        }
    }
}
