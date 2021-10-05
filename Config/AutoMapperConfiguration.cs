using AutoMapper;
using Common.DTO;
using Microsoft.Extensions.DependencyInjection;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config
{
    public class AutoMapperConfiguration
    {
        public static void ExecuteConfigurations(IServiceCollection services)
        {

            MapperConfiguration configMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperRegister());

            });

            IMapper mapper = configMapper.CreateMapper();
            services.AddSingleton(mapper);
        }
    }

    internal class AutoMapperRegister : Profile
    {
        public AutoMapperRegister()
        {
            CreateMap<CalculationHistoryEntity, CalculationHistoryContract>().ReverseMap();
            CreateMap<CalculationContract, CalculationHistoryContract>().ReverseMap();            
        }
    }
}
