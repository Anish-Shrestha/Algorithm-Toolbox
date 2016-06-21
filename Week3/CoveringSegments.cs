using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera
{
    public class CoveringSegments
    {
        private static List<int> optimalPoints(Segment[] segments)
        {
            Array.Sort(segments, (x, y) => x.end.CompareTo(y.end));
            List<int> points = new List<int>();
            points.Add(segments[0].end);
            int check = points[0];

            foreach (var data in segments)
            {

                if (!(data.start <= check))
                {
                    points.Add(data.end);
                    check = data.end;
                }
            }
            return points;
        }

        public class Segment
        {
            public int start { get; set; }
            public int end { get; set; }

            public Segment(int start, int end)
            {
                this.start = start;
                this.end = end;
            }
        }
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Segment[] segments = new Segment[n];
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                int start, end;
                b = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                start = b[0];
                end = b[1];
                segments[i] = new Segment(start, end);
            }
            List<int> points = optimalPoints(segments);
            Console.WriteLine(points.Count());
            foreach (int point in points)
            {
                Console.Write(point + " ");
            }
        }
    }
}
