using NUnit.Framework;

namespace MinAbsSum.Tests
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Example()
        {
            var array = new[] { 1, 5, 2, -2 };
            var result = new Solution().solution(array);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Failed1()
        {
            var array = new[] { 3, 3, 3, 4, 5 };
            var result = new Solution().solution(array);
            Assert.AreEqual(0, result);
        }
    }
}
