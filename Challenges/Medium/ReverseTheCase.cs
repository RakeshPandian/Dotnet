using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Medium
{
    //    Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.

    //Examples
    //ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"

    //ReverseCase("MANY THANKS") ➞ "many thanks"

    //ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS"
    internal class ReverseTheCase
    {
        public string Evaluate(string input = "")
        {
            return string.Concat(input.Select(x => char.IsUpper(x) ? char.ToLower(x) : char.ToUpper(x)));
        }
        //     public static string ReverseCase(string str)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    foreach (char ch in str)
        //    {
        //        sb.Append(Char.IsUpper(ch) ? Char.ToLower(ch) : Char.ToUpper(ch));
        //    }
        //    return sb.ToString();
        //}
    }
}
