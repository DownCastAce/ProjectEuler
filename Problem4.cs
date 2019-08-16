using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    public static class Problem4
    {
        public static long Solve()
        {
            var largestPalindrome = 0;
            var a = 999;
            int b;
            int db;
            while (a >= 100)
            {
                if (a % 11 == 0)
                {
                    b = 999;
                    db = 1;
                }
                else
                {
                    b = 990;
                    db = 11;
                }

                while (b >= a)
                {
                    if (a * b <= largestPalindrome)
                    {
                        break;
                    }

                    if (IsPalindrome(a * b))
                    {
                        largestPalindrome = a * b;
                    }

                    b -= db;
                }
                
                a -= 1;
            }
            
            return largestPalindrome;
        }
        
        public static long Solve2(long a, long b)
        {
            IList<long> results = new List<long>();
            for (long i = a; i > 0; i--)
            {
                for (long j = b; j > 0; j--)
                {
                    long product = i * j;
                    string productPalindrome = product.ToString();
                
                    if (productPalindrome.Equals(ReverseString(productPalindrome)))
                    {
                        results.Add(product);
                        break;
                    }
                }
            }
            return results.Max();
        }
        
        private static bool IsPalindrome(int valueToCheck)
        {
            string checkString = valueToCheck.ToString();
            return checkString.Equals(ReverseString(checkString));
        }
        
        private static string ReverseString(string stringToReverse)
        {
            var charArray = stringToReverse.ToCharArray();
            Array.Reverse( charArray );
            return new string( charArray ); 
        }
    }
}