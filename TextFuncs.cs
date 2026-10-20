namespace Assignment7_1 {
    internal class TextFuncs {

        internal static string ReadChoice(string prompt) {

            while (true) {

                Console.Write($"{prompt} ");
                string? choice = Console.ReadLine();

                if (choice == null)
                    return "";

                choice = choice.Trim();

                if (choice == "1" || choice == "2")
                    return choice;

                Console.WriteLine("1 or 2 only, try again.");

            }
        }

        internal static int[] ReadScores(string prompt) {

            while (true) {

                Console.Write($"{prompt} ");
                string? line = Console.ReadLine();

                if (line == null)
                    return new int[0];

                string[] pieces = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (pieces.Length == 0) {
                    Console.WriteLine("Can't be blank, try again.");
                    continue;
                }

                int[] scores = new int[pieces.Length];
                bool valid = true;

                for (int spot = 0; spot < pieces.Length; spot++) {
                    if (!int.TryParse(pieces[spot], out int score) || score < 0 || score > 100) {
                        valid = false;
                        break;
                    }
                    scores[spot] = score;
                }

                if (valid)
                    return scores;

                Console.WriteLine("Whole numbers 0 to 100 only, separated by spaces, try again.");

            }
        }

        internal static string ReadText(string prompt) {

            while (true) {

                Console.Write($"{prompt} ");
                string? text = Console.ReadLine();

                if (text == null)
                    return "";

                if (text.Trim() != "")
                    return text.Trim();

                Console.WriteLine("Can't be blank, try again.");

            }
        }
    }
}
