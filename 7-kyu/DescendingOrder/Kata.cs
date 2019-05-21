using System;
using System.Linq;

namespace Codewars.sevenKyu
{
    /*  
        Descending Order
        http://www.codewars.com/kata/5467e4d82edf8bbf40000155/
        Attempts:
        1. https://www.codewars.com/kata/reviews/550b0be906815114a70017d2/groups/5ce37eb8319aec0001f299ac
        2. https://www.codewars.com/kata/reviews/550b0be906815114a70017d2/groups/5ce37fbdec0eac000180afa7
    */
    public static class Kata
    {
        public static int DescendingOrder(int num)
        {
            return int.Parse(string.Concat(Convert.ToString(num).OrderByDescending(digit => digit)));
        }
    }
}