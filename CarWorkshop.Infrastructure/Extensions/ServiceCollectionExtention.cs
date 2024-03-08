using CarWorkshop.Infrastructure.Persistence;
using CarWorkshop.Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Infrastructure.Extensions
{
    public static class ServiceCollectionExtention
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration )
        {
            services.AddDbContext<CarWorkshopDbContext>(options => options.UseSqlServer(
              configuration.GetConnectionString("CarWorkshop")));

            services.AddScoped<CarWorkshopSeeder>();
        }
    }
}
