using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    public class Problem5
    {
        public static long Solve2()
        {
            Stopwatch timer = Stopwatch.StartNew();
            var result = 0;
            var counter = 0;
            while (result == 0)
            {
                if (counter % 11 == 0 && counter % 12 == 0 && counter % 13 == 0 && counter % 14 == 0 &&
                    counter % 15 == 0 && counter % 16 == 0 && counter % 17 == 0 && counter % 18 == 0 &&
                    counter % 19 == 0)
                    result = counter;
                counter += 20;
            }
            timer.Stop();
            Console.WriteLine($"Problem5: Time : {timer.ElapsedMilliseconds}");
            return result;
        }
        
        public static long Solve()
        {
            Stopwatch timer = Stopwatch.StartNew();
            int divisorMax = 20;
            int[] primes = GeneratePrimes(divisorMax);
            int result = 1;

            for (int i = 0; i < primes.Length; i++)
            {
                int a = (int) Math.Floor(Math.Log(divisorMax) / Math.Log(primes[i]));
                result = result * ((int) Math.Pow(primes[i], a));
            }
            timer.Stop();
            Console.WriteLine($"Problem5 : Timer => {timer.ElapsedMilliseconds}");
            return result;
        }

        private static int[] GeneratePrimes(int divisorMax)
        {
            IList<int> primes = new List<int>();

            primes.Add(2);
 
            for (int i = 3; i <= divisorMax; i += 2) {
                var j = 0;
                var isPrime = true;
                while (primes[j]*primes[j] <= i) {
                    if (i % primes[j] == 0) {
                        isPrime = false;
                        break;
                    }
                    j++;
                }
                if (isPrime) {
                    primes.Add(i);
                }
            }
 
            return primes.ToArray();
        }
    }
}