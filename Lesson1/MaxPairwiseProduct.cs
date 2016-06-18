using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera
{
    class MaxPairwiseProduct
    {
        static public void Main() {
            int number = int.Parse(Console.ReadLine());
            string[] stringArray = Console.ReadLine().Split(' ');
            int[] intArray = Array.ConvertAll(stringArray, int.Parse);
            long max = 0, secondmax = 0;int flag=0;
            for (int i = 0; i < number; i++) {

                if (intArray[i] == max && flag == 1) secondmax = intArray[i];

                else if (max < intArray[i]) {
                   
                    secondmax = max;  max = intArray[i]; }

                if (intArray[i] < max && intArray[i] > secondmax)
                    secondmax = intArray[i];

                flag = 1;
            }
            Console.WriteLine(max * secondmax);
           
        }
    }
}
