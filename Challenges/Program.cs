using Challenges.Medium;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Rakesh!");

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
        }
    }
}