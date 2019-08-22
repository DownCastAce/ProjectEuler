using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests
{
    [TestFixture]
    public class Problem3Tests
    {
        [Test]
        public void Verify_Largest_Prime_Factor()
        {
            Assert.AreEqual(29, Problem3.Solve(13195));
            Assert.AreEqual(6857, Problem3.Solve(600851475143));
        }
    }
}