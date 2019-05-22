using System;
using NUnit.Framework;

namespace Codewars.sevenKyu
{
    [TestFixture]
    public static class KataTest
    {
        [Test]
        [TestCase("ZpglnRxqenU", ExpectedResult = "Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu")]
        [TestCase("NyffsGeyylB", ExpectedResult = "N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb")]
        [TestCase("MjtkuBovqrU", ExpectedResult = "M-Jj-Ttt-Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu")]
        [TestCase("EvidjUnokmM", ExpectedResult = "E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm")]
        [TestCase("HbideVbxncC", ExpectedResult = "H-Bb-Iii-Dddd-Eeeee-Vvvvvv-Bbbbbbb-Xxxxxxxx-Nnnnnnnnn-Cccccccccc-Ccccccccccc")]
        public static string Test(string word)
        {
            return Kata.Accum(word);
        }
    }
}