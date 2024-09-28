using Tutorial_OnionCQRS.Application.Interfaces.Repositories;
using Tutorial_OnionCQRS.Domain.Common;
using Tutorial_OnionCQRS.Persistince.Context;
using Microsoft.EntityFrameworkCore;

namespace Tutorial_OnionCQRS.Persistince.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext dbContext;
        public GenericRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await dbContext.Set<T>().ToListAsync();
        }    

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }

    }
}
