using Domain.Services;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config
{
    public class DependencyInjectionConfiguration
    {
        public static void ExecuteConfigurations(IServiceCollection services)
        {
            services.AddScoped<GeekBankDbContext, GeekBankDbContext>();

            services.AddScoped<ICalculationHistoryRepository, CalculationHistoryRepository>();
            services.AddScoped<ICalculationHistoryService, CalculationHistoryService>();
            services.AddScoped<ICalculationService, CalculationService>();

        }
    }
}
