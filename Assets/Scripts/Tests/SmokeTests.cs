using NUnit.Framework;

namespace Tests
{
    public class SmokeTests
    {
        [Test]
        public void OnePlusOneIsTwo()
        {
            Assert.AreEqual(2, 1 + 1);
        }
    }
}