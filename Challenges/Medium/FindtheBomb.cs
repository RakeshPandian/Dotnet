using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Medium
{
//Create a function that finds the word "bomb" in the given string (not case sensitive).
//If found, return "Duck!!!", otherwise, return "There is no bomb, relax.".

//Examples
//Bomb("There is a bomb.") ➞ "Duck!!!"
//Bomb("Hey, did you think there is a bomb?") ➞ "Duck!!!"
//Bomb("This goes boom!!!") ➞ "There is no bomb, relax."
//Notes
//"bomb" may appear in different cases(i.e.uppercase, lowercase, mixed).
    internal class FindtheBomb
    {
        public string Evaluate(string input)
        {
            if (input.ToLower().Contains("bomb")) { return "Duck!!!"; }
            else { return "There is no bomb, relax."; }
        }
    }
}
