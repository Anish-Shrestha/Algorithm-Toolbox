using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera
{
    public class LSC
    {






        private static int lcs3(int[] a, int[] b, int[] c)
        {
        
            int n = a.Length, m = b.Length, l = c.Length;
            int[,,] table = new int[n + 1, m + 1, l + 1];
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= m; j++)
                {
                    for (int k = 0; k <= l; k++)
                    {
                        if (i == 0 || j == 0 || k == 0)
                        {
                            table[i, j, k] = 0;
                            continue;
                        }
                        if (a[i - 1] == b[j - 1] && b[j - 1] == c[k - 1])
                        {
                            table[i, j, k] = table[i - 1, j - 1, k - 1] + 1;
                            continue;
                        }
                 
                        int x = table[i - 1, j, k],
                            y = table[i, j - 1, k],
                            z = table[i, j, k - 1];
                        table[i, j, k] = Math.Max(x, Math.Max(y, z));
                    }
                }
            }
            return table[n, m, l];
        }

        public static void Main()
        {
            int an = int.Parse(Console.ReadLine());
            int[] a = new int[an];


            string[] stringArray = Console.ReadLine().Split(' ');
            a = Array.ConvertAll(stringArray, Int32.Parse);

            int bn = int.Parse(Console.ReadLine());
            int[] b = new int[bn];
            string[] stringArrayb = Console.ReadLine().Split(' ');
            b = Array.ConvertAll(stringArrayb, Int32.Parse);
            int cn = int.Parse(Console.ReadLine());
            int[] c = new int[cn];
            string[] stringArrayc = Console.ReadLine().Split(' ');
            c = Array.ConvertAll(stringArrayc, Int32.Parse);

            Console.WriteLine(lcs3(a, b, c));
       
        }
    }
}
