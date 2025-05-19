namespace DataStructures
{
    /// <summary>
    /// Problem:
    /// You are building a simple text editor. The user can type character,
    /// and there is also an undo button that removes the last typed character.
    /// Implement a system that handles the typing and undo functionality
    /// efficiently
    /// 
    /// Input:
    /// Output:
    /// 
    /// Best data structure:
    /// stack: because it follows LIFO, and it is ideal for undo operations.
    /// </summary>
    public class TextEditorProblem
    {
        private readonly CustomStack<char> _textStack = new();

        public void Type(char c)
        {
            _textStack.Push(c);
        }

        public void Undo()
        {
            if (_textStack.Count > 0)
            {
                _textStack.Pop();
            }
        }

        public string GetText()
        {
            return new string([.. _textStack.ToArray().Reverse()]);
        }
    }
}
