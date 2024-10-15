using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sysdatec.PruebaTecnica.Application.DataBase;
using Sysdatec.PruebaTecnica.Persistence.DataBase;

namespace Sysdatec.PruebaTecnica.Persistence
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services,
                        IConfiguration configuration)
        {
            //Se movió desde program
            services.AddDbContext<DataBaseService>(options =>
            options.UseSqlServer(configuration.GetConnectionString("SqlServer")));

            services.AddScoped<IDataBaseService, DataBaseService>();

            return services;
        }
    }
}
