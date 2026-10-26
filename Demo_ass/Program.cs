namespace Demo_ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            // point 1
            List<int> grades = new List<int>() { 85, 92, 78, 95, 88, 70, 100, 65 };
            // point 2
            grades.ForEach(x => Console.Write($"{x}, "));
            Console.WriteLine($"\n{grades.Count}");
            Console.WriteLine(grades.First());
            Console.WriteLine(grades.Last());

            // point 3 
            grades.Sort();
            grades.ForEach(x => Console.Write($"{x}, "));

            Console.WriteLine();

            // point 4 
            Console.WriteLine(grades.First(x => x > 90));

            // point 5 
            grades.ForEach(x =>
            {
                if (x < 75)
                    Console.Write($"{x}, ");
                Console.WriteLine();
            });

            // point 6 
            grades.RemoveAll(x => x < 75);

            // point 7
            Console.WriteLine(grades.Contains(100));

            // point 8 
            //List<string> string_grades = new List<string>();

            //  مش عارف احل النقطه دي 

            #endregion

            Console.WriteLine("----------------------------------");

            #region Exercise 2: Leaderboard
            // point 1
            var leaderboard = new SortedDictionary<int, string>()
            {
                {500 ,"Ahmed" },
                {200 ,"Sara" },
                {350 ,"Mona" },
            };

            // point 2
            foreach (var item in leaderboard)
            {
                Console.WriteLine(item);
            }

            // point 3
            var f = leaderboard.First();
            Console.WriteLine(f.Key);
            Console.WriteLine(f.Value);

            // point 4 
            Console.WriteLine(leaderboard.ContainsKey(500));

            // point 5
            if (leaderboard.TryGetValue(999, out string player999))
            {
                Console.WriteLine($"Player with score 999: {player999}");
            }
            else
            {
                Console.WriteLine("not exist");
            }
            Console.WriteLine();

            // point 6 
            leaderboard.Remove(200);
            foreach (var item in leaderboard)
            {
                Console.WriteLine(item);
            }
            #endregion

        }
    }
}
















