using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public static class Fibonacci
    {
        public static IEnumerable<long> Get(int n)
        {
            yield return 0;
            //yield return 1;

            int lastN1 = 0;
            int lastN2 = 1;
            for(int i = 1; i <= n; i++)
            {
                int currentN = lastN1 + lastN2;
                yield return currentN;
                //iese afara

                //reintra in fctie
                Console.WriteLine($"Preparing to evaluate next Fibonacci {i+1}");
                lastN2 = lastN1;
                lastN1 = currentN;

            }
        }
    }
}
