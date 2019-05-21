using System;
namespace Codewars.eigthKyu
{
    /*
        Remove First and Last Character
        https://www.codewars.com/kata/56bc28ad5bdaeb48760009b0
     */
    public class Kata
    {
        //removes the first and the last char of the word
        public static string RemoveChar(string word)
        {
            return word.Substring(1, word.Length - 2);
        }
    }
}