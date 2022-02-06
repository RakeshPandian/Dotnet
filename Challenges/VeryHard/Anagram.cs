using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.VeryHard
{
//    Create a function that takes two strings and determines if an anagram of the first string is in
//    the second string. Anagrams of "bag" are "bag", "bga", "abg", "agb", "gab", "gba".
//    Since none of those anagrams are in "grab", the answer is false. A "g", "a",
//    and "b" are in the string "grab", but they're split up by the "r".

//Examples
//AnagramStrStr("car", "race") ➞ true

//AnagramStrStr("nod", "done") ➞ true

//AnagramStrStr("bag", "grab") ➞ false
//Notes
//Inputs will be valid strings in all lowercase letters.
//There exists a linear time algorithm for this.
    internal class Anagram
    {
        public bool Anagramstrstr(string needle, string haystack)
        {
            string sortedNeedle = string.Concat(needle.OrderBy(c => c));

            for (int i = 0; i < haystack.Length - sortedNeedle.Length + 1; i++)
            {
                string sortedHaystack = string.Concat(haystack.Substring(i, sortedNeedle.Length).OrderBy(c => c));

                if (sortedNeedle == sortedHaystack)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
