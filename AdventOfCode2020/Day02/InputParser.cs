using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day02
{
    /// <summary>
    /// Parses input from string to given structures
    /// </summary>
    public static class InputParser
    {
        /// <summary>
        /// Parses password validation
        /// </summary>
        /// <param name="input">Input in format "{min}-{max} {letter}: {password}"</param>
        /// <returns>Parsed password validation, null in case of invalid input</returns>
        public static PasswordValidation ParseValidation(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            var splitted = input.Split(": ");

            if (splitted.Length != 2)
            {
                return null;
            }

            return new PasswordValidation(ParseRule(splitted[0]), splitted[1].Trim());
        }

        /// <summary>
        /// Parses password rule
        /// </summary>
        /// <param name="input">Input in format "{min}-{max} {letter}"</param>
        /// <returns>Parsed password rule, null in case of invalid input</returns>
        public static PasswordRule ParseRule(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            var regex = new Regex("^(\\d+)-(\\d+) (.)");

            var groups = regex.Match(input).Groups;

            if (groups.Count < 3)
            {
                return null;
            }

            if (int.TryParse(groups[1].Value, out var min) && int.TryParse(groups[2].Value, out var max) && groups[3].Value.Length == 1)
            {
                return new PasswordRule(groups[3].Value.First(), min, max);
            }

            return null;
        }
    }
}
