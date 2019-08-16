using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests
{
    [TestFixture]
    public class Problem6Tests
    {
        [Test]
        public void Verify_Sum_Of_Squares()
        {
            Assert.AreEqual(55, Utilities.SumOfSquares(5));
            Assert.AreEqual(385, Utilities.SumOfSquares(10));
        }
        
        [Test]
        public void Verify_Square_Of_The_Sum()
        {
            Assert.AreEqual(225, Utilities.SquareOfTheSum(5));
            Assert.AreEqual(3025, Utilities.SquareOfTheSum(10));
        }
        
        [Test]
        public void Verify_Difference()
        {
            Assert.AreEqual(170, Problem6.Solve(5));
            Assert.AreEqual(2640, Problem6.Solve(10));
        }
    }
}