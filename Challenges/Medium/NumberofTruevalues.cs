using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Medium
{

//Create a function which returns the number of true values there are in an array.

//Examples
//CountTrue([true, false, false, true, false]) ➞ 2

//CountTrue([false, false, false, false]) ➞ 0

//CountTrue([]) ➞ 0
//Notes
//Return 0 if given an empty array.
//All array items are of the type bool (true or false).

    internal class NumberofTruevalues
    {
        public int Evaluate(bool[] arr)
        {
            //if (arr.Length > 0)
            if (arr == null || (arr != null && arr.Length == 0)) 
                return 0;
            else
            {
                return arr.Where(x => x == true).Count();
            }
        }
    }
}
