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
        
        [Test]
        public void OneMinusOneIsZero()
        {
            Assert.AreEqual(0, 1 - 1);
        }
    }
}