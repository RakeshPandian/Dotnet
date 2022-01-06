using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Medium
{
    //  Create a function that takes a single string as argument and returns an ordered array containing the indices of all capital letters in the string.

    //Examples
    //IndexOfCapitals("eDaBiT") ➞ [1, 3, 5]

    //    IndexOfCapitals("eQuINoX") ➞ [1, 3, 4, 6]

    //    IndexOfCapitals("determine") ➞ []

    //    IndexOfCapitals("STRIKE") ➞ [0, 1, 2, 3, 4, 5]

    //    IndexOfCapitals("sUn") ➞ [1]
    //    Notes
    //    Return an empty array if no uppercase letters are found in the string.
    //Special characters($#@%) and numbers will be included in some test cases.
    //Assume all words do not have duplicate letters.
    internal class IndexofCapitalLetters
    {
        public int[] Evaluate(string input)
        {
            List<int> result = new List<int>();
            foreach (char c in input)
            {         
                if (char.IsUpper(c))
                {
                    result.Add(input.IndexOf(c));
                } 
            }
            return result.ToArray();
        }
    }
}
