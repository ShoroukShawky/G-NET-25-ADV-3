using System.Collections.ObjectModel;

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
            ////1
            //SortedList<int, string> Leaderboard = new()
            //{
            //    {500 ,"Ahmed" },
            //    {200 , "Sara" },
            //    {800 ,"Ali" },
            //    {350 , "Mona" }
            //};

            ////2 
            //ConsoleHelper.PrintSortedList("List", Leaderboard);

            ////3
            //Console.WriteLine($"First key = {Leaderboard.First().Key}");
            //Console.WriteLine($"First value = {Leaderboard.First().Value}");

            ////4
            //Console.Write("Contain score 500 ? ");
            //Console.WriteLine(Leaderboard.ContainsKey(500));

            ////5
            //if (Leaderboard.TryGetValue(999, out string? value)) 
            //   Console.WriteLine($"Player with score 999 : {value}");
            //else
            //    Console.WriteLine($"Player with score 999 not found");

            ////6
            //Leaderboard.Remove(200);
            //ConsoleHelper.PrintSortedList("List", Leaderboard);
            #endregion

            #region Ex03
            ////1
            //Dictionary<string, string> phoneBook = new()
            //{
            //    {"Ahmed" ,"0102222222" },
            //    {"Sara" , "010452365" },
            //    {"Mohamed" , "010125478" } ,
            //    {"Mahmoud" , "0103265445"}
            //};

            // //2
            //phoneBook["Sama"] = "01056666448";

            ////3
            //try
            //{
            //    phoneBook.Add("Sara", "0122544499");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            ////4
            //Console.WriteLine( phoneBook.TryAdd("Mahmoud", "010546666"));

            ////5
            //  if(!phoneBook.ContainsKey("Samy"))
            //    Console.WriteLine("Samy doesn't exist");

            //// 6
            //if (phoneBook.TryGetValue("Samy", out string value))
            //    Console.WriteLine(value);
            //else
            //    Console.WriteLine("Not Found");

            //// 7
            //Console.Write("All Keys : ");
            //Console.WriteLine(string.Join("," , phoneBook.Keys));

            //Console.Write("All Values : ");
            //Console.WriteLine(string.Join(",", phoneBook.Values));
            #endregion

            #region Ex04
            HashSet<string> set = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                 "ahmed@test.com", "AHMED@test.com", "sara@test.com", "Sara@Test.Com"

            };

            Console.WriteLine(set.Count); //2 , StringComparer.OrdinalIgnoreCase makes it treat strings with different letter cases as equal

            HashSet<int> SetA = [1, 2, 3 , 4 , 5];
            HashSet<int> SetB = [4, 5 , 6 , 7 ,8];

            var union = new HashSet<int>(SetA);
            union.UnionWith(SetB);
            ConsoleHelper.PrintHashSet("Union" , union);

            var Intersec = new HashSet<int>(SetA);
            Intersec.IntersectWith(SetB);
            ConsoleHelper.PrintHashSet("Intersec", Intersec);


            var Except = new HashSet<int>(SetA);
            Except.ExceptWith(SetB);
            ConsoleHelper.PrintHashSet("Except", Except);

            HashSet<int> SetC = [1, 2];
            Console.Write("[1,2] is subset of setA? ");
            Console.WriteLine(SetC.IsSubsetOf(SetA));
            #endregion
        }
    }
}
