using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tutorial_OnionCQRS.Application.Interfaces.Repositories;
using Tutorial_OnionCQRS.Persistince.Context;
using Tutorial_OnionCQRS.Persistince.Repositories;

namespace Tutorial_OnionCQRS.Persistince
{
    public static class ServiceRegistration
    {
        public static void AddPersistinceRegistration(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
            {
                opt.UseInMemoryDatabase("memoryDb");
            });

            services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
