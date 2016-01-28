using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibnocciObserver
{
    public static class FibnocciGenerator
    {
        static long[] fibArr = new long[90];
        public static void CreateFibnocci()
        {
            int n = 90;
            long next = 1;
            long curr = 0;

            for (int i = 0; i < n; i++)
            {
                next = curr + next;
                fibArr[i] = next;
                curr = next - curr;
            }
        }
        public static long[] GetFibnocciNumbers()
        {
            return fibArr;
        }
    }
}
