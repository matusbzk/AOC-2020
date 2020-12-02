using Day01;
using NUnit.Framework;

namespace Day01Tests
{
    public class ExpenseCalculatorTests
    {
        [Test]
        public void FindNWithSum_GivenInvalidSum_ReturnsNull()
        {
            var calculator = new ExpenseCalculator(new[] { 1721, 979, 366, 299, 675, 1456 });

            var result = calculator.FindNWithSum(2021);

            Assert.IsNull(result);
        }

        [Test]
        public void FindNWithSum_GivenValidSumForThree_ReturnsTwoWithSum()
        {
            var calculator = new ExpenseCalculator(new[] {1721, 979, 366, 299, 675, 1456});

            var result = calculator.FindNWithSum(2020);

            Assert.AreEqual(new[] {299, 1721}, result);
        }

        [Test]
        public void FindNWithSum_GivenValidSumForThree_ReturnsThreeWithSum()
        {
            var calculator = new ExpenseCalculator(new[] { 1721, 979, 366, 299, 675, 1456 });

            var result = calculator.FindNWithSum(2020, 3);

            Assert.AreEqual(new[] { 366, 675, 979 }, result);
        }

        [Test]
        public void MultiplyNWithSum_GivenValidSumForTwo_ReturnsCorrectProduct()
        {
            var calculator = new ExpenseCalculator(new[] { 1721, 979, 366, 299, 675, 1456 });

            var result = calculator.MultiplyNWithSum(2020);

            Assert.AreEqual(514579, result);
        }

        [Test]
        public void MultiplyNWithSum_GivenValidSumForThree_ReturnsCorrectProduct()
        {
            var calculator = new ExpenseCalculator(new[] { 1721, 979, 366, 299, 675, 1456 });

            var result = calculator.MultiplyNWithSum(2020, 3);

            Assert.AreEqual(241861950, result);
        }
    }
}
