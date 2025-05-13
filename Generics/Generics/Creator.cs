namespace Generics
{
    // Commonly used with 'class' + new() OR '<interface>' + new()
    // '<interface>' + new(): Mostly used to ensure that the interface is being implemented
    public class Creator<T> where T : IConfigurable, new()
    {
        public T Create()
        {
            return new T();
        }
    }

    public interface IConfigurable
    {
        void Configure();
    }
}
