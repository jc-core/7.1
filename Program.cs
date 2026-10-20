using static Assignment7_1.TextFuncs;
using static Assignment7_1.SortFuncs;
namespace Assignment7_1 {
    internal class Program {

        static void Main(string[] args) {

        startLoop:

            switch (ReadChoice("(1) Sort scores  (2) Merge words:")) {
                case "1":
                    RunScores();
                    break;
                case "2":
                    RunMergeWords();
                    break;
                default:
                    Console.WriteLine("No input, try again.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("...");
            Console.ReadKey(true);
            Console.Clear();

            goto startLoop;

        }

        static void RunScores() {

            Console.WriteLine("Scores from 0 to 100, separated by spaces.");
            int[] scores = ReadScores("Scores:");

            if (scores.Length == 0) {
                Console.WriteLine("No input, try again.");
                return;
            }

            Console.WriteLine($"Before:    {string.Join(" ", scores)}");
            Console.WriteLine($"Selection: {string.Join(" ", SelectionSort(scores))}");
            Console.WriteLine($"Insertion: {string.Join(" ", InsertionSort(scores))}");

        }

        static void RunMergeWords() {

            Console.WriteLine("Two words, merged letter by letter.");
            string first = ReadText("First word:");
            string second = ReadText("Second word:");

            if (first == "" || second == "") {
                Console.WriteLine("No input, try again.");
                return;
            }

            Console.WriteLine($"Merged: {MergeWords(first, second)}");

        }
    }
}
