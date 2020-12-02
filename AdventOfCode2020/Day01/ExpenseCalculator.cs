using System;
using System.Collections.Generic;
using System.Linq;

namespace Day01
{
    /// <summary>
    /// Handles operations with list of numbers
    /// </summary>
    public class ExpenseCalculator
    {
        public List<int> SortedNumbers;

        public ExpenseCalculator(IEnumerable<int> integers)
        {
            SortedNumbers = integers.OrderBy(i => i).ToList();
        }

        /// <summary>
        /// Finds N numbers with given sum and multiplies them
        /// </summary>
        /// <param name="sum">Expected sum</param>
        /// <param name="count">Number of elements to find</param>
        /// <returns>Product of N numbers with given sum</returns>
        public int MultiplyNWithSum(int sum, int count = 2) => FindNWithSum(sum, count).Aggregate(1, (acc, val) => acc * val);

        /// <summary>
        /// Find N numbers with expected sum
        /// </summary>
        /// <param name="sum">Expected sum</param>
        /// <param name="count">Number of elements to find</param>
        /// <returns>N numbers whose sum is equal to expected sum, ordered by smaller ones first</returns>
        public int[] FindNWithSum(int sum, int count = 2)
        {
            if (count < 1)
            {
                throw new ArgumentException("Count must be at least 1", nameof(count));
            }

            if (SortedNumbers.Count < count)
            {
                return null;
            }

            if (count == 1)
            {
                return SortedNumbers.Contains(sum) ? new[] {sum} : null;
            }

            var calculatorWithoutFirst = new ExpenseCalculator(SortedNumbers.Skip(1));

            var setIfFirstIsThere = calculatorWithoutFirst.FindNWithSum(sum - SortedNumbers.First(), count - 1);
            if (setIfFirstIsThere != null)
            {
                // first element should be part of result
                var result = new List<int> {SortedNumbers.First() };
                result.AddRange(setIfFirstIsThere);
                return result.ToArray();
            }

            // first element should not be part of result
            return calculatorWithoutFirst.FindNWithSum(sum, count);
        }
    }
}
