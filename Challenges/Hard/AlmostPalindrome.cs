using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Hard
{
    //A string is an almost-palindrome if, by changing only one character, you can make it a palindrome.Create a function that returns true if a string is an almost-palindrome and false otherwise.

    //Examples
    //AlmostPalindrome("abcdcbg") ➞ true
    //// Transformed to "abcdcba" by changing "g" to "a".

    //AlmostPalindrome("abccia") ➞ true
    //// Transformed to "abccba" by changing "i" to "b".

    //AlmostPalindrome("abcdaaa") ➞ false
    //// Can't be transformed to a palindrome in exactly 1 turn.

    //AlmostPalindrome("1234312") ➞ false
    //Notes
    //Return false if the string is already a palindrome.
    internal class AlmostPalindrome
    {
        public bool Evaluate(string input)
        {
            bool output = true;
            int count = input.Length;
            int startrange = 0;
            int endrange = 0;
            bool rangeflag = false;
            char missedchar;
            if (count % 2 == 0)
            {
                startrange = count / 2;
                rangeflag = true;
            }
            else
            {
                startrange = (count - 1) / 2;
                rangeflag = false;
            }
            List<char> firstList = input.ToCharArray().ToList().GetRange(0, startrange);
            List<char> lastList = new List<char>();
            if (rangeflag)
            {
                lastList = input.ToCharArray().ToList().GetRange(startrange, startrange);
            }
            else
            {
                lastList = input.ToCharArray().ToList().GetRange(startrange + 1, startrange);
                missedchar = input.ToList()[startrange];
            }
            var firstNotSecond = firstList.Except(lastList).ToList();
            if (firstNotSecond.Count != 1)
            {
                output = false;
            }
            return output;
        }
    }
}
