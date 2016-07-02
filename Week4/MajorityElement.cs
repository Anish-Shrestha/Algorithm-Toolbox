using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera
{
    class MajorityElement
    {
        static int GetCountForValue(long[] a, long x)
        {

            int count = 0;

            for (int i = 0; i < a.Length; i++)
                if (a[i] == x)
                    count++;
                else
                    count--;

            return count;

        }


        static long FindMajorityElement(long[] a)
        {

            int count = 1;
            long candidate = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] == candidate)
                {
                    count++;
                }
                else if (count == 0)
                {
                    candidate = a[i];
                    count = 1;
                }
                else
                {
                    count--;
                }
            }

            if (count > 0)
                count = GetCountForValue(a, candidate);

            if (count > 0)
                return 1;// return candidate;

            return 0;

        }


        public static void Main(string[] args)
        {

            int len = int.Parse(Console.ReadLine());
            string[] stringArray = Console.ReadLine().Split(' ');
            long[] numbers = Array.ConvertAll(stringArray, Int64.Parse);



            Console.WriteLine(FindMajorityElement(numbers));
        

        }
    }
}
