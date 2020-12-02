using Day02;
using NUnit.Framework;

namespace Day02Tests
{
    public class PasswordValidationTests
    {
        [TestCase('a', 1, 3, "abcde", true)]
        [TestCase('b', 1, 3, "cdefg", false)]
        [TestCase('c', 2, 9, "ccccccccc", true)]
        public void IsValid_GivenLetterCountMode_ReturnsCorrectResult(char letter, int min, int max, string password, bool expectedResult)
        {
            var validation = new PasswordValidation(new PasswordRule(letter, min, max), password);

            var result = validation.IsValid();

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase('a', 1, 3, "abcde", true)]
        [TestCase('b', 1, 3, "cdefg", false)]
        [TestCase('c', 2, 9, "ccccccccc", false)]
        public void IsValid_GivenPositionEqualityMode_ReturnsCorrectResult(char letter, int min, int max, string password, bool expectedResult)
        {
            var validation = new PasswordValidation(new PasswordRule(letter, min, max), password);

            var result = validation.IsValid(PasswordRuleMode.PositionEquality);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
