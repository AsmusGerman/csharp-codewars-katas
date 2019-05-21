using System;
using NUnit.Framework;
namespace Codewars.sixKyu
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        [TestCase("Welcome", ExpectedResult = "emocleW")]
        [TestCase("Hey fellow warriors", ExpectedResult = "Hey wollef sroirraw")]
        [TestCase("This is a test", ExpectedResult = "This is a test")]
        [TestCase("This is another test", ExpectedResult = "This is rehtona test")]
        [TestCase("You are almost to the last test", ExpectedResult = "You are tsomla to the last test")]
        [TestCase("Just kidding there is still one more", ExpectedResult = "Just gniddik ereht is llits one more")]
        public string Test(string word)
        {
            return Kata.SpinWords(word);
        }

    }
}