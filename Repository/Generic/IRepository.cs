using RepositoryPatternExample.Models;

namespace RepositoryPatternExample.Repository.Generic
{
    public interface IRepository <T> where T : class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T id);
    }
}
