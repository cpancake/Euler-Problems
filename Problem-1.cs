/*Problem 1
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            int total1 = 0;

            for (int i = 0; i < 199; i++)
            {
                total1 = total1 + Sum(5, i, 200);
            }

            int total2 = 0;

            for (int i = 0; i < 333; i++)
            {
                total2 = total2 + Sum(3, i, 333);
            }

            int total3 = 0;

            for (int i = 0; i < 66; i++)
            {
                total3 = total3 + Sum(15, i, 66);
            }
            
            int totalprime = total1 + total2 - total3;
            Console.WriteLine(totalprime);
            Console.ReadLine();
            
        }

        static int Sum(int x, int i, int r)
        {
            int[] numbers = Enumerable.Range(1, r).ToArray();

            int sum1 = numbers[i] * x;
            return sum1;
        }

    }
}
