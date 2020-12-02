using System;

namespace SolutionGetter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter day: ");
            var day = LoadDay();
            var worker = new Worker(day);
            worker.PrintSolution();
        }

        public static int LoadDay()
        {
            do
            {
                var line = Console.ReadLine();
                if (int.TryParse(line, out var parsed) && parsed >= 1 && parsed <= 25)
                {
                    return parsed;
                }

                Console.Write("Please enter number between 1 and 25: ");
            } while (true);
        }

    }
}
