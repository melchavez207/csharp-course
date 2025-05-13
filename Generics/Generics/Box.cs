namespace Generics
{
    // A class that works with any data type.
    // The genric argument can be called whatever you want e.g. T
    public class Box<T>
    {
        public T Value { get; set; }
    }
}
