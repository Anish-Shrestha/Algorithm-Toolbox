using System;

namespace Coursera
{
    class DotProduct
    {
        static public void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            b = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine(minDotProduct(a, b));
        }

        private static long minDotProduct(int[] a, int[] b)
        {
            Array.Sort(a);
            Array.Sort(b);
            Array.Reverse(b);
            long result = 0;
            for (int i = 0; i < a.Length; i++)
                result += a[i] * b[i];
            return result;
        }


    }
}
