using AutoMapper;
using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class CalculationService : ICalculationService
    {
        private IEnumerable<int> _fibonacciSequence { get; set; }
        public IEnumerable<int> FibonacciSequence
        {
            get
            {
                if (_fibonacciSequence == null)
                {
                    _fibonacciSequence = GenerateFibonacciSequence();
                }

                return _fibonacciSequence;
            }
        }

        protected readonly ICalculationHistoryService _calculationHistoryService;
        protected readonly IMapper _mapper;

        public CalculationService(ICalculationHistoryService calculationHistoryService, IMapper mapper)
        {
            _calculationHistoryService = calculationHistoryService;
            _mapper = mapper;
        }

        public CalculationResultContract SumIsFibonacciSequence(CalculationContract contract)
        {
            CalculationResultContract result = new CalculationResultContract();
            result.Result = Sum(contract.FirstValue, contract.SecondValue);
            result.IsFibonacciSequence = FibonacciSequence.Any(p => p == result.Result);

            SaveHistory(contract, result.Result);

            return result;
        }

        private int Sum(int firstValue, int secondValue)
        {
            return firstValue + secondValue;
        }

        private IEnumerable<int> GenerateFibonacciSequence()
        {
            int mainValue = 0;
            int sumValue = 1;
            List<int> result = new List<int>();
            while (mainValue <= 100)
            {
                int mainValueTemporal = mainValue;
                result.Add(mainValue);                
                mainValue = sumValue;
                sumValue = mainValueTemporal + sumValue;
            }

            return result;
        }

        private void SaveHistory(CalculationContract contract, int sumResult)
        {
            CalculationHistoryContract calculationHistoryContract = _mapper.Map<CalculationHistoryContract>(contract);
            calculationHistoryContract.Result = sumResult;
            _calculationHistoryService.Insert(calculationHistoryContract);
        }

    }
}
