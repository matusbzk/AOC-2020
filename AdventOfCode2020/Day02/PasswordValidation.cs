using System;
using System.Linq;

namespace Day02
{
    /// <summary>
    /// Represents validation of password rule over specific password
    /// </summary>
    public class PasswordValidation
    {
        public PasswordRule Rule { get; set; }
        public string Password { get; set; }

        public PasswordValidation(PasswordRule rule, string password)
        {
            Rule = rule ?? throw new ArgumentNullException(nameof(rule));
            Password = password ?? throw new ArgumentNullException(nameof(password)); ;
        }

        /// <summary>
        /// Checks whether given password satisfies the rule
        /// </summary>
        /// <param name="mode">Mode of password rule validation</param>
        /// <returns>True if password satisfies the rule, false otherwise</returns>
        public bool IsValid(PasswordRuleMode mode = PasswordRuleMode.LetterCount)
        {
            return mode switch
            {
                PasswordRuleMode.LetterCount => IsValidLetterCount(),
                PasswordRuleMode.PositionEquality => IsValidPositionEquality(),
                _ => throw new ArgumentException(nameof(mode))
            };
        }

        protected bool Equals(PasswordValidation other)
        {
            return Equals(Rule, other.Rule) && Password == other.Password;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PasswordValidation) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Rule, Password);
        }

        public override string ToString()
        {
            return $"{Rule.MinCount}-{Rule.MaxCount} {Rule.Letter}: {Password}";
        }

        private bool IsValidLetterCount()
        {
            var count = Password.Count(c => c == Rule.Letter);

            return count >= Rule.MinCount && count <= Rule.MaxCount;
        }

        private bool IsValidPositionEquality() =>
            Password.Length >= Rule.MaxCount &&
            Password[Rule.MinCount - 1] == Rule.Letter ^ Password[Rule.MaxCount - 1] == Rule.Letter;
    }
}
