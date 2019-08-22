using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests
{
    [TestFixture]
    public class Problem1Tests
    {
        [Test]
        public void Sum_Of_All_Natural_Numbers()
        {
            Assert.AreEqual(23, Problem1.Solve(3,5,10));
            Assert.AreEqual(233168, Problem1.Solve(3,5,1000));
        }
    }
}