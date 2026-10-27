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
            });
            Console.WriteLine();
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
            if (leaderboard.TryGetValue(999, out string? player999))
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

            Console.WriteLine("----------------------------------");

            #region Exercise 3: Phone Book
            // point 1 
            Dictionary<string, string> phoneBook = new Dictionary<string, string>
            {
                { "Ahmed", "01112223344" },
                { "Sara", "01223334455" },
                { "Ali", "01005556677" },
                { "Mona", "01556667788" }
            };

            // point 2 
            phoneBook["Khaled"] = "01011223344";

            // point 3
            try
            {
                phoneBook.Add("Ahmed", "01999999999");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine();

            // point 4 
            Console.WriteLine(phoneBook.TryAdd("Youssef", "01032210487"));

            // point 5 
            Console.WriteLine( phoneBook.ContainsKey("Youssef"));

            // point 6
            Console.WriteLine(phoneBook.GetValueOrDefault("Saraaa", "Not Found"));

            // point 7 
            foreach (var item in phoneBook.Keys)
            {
                Console.Write($"{item} , ");
            }
            Console.WriteLine();
            foreach (var item in phoneBook.Values)
            {
                Console.Write($"{item} , ");
            }

            Console.WriteLine();
            #endregion

            Console.WriteLine("----------------------------------");

            #region Exercise 4: Unique Email Validator
            // point 1 
            HashSet<string> email = new HashSet<string>();

            // point 2 
            email.Add("ahmed@test.com");
            email.Add("AHMED@test.com");
            email.Add("sara@test.com");
            email.Add("Sara@Test.Com");

            // point 3 
            Console.WriteLine(email.Count); // because i sorted unique emails 

            // point 4 
            HashSet<int> A = [1, 2, 3, 4, 5];
            HashSet<int> B = [4, 5, 6, 7, 8];

            // point 5 
            HashSet<int> result = new HashSet<int>(A);
            result.UnionWith(B);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            result.IntersectWith(B);
            result.ExceptWith(B);

            // point 6 
            HashSet<int> C = [1,2];
            Console.WriteLine(C.IsSubsetOf(A));

            #endregion

            Console.WriteLine("----------------------------------");

            #region Exercise 5: Print Queue Simulator

            Queue<string> printer = new Queue<string>();
            printer.Enqueue("Report.pdf");
            printer.Enqueue("nvoice.pdf");
            printer.Enqueue("Letter.docx");
            printer.Enqueue("Resume.pdf");
            printer.Enqueue("Photo.jpg");

            // point 1 
            foreach (var item in printer)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(printer.Count);
            Console.WriteLine();

            // point 2 
            Console.WriteLine(printer.Peek());

            // point 3
            Console.WriteLine($"Printing: {printer.Dequeue()}");
            Console.WriteLine($"Printing: {printer.Dequeue()}");
            Console.WriteLine($"Printing: {printer.Dequeue()}");
            Console.WriteLine($"Printing: {printer.Dequeue()}");
            Console.WriteLine($"Printing: {printer.Dequeue()}");

            // point 4 
            Console.WriteLine(printer.TryDequeue(out string? s)); // ==> return false --> because Queue is empty

            #endregion

            Console.WriteLine("----------------------------------");

            #region Exercise 6: Browser History (Undo)
            // point 1 
            Stack<string> browser = new Stack<string>();
            browser.Push("google.com");
            browser.Push("github.com");
            browser.Push("stackoverflow.com");
            browser.Push("youtube.com");
            browser.Push("claude.ai");
            Console.WriteLine();

            // point 2 
            Console.WriteLine(browser.Peek());
            Console.WriteLine();

            // point 3 
            Console.WriteLine(browser.Pop());
            Console.WriteLine(browser.Pop());
            Console.WriteLine(browser.Pop());
            Console.WriteLine();

            // point 4 
            foreach (var item in browser)
            {
                Console.WriteLine(item);
            }

            // point 5 
            browser.Pop();
            browser.Pop();
            Console.WriteLine(browser.TryPop(out string? r)); // ==> return false --> because Stack is empty
            #endregion
        }
    }
}
















