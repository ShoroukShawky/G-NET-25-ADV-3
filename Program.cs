namespace ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ex01
            //// 1
            //List<int> list = new() {85,92,95,88,70,100,65 };

            //// 2
            //ConsoleHelper.PrintList("Grades", list);
            //Console.WriteLine($"List Count = {list.Count}");
            //Console.WriteLine($"first grade = {list.First()}");
            //Console.WriteLine($"last grade = {list.Last()}");

            //// 3
            //list.Sort();
            //ConsoleHelper.PrintList("Grades", list);

            //// 4
            //int firstAbov90 = list.Find(n => n > 90);
            //Console.WriteLine($"first grade above 90 = {firstAbov90}");

            ////5
            //List<int> failingGrades = list.Where(n => n < 75).ToList();
            //ConsoleHelper.PrintList("Failing Gardes", failingGrades);

            ////6
            //list.RemoveAll(n => n < 75);
            //ConsoleHelper.PrintList("after remove all failing grades =", list);

            //// 7
            //bool gradeEquals100 = list.Exists(n => n == 100);
            //Console.WriteLine($"Contains 100 ? {gradeEquals100}");

            ////8
            //List<string> gradeStrings = [..list.Select(g => $"Grade: {g}")];
            //ConsoleHelper.PrintList("Sting List", gradeStrings);
            #endregion

            #region Ex02
            //1
            SortedList<int, string> Leaderboard = new()
            {
                {500 ,"Ahmed" },
                {200 , "Sara" },
                {800 ,"Ali" },
                {350 , "Mona" }
            };

            //2 
            ConsoleHelper.PrintSortedList("List", Leaderboard);

            //3
            Console.WriteLine($"First key = {Leaderboard.First().Key}");
            Console.WriteLine($"First value = {Leaderboard.First().Value}");

            //4
            Console.Write("Contain score 500 ? ");
            Console.WriteLine(Leaderboard.ContainsKey(500));

            //5
            if (Leaderboard.TryGetValue(999, out string? value)) 
               Console.WriteLine($"Player with score 999 : {value}");
            else
                Console.WriteLine($"Player with score 999 not found");

            //6
            Leaderboard.Remove(200);
            ConsoleHelper.PrintSortedList("List", Leaderboard);
            #endregion
        }
    }
}
