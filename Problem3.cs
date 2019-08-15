using System;

namespace ProjectEuler
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// https://projecteuler.net/problem=3 
    /// </summary>
    public static class Problem3
    {
        public static long Solve(long input)
        {
            for(int counter = 2; counter <= Math.Sqrt(input); counter++)
            {

                if(input % counter == 0)
                {
                    input = input / counter;

                    counter--;
                }
            }

            if (input >= 2)
                return input;
            return 0;
        }
    }
}