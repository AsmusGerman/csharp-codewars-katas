using System;
using System.Linq;

namespace Codewars
{
    public class Kata
    {
        public static string DuplicateEncode(string word)
        {
            string lowerWord = word.ToLower();
            return String.Concat(lowerWord.Select(current => lowerWord.Count(next => next.Equals(current)) > 1 ? ')' : '('));
        }
    }
}