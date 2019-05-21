using NUnit.Framework;

namespace Codewars.sevenKyu
{
    [TestFixture]
    public class KataTest
    {
        [Test]
        [TestCase("AAAA", ExpectedResult = "TTTT")]
        [TestCase("ATTGC", ExpectedResult = "TAACG")]
        [TestCase("GTAT", ExpectedResult = "CATA")]
        [TestCase("AAGG", ExpectedResult = "TTCC")]
        [TestCase("CGCG", ExpectedResult = "GCGC")]
        [TestCase("GTATCGATCGATCGATCGATTATATTTTCGACGAGATTTAAATATATATATATACGAGAGAATACAGATAGACAGATTA", ExpectedResult = "CATAGCTAGCTAGCTAGCTAATATAAAAGCTGCTCTAAATTTATATATATATATGCTCTCTTATGTCTATCTGTCTAAT")]
        public string Test(string dna)
        {
            return Kata.DnaComplement(dna);
        }

    }
}