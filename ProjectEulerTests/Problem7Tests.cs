using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests
{
    [TestFixture]
    public class Problem7Tests
    {
        [Test]
        public void Get_Specific_Prime_Number()
        {
            Assert.AreEqual(13, Problem7.Solve(6));
            Assert.AreEqual(47, Problem7.Solve(15));
            Assert.AreEqual(104743, Problem7.Solve1(10001));
        }
        
        [Test]
        public void Get_Specific_Prime_Number_Alternative()
        {
            Assert.AreEqual(13, Problem7.Solve1(6));
            Assert.AreEqual(47, Problem7.Solve1(15));
            Assert.AreEqual(104743, Problem7.Solve(10001));
        }
    }
}