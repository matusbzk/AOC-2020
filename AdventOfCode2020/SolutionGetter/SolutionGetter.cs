using System;
using Common;

namespace SolutionGetter
{
    public static class SolutionGetter
    {
        /// <summary>
        /// Gets solution for given day
        /// </summary>
        /// <param name="day">Day</param>
        /// <remarks>Yes, it is ugly...</remarks>
        public static ISolution GetSolution(int day)
        {
            return day switch
            {
                1 => new Day01.Solution(),
                2 => new Day02.Solution(),
                3 => new Day03.Solution(),
                4 => new Day04.Solution(),
                5 => new Day05.Solution(),
                6 => new Day06.Solution(),
                7 => new Day07.Solution(),
                8 => new Day08.Solution(),
                9 => new Day09.Solution(),
                10 => new Day10.Solution(),
                11 => new Day11.Solution(),
                12 => new Day12.Solution(),
                13 => new Day13.Solution(),
                14 => new Day14.Solution(),
                15 => new Day15.Solution(),
                16 => new Day16.Solution(),
                17 => new Day17.Solution(),
                18 => new Day18.Solution(),
                19 => new Day19.Solution(),
                20 => new Day20.Solution(),
                21 => new Day21.Solution(),
                22 => new Day22.Solution(),
                23 => new Day23.Solution(),
                24 => new Day24.Solution(),
                25 => new Day25.Solution(),
                _ => throw new ArgumentException("Day must be between 1 and 25", nameof(day))
            };
        }
    }
}
