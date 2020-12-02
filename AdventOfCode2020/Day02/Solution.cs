using System.Linq;
using Common;

namespace Day02
{
    /// <inheritdoc />
    public class Solution : ISolution
    {
        private PasswordValidator validator;

        /// <inheritdoc />
        public void LoadInput()
        {
            validator = new PasswordValidator(InputGetter.ReadInputLines(2).Select(InputParser.ParseValidation));
        }

        /// <inheritdoc />
        public object Part1()
        {
            return validator.ValidCount();
        }

        /// <inheritdoc />
        public object Part2()
        {
            return validator.ValidCount(PasswordRuleMode.PositionEquality);
        }
    }
}
