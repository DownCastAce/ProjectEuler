using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests
{
    [TestFixture]
    public class Problem5Tests
    {
        [Test]
        public void Verify_Smallest_Positive_Number_Divisible_By_One_To_N()
        {
            Assert.AreEqual(60, Problem5.Solve(5));
            Assert.AreEqual(2520, Problem5.Solve(10));
            Assert.AreEqual(232792560, Problem5.Solve(20));
        }
    }
}