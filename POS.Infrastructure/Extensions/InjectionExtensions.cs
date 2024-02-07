using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using POS.Infrastructure.Persistences.Contexts;
using POS.Infrastructure.Persistences.Interfaces;
using POS.Infrastructure.Persistences.Repositories;

namespace POS.Infrastructure.Extensions
{
    public static class InjectionExtensions
    {   
        public static IServiceCollection AddInjectionInfraestructure(this IServiceCollection service, IConfiguration Configuration)
        {
            var assembly = typeof(PosContext).Assembly.FullName;

            service.AddDbContext<PosContext>(
               Options => Options.UseSqlServer(
                   Configuration.GetConnectionString("POSconection"), b => b.MigrationsAssembly(assembly)), ServiceLifetime.Transient);

            service.AddTransient<IUnitOfWork, UniOfWork>();  
            return service;
        }   
    }
}
