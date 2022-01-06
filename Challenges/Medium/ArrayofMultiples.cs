using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Medium
{
//  Create a function that takes two numbers as arguments(num, length) and returns an array of multiples of num until
//  the array length reaches length.

//  Examples
//  ArrayOfMultiples(7, 5) ➞ [7, 14, 21, 28, 35]

//  ArrayOfMultiples(12, 10) ➞ [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]

//  ArrayOfMultiples(17, 6) ➞ [17, 34, 51, 68, 85, 102]
//  Notes
//  Notice that num is also included in the returned array.
    internal class ArrayofMultiples
    {
        public int[] Evaluate(int num, int length)
        {
            List<int> result = new List<int>();
            for (int i = 1; i <= length; i++)
            {
                if (result.Count == length)
                {
                    return result.ToArray();
                }
                result.Add(num * i);
            }
            return result.ToArray();
        }
    }
}
