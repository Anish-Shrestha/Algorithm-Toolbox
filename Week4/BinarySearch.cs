using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera
{
    class BinarySearch
    {


        public static int binarySearch(long[] data, long key, int size)
        {
            int low = 0;
            int high = size - 1;

            while (high >= low)
            {
                int middle = (low + high) / 2;
                if (data[middle] == key)
                {
                    return middle;
                }
                if (data[middle] < key)
                {
                    low = middle + 1;
                }
                if (data[middle] > key)
                {
                    high = middle - 1;
                }
            }
            return -1;
        }

        public static void Main()
        {
            string[] stringArray = Console.ReadLine().Split(' ');
            long[] intArray = Array.ConvertAll(stringArray, Int64.Parse);
            long numberOfElement = intArray[0];
            long[] inputSeries = new long[numberOfElement];
            for (int i = 0; i < numberOfElement; i++)
            {
                inputSeries[i] = intArray[i + 1];
            }

            string[] stringSearchArray = Console.ReadLine().Split(' ');
            long[] intSearchArray = Array.ConvertAll(stringSearchArray, Int64.Parse);
            long numberOfSearchElement = intSearchArray[0];
            long[] searchSeries = new long[numberOfSearchElement];
            for (int i = 0; i < numberOfSearchElement; i++)
            {
                searchSeries[i] = intSearchArray[i + 1];
            }


            int[] result = new int[numberOfSearchElement];
            for (int i = 0; i < numberOfSearchElement; i++)
            {

                result[i] = binarySearch(inputSeries, searchSeries[i], (int)numberOfElement);


            }
            foreach (int point in result)
            {
                Console.Write(point + " ");
            }
         
        }
    }
}
