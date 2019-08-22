using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests
{
    [TestFixture]
    public class Problem4Tests
    {
        [Test]
        public void Verify_Largest_Palindrome_For_Three_Digit_Number()
        {
            Assert.AreEqual(906609, Problem4.Solve());
        }
    }
}