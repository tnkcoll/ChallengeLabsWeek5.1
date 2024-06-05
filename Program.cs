namespace ChallengeLabsWeek5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints =GetArrayOfIntsFromUser("Please enter a number that only has one non-repeating digit. Ex: 22113");
            Console.WriteLine(GetSingleUseDigit(ints));
        }

        static int[] GetArrayOfIntsFromUser(string s)
        {
            string? userInput = "";

            do
            {
                Console.WriteLine(s);
                userInput = Console.ReadLine();
            } while (userInput == "");

            int[] ints = new int[userInput.Length];

            for (int i = 0; i < userInput.Length; i++)
            {
                double num = char.GetNumericValue(userInput[i]);
                ints[i] = Convert.ToInt32(num);
            }

            return ints;
        }

        static int GetSingleUseDigit(int[] ints)
        {
            Dictionary<int, int> selectionCount = new Dictionary<int, int>();
            foreach (int i in ints)
            {
                if (selectionCount.ContainsKey(i))
                {
                    selectionCount[i]++;
                }
                else
                {
                    selectionCount[i] = 1;
                }
            }

            foreach (var i in selectionCount)
            {
                if (i.Value == 1)
                {
                    return i.Key;
                }
            }
            return 0;
        }
    }
}
