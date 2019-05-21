using NUnit.Framework;

namespace Codewars.sevenKyu
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void Test0()
        {
            Assert.AreEqual(0, Kata.DescendingOrder(0));
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, Kata.DescendingOrder(1));
        }
        [Test]
        public void Test15()
        {
            Assert.AreEqual(51, Kata.DescendingOrder(15));
        }
        [Test]
        public void Test1021()
        {
            Assert.AreEqual(2110, Kata.DescendingOrder(1021));
        }
        [Test]
        public void Test123456789()
        {
            Assert.AreEqual(987654321, Kata.DescendingOrder(123456789));
        }
    }
}