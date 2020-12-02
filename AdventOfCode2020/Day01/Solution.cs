using Common;

namespace Day01
{
    /// <inheritdoc />
    public class Solution : ISolution
    {
        public ExpenseCalculator ExpenseCalculator;

        public void LoadInput()
        {
            ExpenseCalculator = new ExpenseCalculator(InputGetter.ReadInputLinesInt(1));
        }

        /// <inheritdoc />
        public object Part1()
        {
            return ExpenseCalculator.MultiplyNWithSum(2020);
        }

        /// <inheritdoc />
        public object Part2()
        {
            return ExpenseCalculator.MultiplyNWithSum(2020, 3);
        }
    }
}
