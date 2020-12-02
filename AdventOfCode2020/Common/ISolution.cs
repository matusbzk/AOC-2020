namespace Common
{
    /// <summary>
    /// Solution of project for some day
    /// </summary>
    public interface ISolution
    {
        /// <summary>
        /// Loads input
        /// </summary>
        void LoadInput() { }

        /// <summary>
        /// Solution to first part of problem
        /// </summary>
        object Part1();

        /// <summary>
        /// Solution to second part of problem
        /// </summary>
        object Part2();

        public string Part1String() => Part1().ToString();
        public string Part2String() => Part2().ToString();
    }
}
