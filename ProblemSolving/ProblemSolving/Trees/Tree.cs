namespace ProblemSolving.Trees
{
    public class Tree
    {
        public static void Preorder<T>(TreeNode<T>? node)
        {
            if (node == null)
            {
                return;
            }

            Console.WriteLine(node.Value);
            Preorder(node.Right);
            Preorder(node.Left);
        }

        public static void Inorder<T>(TreeNode<T>? node)
        {
            if (node == null)
            {
                return;
            }

            Preorder(node.Right);
            Console.WriteLine(node.Value);
            Preorder(node.Left);
        }

        public static void Postorder<T>(TreeNode<T>? node)
        {
            if (node == null)
            {
                return;
            }

            Preorder(node.Right);
            Preorder(node.Left);
            Console.WriteLine(node.Value);
        }
    }
}
