using System.Collections.Generic;
using System.Linq;
namespace Codewars.sevenKyu
{
    /*
        Complementary DNA
        https://www.codewars.com/kata/554e4a2f232cdd87d9000038
     */
    public class Kata
    {
        private static IDictionary<char, char> complements = new Dictionary<char, char>()
        {
            {'A', 'T'},
            {'T', 'A'},
            {'C', 'G'},
            {'G', 'C'}
        };

        public static string DnaComplement(string dna)
        {
            return string.Concat(dna.Select(chr => Kata.complements[chr]));
        }
    }
}