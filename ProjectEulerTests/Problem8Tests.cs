using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests
{
    [TestFixture]
    public class Problem8Tests
    {
        [Test]
        public void Get_Specific_Prime_Number()
        {
            Assert.AreEqual(5832, Problem8.Solve(4));
            Assert.AreEqual(23514624000, Problem8.Solve(13));
        }
    }
}