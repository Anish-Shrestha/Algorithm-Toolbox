using System;


namespace Coursera
{
    class GCD
    {
        static public void Main()
        {
            string[] stringArray = Console.ReadLine().Split(' ');
            long[] intArray = Array.ConvertAll(stringArray, Int64.Parse);
            Console.WriteLine(euclidGCD(intArray[0], intArray[1]));

            string[] strin2gArray = Console.ReadLine().Split(' ');

        }

        private static long euclidGCD(long a, long b) {

            if (b == 0)
                return a;
            long aPrime = a % b;
            return euclidGCD(b,aPrime);
        }

    }
}
