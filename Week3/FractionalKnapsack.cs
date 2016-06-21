using System;
using System.Collections.Generic;


namespace Coursera
{
    public class FractionalKnapsack
    {
        public class Items
        {
            public int values { get; set; }
            public int weights { get; set; }
            public Items(int v, int w)
            {
                values = v;
                weights = w;
            }
        }

        public static int min(int wi, int capacity)
        {
            if (wi > capacity)
                return capacity;
            else
                return wi;
        }

        private static double getOptimalValue(int capacity, int[] values, int[] weights)
        {
          
            List<Items> lst = new List<Items>();
            for (int i = 0; i < values.Length; i++)
            {
                lst.Add(new Items(values[i], weights[i]));
            }

            lst.Sort(delegate (Items c1, Items c2) { return (c1.values / c1.weights).CompareTo(c2.values / c2.weights); });
            var araylist = lst.ToArray();
     
            double totalValues = 0;

            for (int j = araylist.Length - 1; j >= 0; j--)
            {
                if (capacity == 0)
                    return totalValues;
                int a = min(araylist[j].weights, capacity);
                totalValues = totalValues + a * (Math.Round((double)((double)araylist[j].values / (double)araylist[j].weights), 5));
                capacity = capacity - a;

            }
            return totalValues;
        }

        static public void Main()
        {
            string[] stringArray = Console.ReadLine().Split(' ');
            int[] intArray = Array.ConvertAll(stringArray, int.Parse);
            int n = intArray[0];
            int capacity = intArray[1];
            int[] values = new int[n];
            int[] weights = new int[n];
            for (int i = 0; i < n; i++)
            {
                string[] stringItemArray = Console.ReadLine().Split(' ');
                int[] intItemArray = Array.ConvertAll(stringItemArray, int.Parse);
                values[i] = intItemArray[0];
                weights[i] = intItemArray[1];
            }
            Console.WriteLine(getOptimalValue(capacity, values, weights));
        }
    }
}
