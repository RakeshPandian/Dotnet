using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Hard
{
//Joseph is in the middle of packing for a vacation.He's having a bit of trouble finding all of his socks, though.

//Write a function that returns the number of sock pairs he has. A sock pair consists of two of the same letter, such as "AA". The socks are represented as an unordered sequence.

//Examples
//SockPairs("AA") ➞ 1

//SockPairs("ABABC") ➞ 2

//SockPairs("CABBACCC") ➞ 4
//Notes
//If given an empty string (no socks in the drawer), return 0.
//There can be multiple pairs of the same type of sock, such as two pairs of CC for the last example.
    internal class SockPairs
    {
        public int Evaluate(string input)
        {
            int result = 0;
            if (!string.IsNullOrEmpty(input))
            {
                List<char> inputList  = input.ToList();
                List<char> modifiedList = input.ToList();
                foreach (char c in inputList)
                {
                    int count = modifiedList.Count(X => X == c);
                    if (count >= 2)
                    {
                        result++;
                        modifiedList.Remove(c);
                        modifiedList.Remove(c);
                    } 
                    else if(count == 1)
                    {
                        modifiedList.Remove(c);
                    }
                }
            }
            return result;
        }
    }
}
