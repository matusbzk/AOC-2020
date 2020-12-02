using Day02;
using NUnit.Framework;

namespace Day02Tests
{
    public class PasswordValidatorTests
    {
        [Test]
        public void ValidCount_GivenLetterCountMode_ReturnsCorrectNumberOfValidPasswords()
        {
            var validator = new PasswordValidator(new[]
            {
                new PasswordValidation(new PasswordRule('a', 1, 3), "abcde"),
                new PasswordValidation(new PasswordRule('b', 1, 3), "cdefg"),
                new PasswordValidation(new PasswordRule('c', 2, 9), "ccccccccc")
            });

            var result = validator.ValidCount();

            Assert.AreEqual(2, result);
        }

        [Test]
        public void ValidCount_GivenPositionEqualityMode_ReturnsCorrectNumberOfValidPasswords()
        {
            var validator = new PasswordValidator(new[]
            {
                new PasswordValidation(new PasswordRule('a', 1, 3), "abcde"),
                new PasswordValidation(new PasswordRule('b', 1, 3), "cdefg"),
                new PasswordValidation(new PasswordRule('c', 2, 9), "ccccccccc")
            });

            var result = validator.ValidCount(PasswordRuleMode.PositionEquality);

            Assert.AreEqual(1, result);
        }
    }
}
