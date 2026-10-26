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
        }
    }
}

