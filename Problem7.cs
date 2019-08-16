using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// What is the 10 001st prime number?
    /// </summary>
    public class Problem7
    {
        public static long Solve1(long primeToSelect)
        {
            long[] primes = new long[primeToSelect];
            var counter = 0;
            primes[counter++] = 2;
 
            for (int i = 3; counter < primeToSelect; i += 2) {
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
                    primes[counter++] = i;
                }
            }
 
            return primes[(int) (primeToSelect-1)];            
        }

        public static long Solve(long primeToSelect)
        {
            var c = 2;
            var n = 0;
            long largestPrime = 0;

            while (c < primeToSelect) {

                n+= 6;

                if (IsPrime(n + 1)) {
                    c++;
                    if(largestPrime < n + 1)
                        largestPrime = n + 1;
                }

                if (IsPrime(n - 1)) {
                    c++;
                    if(largestPrime < n - 1)
                        largestPrime = n - 1;
                }
            }
            // Add one for the final prime being of the form 6k + 1
            return largestPrime;
        }

        private static bool IsPrime(int n) {

            if (n < 2)
                return false;

            if (n % 2 == 0)
                return n == 2;

            if (n % 3 == 0)
                return n == 3;

            var h = Math.Floor(1 + Math.Sqrt(n));
            var i = 5;

            while (i <= h) {
                if (n % i == 0)
                    return false;
                if (n % (i + 2) == 0)
                    return false;
                i+= 6;
            }
            return true;
        }
    }
}