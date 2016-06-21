using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera
{
    class FibonacciHuge
    {
       
        static public void Main()
        {
            string[] stringArray = Console.ReadLine().Split(' ');
            long[] intArray = Array.ConvertAll(stringArray, Int64.Parse);
            var m = new FibMatrix(1, 1, 1, 0);
            m = m.RaiseMatrixByPowerMod(intArray[0] - 1, intArray[1]);
            Console.WriteLine(m.Result());
            string[] stringArray23 = Console.ReadLine().Split(' ');
        }
        

        public class FibMatrix
        {
            private long e1, e2, e3, e4;

            public FibMatrix(long cell1, long cell2, long cell3, long cell4)
            {
                e1 = cell1;
                e2 = cell2;
                e3 = cell3;
                e4 = cell4;
            }

            public FibMatrix()
            {
            }
           
      
            public FibMatrix RaiseMatrixByPowerMod(long p, long divisor)
            {
                if (p == 1) return this;
                if (p % 2 == 1)
                {
                    var tmp = RaiseMatrixByPowerMod(p - 1, divisor);
                    return this.MultiplyMod(tmp, divisor);
                }
                var res = RaiseMatrixByPowerMod(p / 2, divisor);
                return res.MultiplyMod(res, divisor);
            }
            

            public FibMatrix MultiplyMod(FibMatrix v, long divisor)
            {
                var result = new FibMatrix();
                var i = v.e1;
                var j = v.e2;
                result.e1 = (e1 * i + e3 * j) % divisor;
                result.e2 = (e2 * i + e4 * j) % divisor;
                i = v.e3;
                j = v.e4;
                result.e3 = (e1 * i + e3 * j) % divisor;
                result.e4 = (e2 * i + e4 * j) % divisor;
                return result;
            }
            
            public long Result()
            {
                return e1;
            }
        }
    }
}
