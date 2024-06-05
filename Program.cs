namespace ChallengeLabsWeek5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 2, 2, 1, 1, 5, 5, 7, 8, 8, 9, 9 };
            Console.WriteLine(GetSingleUseDigit(ints));
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
