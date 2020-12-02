using System;
using System.Collections.Generic;
using System.Linq;

namespace Day02
{
    /// <summary>
    /// Represents a set of password validations and performs required operations
    /// </summary>
    public class PasswordValidator
    {
        public IEnumerable<PasswordValidation> PasswordValidations { get; set; }

        public PasswordValidator(IEnumerable<PasswordValidation> passwordValidations)
        {
            PasswordValidations = passwordValidations ?? throw  new ArgumentNullException(nameof(passwordValidations));
        }

        /// <summary>
        /// Returns the number of valid passwords
        /// </summary>
        /// <param name="mode">Mode of password rule validation</param>
        /// <returns>Number of valid passwords</returns>
        public int ValidCount(PasswordRuleMode mode = PasswordRuleMode.LetterCount)
        {
            return PasswordValidations.Count(v => v.IsValid(mode));
        }
    }
}
