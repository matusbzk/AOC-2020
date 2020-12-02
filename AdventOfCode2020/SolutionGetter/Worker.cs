using System;
using Common;

namespace SolutionGetter
{
    internal class Worker
    {
        public ISolution Solution;

        public Worker(int day)
        {
            if (day < 1 || day > 25)
            {
                throw new ArgumentException("Day must be between 1 and 25", nameof(day));
            }

            Solution = SolutionGetter.GetSolution(day);
            Solution.LoadInput();
        }

        public void PrintSolution()
        {
            PrintPart1();
            PrintPart2();
        }

        private void PrintPart1()
        {
            try
            {
                var result = Solution.Part1String();
                Console.WriteLine($"Part 1: {result}");
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Part 1 is not finished yet.");
            }
        }

        private void PrintPart2()
        {
            try
            {
                var result = Solution.Part2String();
                Console.WriteLine($"Part 2: {result}");
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Part 2 is not finished yet.");
            }
        }
    }
}
