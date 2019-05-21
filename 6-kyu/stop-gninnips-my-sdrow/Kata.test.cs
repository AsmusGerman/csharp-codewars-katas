using System;
using NUnit.Framework;
namespace Codewars.sixKyu
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("emocleW", Kata.SpinWords("Welcome"));
        }


        [Test]
        public void Test2()
        {
            Assert.AreEqual("Hey wollef sroirraw", Kata.SpinWords("Hey fellow warriors"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("This is a test", Kata.SpinWords("This is a test"));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual("This is rehtona test", Kata.SpinWords("This is another test"));
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual("You are tsomla to the last test", Kata.SpinWords("You are almost to the last test"));
        }

        [Test]
        public void Test6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", Kata.SpinWords("Just kidding there is still one more"));
        }
    }
}