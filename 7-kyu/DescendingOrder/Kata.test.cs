using NUnit.Framework;

namespace Codewars.sevenKyu
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(15, ExpectedResult = 51)]
        [TestCase(1021, ExpectedResult = 2110)]
        [TestCase(123456789, ExpectedResult = 987654321)]

        public int Test(int number)
        {
            return Kata.DescendingOrder(number);
        }
    }
}