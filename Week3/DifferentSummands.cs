using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera
{
    public class DifferentSummands
    {
        private static List<int> optimalSummands(int n)
        {
            List<int> summands = new List<int>();

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {

                if ((sum + i) <= n)
                {
                    sum += i;
                }

                if ((sum != n) && Math.Abs(sum - n) <= i)
                {
                    sum = sum - i;
                }
                else if (i != 0)
                    summands.Add(i);

                if (sum == n)
                    break;

            }
            return summands;
        }

        public static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            List<int> summands = optimalSummands(n);
            Console.WriteLine(summands.Count());
            foreach (int summand in summands)
            {
                Console.Write(summand + " ");
            }
        }


    }
}
