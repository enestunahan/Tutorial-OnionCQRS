using Tutorial_OnionCQRS.Application.Interfaces.Repositories;
using Tutorial_OnionCQRS.Domain.Entities;
using Tutorial_OnionCQRS.Persistince.Context;

namespace Tutorial_OnionCQRS.Persistince.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
