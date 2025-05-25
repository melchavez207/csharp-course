namespace DataStructures
{
    // FIFO
    public class CustomQueue<T>
    {
        // TODO: Implement queue (you can modify the implementation, not the names of the methods)
        private class Node
        {
            public T Value { get; set; }
            public Node? Next { get; set; } = null!;

            public Node(T value)
            {
                Value = value;
            }
        }

        private Node? _front;
        private Node? _back;
        private int _count = 0;

        public int Count => _count;

        public void Enqueue(T item)
        {

            var newNode = new Node(item);

            if (_back == null)
            {
                _front = _back = newNode;
            }
            else
            {
                _back.Next = newNode;
                _back = newNode;
            }

            _count++;
        }

        public T Dequeue()
        {
            // remove items
            if (_front == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T value = _front.Value;
            _front = _front.Next;
            _count--;

            return value;
        }

        public T Peek()
        {
            // Peek items

            if (_front == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return _front.Value;
        }

        public bool IsEmpty() => _front == null;

        public T[] ToArray()
        {
            var result = new T[_count];
            var current = _front;

            for (int i = 0; i < _count; i++)
            {
                result[i] = current!.Value;
                current = current.Next;
            }

            return result;
        }
    }
}
