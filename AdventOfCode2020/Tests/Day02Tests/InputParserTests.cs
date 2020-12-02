using Day02;
using NUnit.Framework;

namespace Day02Tests
{
    class InputParserTests
    {
        [TestCase("1-3 a", 'a', 1, 3)]
        [TestCase("1-3 b", 'b', 1, 3)]
        [TestCase("2-9 c", 'c', 2, 9)]
        public void ParseRule_GivenValidInput_ReturnsParsedRule(string input, char expectedChar, int expectedMin, int expectedMax)
        {
            var expectedResult = new PasswordRule(expectedChar, expectedMin, expectedMax);

            var result = InputParser.ParseRule(input);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase("1-3 a: abcde", 'a', 1, 3, "abcde")]
        [TestCase("1-3 b: cdefg", 'b', 1, 3, "cdefg")]
        [TestCase("2-9 c: ccccccccc", 'c', 2, 9, "ccccccccc")]
        public void ParseValidation_GivenValidInput_ReturnsParsedValidation(string input, char expectedChar, int expectedMin,
            int expectedMax, string expectedPassword)
        {
            var expectedResult =
                new PasswordValidation(new PasswordRule(expectedChar, expectedMin, expectedMax), expectedPassword);

            var result = InputParser.ParseValidation(input);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
