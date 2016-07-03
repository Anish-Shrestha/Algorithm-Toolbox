using System;

namespace Coursera
{
    public class PlacingParentheses
    {
        private static long getMaximValue(string exp)
        {
           
            int n = exp.Length / 2 + 1;
          
            int[,] min = new int[n, n], max = new int[n, n];
          
            for (int i = 0; i < n; i++)
            {
                min[i, i] = exp[i * 2] - '0';
                max[i, i] = exp[i * 2] - '0';
            }
      
            for (int size = 1; size <= n - 1; size++)
            {
         
                for (int i = 0; i <= n - 1 - size; i++)
                {
                    int j = size + i; 
                    int[] res = getMinAndMax(exp, i, j, min, max);
                    min[i, j] = res[0];
                    max[i, j] = res[1];
                }
            }
 
            return max[0, n - 1];
        }


        public static int[] getMinAndMax(string exp, int i, int j, int[,] min, int[,] max)
        {
            int[] res = new int[] { int.MaxValue, int.MinValue };
            for (int index = i; index <= j - 1; index++)
            {

                char oper = exp[index * 2 + 1];
        
                long a = eval(min[i, index], min[index + 1, j], oper),
                        b = eval(min[i, index], max[index + 1, j], oper),
                        c = eval(max[i, index], min[index + 1, j], oper),
                        d = eval(max[i, index], max[index + 1, j], oper);
                res[0] = (int)Math.Min(a, Math.Min(b,
                        Math.Min(c, Math.Min(d, res[0]))));
                res[1] = (int)Math.Max(a, Math.Max(b,
                        Math.Max(c, Math.Max(d, res[1]))));
            }
            return res;
        }

        public static long eval(long a, long b, char op)
        {
            if (op == '+')
            {
                return a + b;
            }
            else if (op == '-')
            {
                return a - b;
            }
            else if (op == '*')
            {
                return a * b;
            }
            else {

                return 0;
            }
        }


        public static void Main()
        {

            string expression = Console.ReadLine();
            Console.WriteLine(getMaximValue(expression));
        
    
        }
    }
}
