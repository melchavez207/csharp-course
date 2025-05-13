namespace Generics
{
    // Interfaces that use generic types, often for repository or services
    public interface IRepository<T>
    {
        void Add(T entity);
        T Find(int id);
    }
}
