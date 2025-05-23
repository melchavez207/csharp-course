namespace ProblemSolving
{
    /// <summary>
    /// Problem
    /// Given a string containing only the characters '(' and ')', determine if the 
    /// parenthenses are balanced. So, every opening parenthesis has a corresponding closing one
    /// in the correct order.
    /// 
    /// Best data structure
    /// Stack, because you need to track the most recent opening parentheses.
    /// </summary>
    public static class BalancerProblem
    {
        public static bool IsBalanced(string input)
        {
            var stack = new Stack<char>();

            foreach (char c in input)
            {
                if (c == '(')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }
    }
}
