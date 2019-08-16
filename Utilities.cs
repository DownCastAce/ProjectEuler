using System;

namespace ProjectEuler
{
    public static class Utilities
    {
        public static long SumOfSquares(int limit)
        {
            return limit * (limit + 1) * (2 * limit + 1) / 6;
        }

        public static long SquareOfTheSum(int limit)
        {
            return (long)(Math.Pow(limit, 2) * Math.Pow(limit + 1, 2) / 4);
        }
    }
}