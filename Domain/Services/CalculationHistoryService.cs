using AutoMapper;
using Common.DTO;
using Infrastructure.Repositories;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class CalculationHistoryService : ICalculationHistoryService
    {
        protected readonly ICalculationHistoryRepository _repository;
        protected readonly IMapper _mapper;
        public CalculationHistoryService(ICalculationHistoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public CalculationHistoryContract Insert(CalculationHistoryContract contract)
        {
            CalculationHistoryEntity entity = _mapper.Map<CalculationHistoryEntity>(contract);
            CalculationHistoryEntity response = _repository.Insert(entity);
            return _mapper.Map<CalculationHistoryContract>(response);
        }

        public IEnumerable<CalculationHistoryContract> GetAll()
        {
            IQueryable<CalculationHistoryEntity> response = _repository.GetAll();
            return _mapper.Map<IEnumerable<CalculationHistoryContract>>(response);
        }
    }
}
