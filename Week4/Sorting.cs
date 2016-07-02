using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera
{
    class Sorting
    {


        private static void Swap<T>(T[] array, int left, int right)
        {
            var temp = array[right];
            array[right] = array[left];
            array[left] = temp;
        }

        public static void Sort<T>(T[] array, IComparer<T> comparer = null)
        {
            Sort(array, 0, array.Length - 1, comparer);
        }

        public static void Sort<T>(T[] array, int startIndex, int endIndex, IComparer<T> comparer = null)
        {
            if (comparer == null)
                comparer = Comparer<T>.Default;

            int left = startIndex;
            int right = endIndex;
            int pivot = startIndex;
            startIndex++;

            while (endIndex >= startIndex)
            {
                if (comparer.Compare(array[startIndex], array[pivot]) >= 0 && comparer.Compare(array[endIndex], array[pivot]) < 0)
                    Swap(array, startIndex, endIndex);
                else if (comparer.Compare(array[startIndex], array[pivot]) >= 0)
                    endIndex--;
                else if (comparer.Compare(array[endIndex], array[pivot]) < 0)
                    startIndex++;
                else
                {
                    endIndex--;
                    startIndex++;
                }
            }

            Swap(array, pivot, endIndex);
            pivot = endIndex;
            if (pivot > left)
                Sort(array, left, pivot);
            if (right > pivot + 1)
                Sort(array, pivot + 1, right);
        }

        static void Main(string[] args)
        {

            int len = int.Parse(Console.ReadLine());
            string[] stringArray = Console.ReadLine().Split(' ');
            long[] numbers = Array.ConvertAll(stringArray, Int64.Parse);


            Sort(numbers, 0, len-1);
            for (int i = 0; i < len; i++)
                Console.Write(numbers[i]+" ");
         
        }
    }
}
