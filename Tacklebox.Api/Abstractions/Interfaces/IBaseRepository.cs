using LiteDB;

namespace Tacklebox.Api.Persistence.Database;

public interface IBaseRepository<T>
{
    public BsonValue Insert(T entity);
    public bool Update(T entity);
    public bool Delete(int id);
    public T Find(int id);
    public IEnumerable<T> FindAll();
}