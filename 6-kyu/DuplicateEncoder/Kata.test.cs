using NUnit.Framework;
namespace Codewars.sixKyu
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        [TestCase("din", ExpectedResult = "(((")]
        [TestCase("recede", ExpectedResult = "()()()")]
        [TestCase("Success", ExpectedResult = ")())())")] //should ignore case
        [TestCase("(( @", ExpectedResult = "))((")]
        public string Test(string word)
        {
            return Kata.DuplicateEncode(word);
        }
    }
}