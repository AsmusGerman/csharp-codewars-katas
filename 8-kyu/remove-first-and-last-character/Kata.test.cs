using System;
using NUnit.Framework;

namespace Codewars.eigthKyu
{
    [TestFixture]
    public class Test
    {
        [Test]
        [TestCase("eloquent", ExpectedResult = "loquen")]
        [TestCase("country", ExpectedResult = "ountr")]
        [TestCase("person", ExpectedResult = "erso")]
        [TestCase("place", ExpectedResult = "lac")]
        [TestCase("ok", ExpectedResult = "")]
        public string RemoveChar(string word)
        {
            //original method name was "Remove_char"
            return Kata.RemoveChar(word);
        }
    }
}