namespace DataStructures
{
    public class Program
    {
        static void Main()
        {
            var stack = new CustomStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine($"Top item peek: {stack.Peek()}");

            Console.WriteLine($"Top item pop: {stack.Pop()}");

            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}