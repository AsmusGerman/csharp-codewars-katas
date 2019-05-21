using System.Collections.Generic;
using System.Linq;
using System;

namespace Codewars.sixKyu
{
    /* 
        Stop gninnipS My sdroW!
        https://www.codewars.com/kata/5264d2b162488dc400000001
        Attempts:
        1. https://www.codewars.com/kata/reviews/57cc54e4e850d4a509000029/groups/5ce3787ab1397a000197c606
    */
    public class Kata
    {
        public static string SpinWords(string sentence)
        {
            const char separator = ' ';
            //split the sentence by word
            //revert each word with length of 5 or more
            //return the sentence
            return string.Join(
                separator,
                sentence.Split(separator)
                        .Select(word => word.Length >= 5 ? new string(word.Reverse().ToArray()) : word));
        }
    }
}