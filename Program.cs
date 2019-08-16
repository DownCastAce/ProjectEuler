using System;

namespace ProjectEuler
{
    public class Program
    {
        private const long Problem1BelowValue = 1000;
        private const long Problem2FibLimt = 4000000;
        private const long Problem3LargestPrime = 600851475143;
        
        public static void Main(string[] args)
        {
            Console.WriteLine($"Problem1: Find the sum of all the multiples of 3 or 5 below 1000.\nProblem1 Answer : {Problem1.FormulaSolution(3, 5, Problem1BelowValue-1)}");
            
            Console.WriteLine($"Problem2: By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.\nProblem2 Answer : {Problem2.Solve(Problem2FibLimt)}");
            
            Console.WriteLine($"Problem3: What is the largest prime factor of the number 600851475143?\nProblem3 Answer : {Problem3.Solve(Problem3LargestPrime)}");
            
            Console.WriteLine($"Problem4 :  Find the largest palindrome made from the product of two 3-digit numbers. Answer : {Problem4.Solve()}");
            
            Console.WriteLine($"Problem5 :  What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?. Answer : {Problem5.Solve()}");
            
            Console.WriteLine($"Problem6 :  Find the difference between the sum of the squares of the first 100 natural numbers and the square of the sum. Answer : {Problem6.Solve(100)}");
            
            Console.WriteLine($"Problem7 :  What is the 10 001st prime number? Answer : {Problem7.Solve1(10001)}");
        }
    }
}