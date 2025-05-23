namespace ProblemSolving.Trees
{
    /// <summary>
    /// What is a tree?
    /// A tree is a non-linear data structure, is a hierarchical data structure
    /// consisting of nodes, where each node may have a value or not.
    /// 
    /// Key points:
    /// - Root: the top node
    /// - Child: the left or right node of each node
    /// - Leaf: A node with no children
    /// - Edge: A connection between one node and another
    /// - Subtree: We can grab a sub tree
    /// 
    /// When it is neeeded?
    /// - When we need a hiearachical order (filesystem, chats, charts)
    /// - When we need to store sorted data for quick access.
    /// - When we need to implement database indexes
    /// - When we need to create compilers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public TreeNode<T>? Left { get; set; } = null;
        public TreeNode<T>? Right { get; set; } = null;

        public TreeNode(T value)
        {
            Value = value;
        }
    }
}
