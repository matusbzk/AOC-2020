namespace Day02
{
    /// <summary>
    /// Represents modes of password rule validations
    /// </summary>
    public enum PasswordRuleMode
    {
        /// <summary>
        /// Password has to contain between MinCount and MaxCount instances of given letter
        /// </summary>
        LetterCount,

        /// <summary>
        /// Password has to contain given letter in exactly one of these positions: MinCount, MaxCount.
        /// Indexed from 1.
        /// </summary>
        PositionEquality
    }
}
