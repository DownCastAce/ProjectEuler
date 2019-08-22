using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests
{
    [TestFixture]
    public class Problem2Tests
    {
        [Test]
        public void Verify_Sum_Of_Squares()
        {
            Assert.AreEqual(10, Problem2.Solve(10));
            Assert.AreEqual(44, Problem2.Solve(100));
            Assert.AreEqual(188, Problem2.Solve(150));
            Assert.AreEqual(4613732, Problem2.Solve(4000000));
        }
    }
}