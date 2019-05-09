using System.Linq;
using MyShop.Core.Infrastructure.Abstract;

namespace MyShop.DataAccess.InMemory
{
    public interface IInMemoryRepository<T> where T : BaseEntity
    {
        IQueryable<T> Collection();
        void Commit();
        void Delete(T t);
        T Find(string Id);
        void Insert(T t);
        void Update(T t);
    }
}