using Tutorial_OnionCQRS.Domain.Common;

namespace Tutorial_OnionCQRS.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T :  BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> AddAsync(T entity);
    }
}
