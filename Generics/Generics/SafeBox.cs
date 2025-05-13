namespace Generics
{
    // Generics do not prevent nulls by default, but you can combine them with constraints and nullable reference type.
    public class SafeBox<T> where T : notnull
    {
        public T Value { get; set; }

        public SafeBox(T value)
        {
            Value = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}
