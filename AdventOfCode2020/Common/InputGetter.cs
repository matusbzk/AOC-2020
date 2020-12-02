using System;
using System.IO;
using System.Linq;

namespace Common
{
    /// <summary>
    /// Reads input from DayXX/data/input.txt
    /// </summary>
    public static class InputGetter
    {
        /// <summary>
        /// Reads input as an array of lines
        /// </summary>
        /// <param name="day">Day</param>
        /// <returns>Input as an array of lines</returns>
        public static string[] ReadInputLines(int day)
        {
            if (day < 1 || day > 25)
            {
                throw new ArgumentException("Day must be between 1 and 25", nameof(day));
            }

            return File.ReadAllLines(GetInputPath(day));
        }

        /// <summary>
        /// Reads input as an array of lines, where each line contains int
        /// </summary>
        /// <param name="day">Day</param>
        /// <returns>Input as an array of integers</returns>
        public static int[] ReadInputLinesInt(int day) => ReadInputLines(day).Select(int.Parse).ToArray();

        /// <summary>
        /// Reads first line of input
        /// </summary>
        /// <param name="day">Day</param>
        /// <returns>First line of input</returns>
        public static string ReadInputLine(int day) => ReadInputLines(day).First();

        /// <summary>
        /// Path to input file for given day
        /// </summary>
        /// <param name="day">Day</param>
        private static string GetInputPath(int day) => $"..\\..\\..\\..\\Day{day:D2}\\data\\input.txt";
    }
}
