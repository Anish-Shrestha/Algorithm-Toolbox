using System;

namespace Coursera
{
    public class EditDistance
    {
        public static int editDistance(string s, string t)
        {
            int m = s.Length, n = t.Length;
     
            int[,] table = new int[m + 1, n + 1];

            for (int j = 1; j <= n; j++) table[0, j] = j;
            for (int i = 1; i <= m; i++) table[i, 0] = i;
    
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    int insertion = table[i, j - 1] + 1,
                        deletion = table[i - 1, j] + 1,
                        mismatch = table[i - 1, j - 1] +
                            (s[i - 1] == t[j - 1] ? 0 : 1);
                
                    table[i, j] = Math.Min(insertion,
                                           Math.Min(deletion, mismatch));
                }
            }
            return table[m, n];
        }


        public static void Main()
        {
            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();
            Console.WriteLine(editDistance(str1, str2));
        }
    }
}
