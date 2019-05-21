using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars.sixKyu
{
    /*
        Name: DuplicateEncode
        URL: https://www.codewars.com/kata/54b42f9314d9229fd6000d9c
        Attempts:
        1.  https://www.codewars.com/kata/reviews/57ab76bdd9af9cfeed000111/groups/5ce22c789a2e9800010533b7
        2.  https://www.codewars.com/kata/reviews/57ab76bdd9af9cfeed000111/groups/5ce22c789a2e9800010533b7
     */
    public class Kata
    {
        public static string DuplicateEncode(string word)
        {
            //word to lowercase
            word = word.ToLower();

            //create a char array of ')' with the length of the word to reduce code complexity
            char[] encoding = new string(')', word.Length).ToCharArray();

            //grouping by character and position
            //taking the non repeating ones
            //retrieving their positions
            IEnumerable<int> lonelies =
                word.GroupBy(chr => chr, chr => word.IndexOf(chr), (chr, idx) => idx)
                    .Where(indexes => indexes.Count() == 1)
                    .SelectMany(indexes => indexes);

            //replace ')' by '(' at idx
            foreach (int idx in lonelies)
                encoding[idx] = '(';

            //return the encoded string
            return new string(encoding);
        }
    }
}