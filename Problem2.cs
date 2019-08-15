namespace ProjectEuler
{
    /// <summary>
    /// Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
    /// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    /// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
    /// https://projecteuler.net/problem=2 
    /// </summary>
    public static class Problem2
    {
        public static long Solve(long fibLimit)
        {
            if (fibLimit < 2)
                return 0;
            
            long ef1 = 0;
            long ef2 = 2;

            long result = ef1 + ef2;
            
            while (ef2 < fibLimit)
            {
                
                long ef3 = 4 * ef2 + ef1;
                
                if (ef3 > fibLimit)
                    break;

                ef1 = ef2;
                ef2 = ef3;
                result += ef2;
                
            }
            
            return result;
        }
    }
}