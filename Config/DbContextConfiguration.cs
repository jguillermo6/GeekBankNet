using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Model;

namespace Config
{
    public class DbContextConfiguration
    {
        public static void ExecuteConfigurations(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GeekBankDbContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("GeekBankConnection"));                
            });
        }
    }
}
