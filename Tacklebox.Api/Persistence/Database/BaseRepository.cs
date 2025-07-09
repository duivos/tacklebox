using LiteDB;

namespace Tacklebox.Api.Persistence.Database;

public abstract class BaseRepository<T> : IBaseRepository<T>
{
    private ILiteDatabase Database { get; }
    private ILiteCollection<T> Collection { get; }

    protected BaseRepository(ILiteDatabase database)
    {
        Database = database;
        Collection = Database.GetCollection<T>();
    }

    public BsonValue Insert(T entity)
    {
        return Collection.Insert(entity);
    }
    
    public bool Update(T entity)
    {
        return Collection.Update(entity);
    }

    public bool Delete(int id)
    {
        return Collection.Delete(id);   
    }

    public T Find(int id)
    {
        return Collection.FindById(id);  
    }

    public IEnumerable<T> FindAll()
    {
        return Collection.FindAll();
    }
}