using NUnit.Framework;
namespace Codewars.sixKyu
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void DuplicateEncode()
        {
            Assert.AreEqual("(((", Kata.DuplicateEncode("din"));
            Assert.AreEqual("()()()", Kata.DuplicateEncode("recede"));
            Assert.AreEqual(")())())", Kata.DuplicateEncode("Success"), "should ignore case");
            Assert.AreEqual("))((", Kata.DuplicateEncode("(( @"));
        }
    }
}