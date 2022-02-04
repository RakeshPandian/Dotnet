using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.VeryHard
{
//    Maximum Occurrence
//Given a string text.Write a function that returns the character with the highest frequency. If more than 1 character has the same highest frequency, return all those characters as a comma separated string. If there is no repetition in characters, return "No Repetition".

//Examples
//MaxOccur("Computer Science") ➞ "e"

//MaxOccur("Edabit") ➞ "No Repetition"

//MaxOccur("system admin") ➞ "m, s"

//MaxOccur("the quick brown fox jumps over the lazy dog") ➞ " "
//Notes
//Characters are case sensitive, so, for example, "C" and "c" are counted separately
    internal class MaximumOuucrence
    {
		public string MaxOccur(string txt)
		{
			var groups = txt.ToCharArray().OrderBy(c => c).GroupBy(c => c);
			var max = groups.Max(g => g.Count());
			return max > 1 ? string.Join(", ", groups.Where(g => g.Count() == max).Select(g => g.Key.ToString()).ToArray()) : "No Repetition";
		}
	}
}
