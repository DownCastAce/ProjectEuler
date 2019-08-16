using System;
using System.Diagnostics;

namespace ProjectEuler
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// https://projecteuler.net/problem=1
    /// </summary>
    public static class Problem1
    {
        public static long ForLoopSolution(long a, long b, long belowValue)
        {
            
            long sum = 0;

            for (long i = 0; i < belowValue; i++)
            {
                if (i % a == 0 || i % b == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        
        public static long FormulaSolution(long a, long b, long belowValue)
        {
            Stopwatch timer = Stopwatch.StartNew();
            long sum = 0;
            long nForA = (belowValue) / a;
            long resultForA = a * nForA * (nForA+1)/2;
            
            long nForB = (belowValue) / b;
            long resultForB = b * nForB * (nForB+1)/2;

            long resultForC = 0;
            if (a * b < belowValue)
            {
                long c = a * b;
                long nForC = (belowValue) / c;
                resultForC = c * nForC * (nForC+1)/2;
            }

            sum = resultForA + resultForB - resultForC;
            
            timer.Stop();
            Console.WriteLine($"Formula time : {timer.ElapsedMilliseconds}");
            return sum;
        }
    }
}