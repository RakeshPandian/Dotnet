using Challenges.Medium;
using Challenges.Hard;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Rakesh!");

            #region Medium Challenges
            NumberofTruevalues numberofTruevalues = new NumberofTruevalues();
            Console.WriteLine("Number of true values " + numberofTruevalues.Evaluate(new bool[] { true, false, false, true, false }));
            Console.WriteLine("Number of true values " + numberofTruevalues.Evaluate(new bool[] { true, true, true, true, true }));
            Console.WriteLine("Number of true values " + numberofTruevalues.Evaluate(new bool[] { false, false, false, false, false }));
            Console.WriteLine("Number of true values " + numberofTruevalues.Evaluate(new bool[] { }));
            Console.WriteLine("Number of true values " + numberofTruevalues.Evaluate(null));

            IndexofCapitalLetters indexofCapitalLetters = new IndexofCapitalLetters();
            Console.WriteLine("Below are indx of Capital letters");
            Console.WriteLine("[{0}]", string.Join(", ", indexofCapitalLetters.Evaluate("eDaBiT")));
            Console.WriteLine("[{0}]", string.Join(", ", indexofCapitalLetters.Evaluate("eQuINoX")));
            Console.WriteLine("[{0}]", string.Join(", ", indexofCapitalLetters.Evaluate("determine")));
            Console.WriteLine("[{0}]", string.Join(", ", indexofCapitalLetters.Evaluate("STRIKE")));
            Console.WriteLine("[{0}]", string.Join(", ", indexofCapitalLetters.Evaluate("sUn")));

            ArrayofMultiples arrayofMultiples = new ArrayofMultiples();
            Console.WriteLine("Array Of multiples");
            Console.WriteLine("[{0}]", string.Join(", ", arrayofMultiples.Evaluate(7, 5)));
            Console.WriteLine("[{0}]", string.Join(", ", arrayofMultiples.Evaluate(12, 10)));
            Console.WriteLine("[{0}]", string.Join(", ", arrayofMultiples.Evaluate(17, 6)));

            ReverseTheCase reverseTheCase = new ReverseTheCase();
            Console.WriteLine("ReverseTheCase");
            Console.WriteLine("Happy Birthday - " + reverseTheCase.Evaluate("Happy Birthday"));
            Console.WriteLine("MANY THANKS - " + reverseTheCase.Evaluate("MANY THANKS"));
            Console.WriteLine("sPoNtAnEoUs - " + reverseTheCase.Evaluate("sPoNtAnEoUs"));

            FindtheBomb findtheBomb = new FindtheBomb();
            Console.WriteLine("FindtheBomb");
            Console.WriteLine("There is a bomb. - " + findtheBomb.Evaluate("There is a bomb."));
            Console.WriteLine("Hey, did you think there is a bomb? - " + findtheBomb.Evaluate("Hey, did you think there is a bomb?"));
            Console.WriteLine("This goes boom!!! - " + findtheBomb.Evaluate("This goes boom!!!"));

            #endregion

            #region Hard Challenges

            CensoredStrings censoredStrings = new CensoredStrings();
            Console.WriteLine("CensoredStrings");
            Console.WriteLine("Wh*r* d*d my v*w*ls g*. - " + censoredStrings.Evaluate("Wh*r* d*d my v*w*ls g*", "eeioeo"));
            Console.WriteLine("abcd - " + censoredStrings.Evaluate("abcd",""));
            Console.WriteLine("*PP*RC*S* - " + censoredStrings.Evaluate("*PP*RC*S*", "UEAE"));

            ImaginaryInterview imaginaryInterview = new ImaginaryInterview();
            Console.WriteLine("ImaginaryInterview");
            Console.WriteLine("new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 120 - " + imaginaryInterview.Evaluate(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 120));
            Console.WriteLine("new int[] { 2, 3, 8, 6, 5, 12, 10, 18 }, 64 - " + imaginaryInterview.Evaluate(new int[] { 2, 3, 8, 6, 5, 12, 10, 18 }, 64));
            Console.WriteLine("new int[] { 5, 5, 10, 10, 25, 15, 20, 20 }, 120 - " + imaginaryInterview.Evaluate(new int[] { 5, 5, 10, 10, 25, 15, 20, 20 }, 120));
            Console.WriteLine("new int[] { 5, 5, 10, 10, 15, 15, 20 }, 120 - " + imaginaryInterview.Evaluate(new int[] { 5, 5, 10, 10, 15, 15, 20 }, 120));
            Console.WriteLine("new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 130 - " + imaginaryInterview.Evaluate(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 130));

            SmoothSentences smoothSentences = new SmoothSentences();
            Console.WriteLine("SmoothSentences");
            Console.WriteLine("Marta appreciated deep perpendicular right trapezoids. - " + smoothSentences.Evaluate("Marta appreciated deep perpendicular right trapezoids"));
            Console.WriteLine("Someone is outside the doorway. - " + smoothSentences.Evaluate("Someone is outside the doorway"));
            Console.WriteLine("She eats super righteously. - " + smoothSentences.Evaluate("She eats super righteously"));
            Console.WriteLine("Rakesh have eligibility. - " + smoothSentences.Evaluate("Rakesh have eligibility"));

            AlmostPalindrome almostPalindrome = new AlmostPalindrome();
            Console.WriteLine("AlmostPalindrome");
            Console.WriteLine("abcdcbg. - " + almostPalindrome.Evaluate("abcdcbg"));
            Console.WriteLine("abccia. - " + almostPalindrome.Evaluate("abccia"));
            Console.WriteLine("abcdaaa. - " + almostPalindrome.Evaluate("abcdaaa"));
            Console.WriteLine("1234312. - " + almostPalindrome.Evaluate("1234312"));

            SockPairs sockPairs = new SockPairs();

            Console.WriteLine("SockPairs");
            Console.WriteLine("AA. - " + sockPairs.Evaluate("AA"));
            Console.WriteLine("ABABC. - " + sockPairs.Evaluate("ABABC"));
            Console.WriteLine("CABBACCC. - " + sockPairs.Evaluate("CABBACCC"));
            Console.WriteLine("CABBACCCAAB. - " + sockPairs.Evaluate("CABBACCCAAB"));

            #endregion
        }
    }
}