using System;
using System.Linq;
using System.Globalization;

namespace Codewars.sevenKyu
{
    public class Kata
    {
        public static String Accum(string word)
        {
            return string.Join('-', 
                word.ToLower()
                    .Select((chr, idx) =>
                        char.ToUpper(chr)
                        + new string(chr, idx)
                    )
                );
        }
    }
}