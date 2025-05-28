namespace ProblemSolving
{
    /// <summary>
    /// Problem:
    /// You are receiving a stream of lowercase letters, one at a time.
    /// At each step, you must report the first non-repeating character
    /// among all characters seen so far. If there is non, output "_"
    /// 
    /// Input:
    /// a a b c c d
    /// z a b d a b h
    /// Ouput:
    /// a _ b c _ d
    /// 
    /// Best data structure:
    /// - , because an array to track all frequencies is the best approach.
    /// 
    /// </summary>
    public class NonRepeatingCharacterProblem
    {
        private const int NumberOfLetters = 26;
        private readonly Queue<char> _characters = new();
        private readonly int[] _frequency = new int[NumberOfLetters];

        public char Process(char value)
        {
            int index = value - 'a';

            if (_frequency[index] > 0)
            {
                value = '_';
            }

            _frequency[index]++;

            return value;
        }
    }
}
