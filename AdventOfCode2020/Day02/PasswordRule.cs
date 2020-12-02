using System;

namespace Day02
{
    /// <summary>
    /// Represents rule for a password
    /// </summary>
    public class PasswordRule
    {
        /// <summary>
        /// Letter for which this rule applies
        /// </summary>
        public char Letter { get; set; }

        /// <summary>
        /// Minimum count of letter in password
        /// </summary>
        public int MinCount { get; set; }

        /// <summary>
        /// Maximum count of letter in password
        /// </summary>
        public int MaxCount { get; set; }

        public PasswordRule(char letter, int minCount, int maxCount)
        {
            Letter = letter;
            MinCount = minCount;
            MaxCount = maxCount;
        }

        protected bool Equals(PasswordRule other)
        {
            return Letter == other.Letter && MinCount == other.MinCount && MaxCount == other.MaxCount;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PasswordRule) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Letter, MinCount, MaxCount);
        }

        public override string ToString()
        {
            return $"{MinCount}-{MaxCount} {Letter}";
        }
    }
}
