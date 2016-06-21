using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera
{
    public class Change
    {
        static public void Main()
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(getChange(number));
        }

        public static long getChange(long n)
        {
            int[] balance = new int[] { 10, 5, 1 };
            long remainder = 0;
            long numberOfCoins = 0;
            foreach (var coin in balance)
            {
                long numberForThisCoin = 0;

                if (n >= coin)
                {
                    remainder = n % coin;
                    numberOfCoins += (n / coin);
                    numberForThisCoin = (n / coin);
                    n = n - (numberForThisCoin * coin);

                }

            }
            return numberOfCoins;
        }
    }
}
