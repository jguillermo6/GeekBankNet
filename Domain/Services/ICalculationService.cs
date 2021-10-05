using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface ICalculationService
    {        
        CalculationResultContract SumIsFibonacciSequence(CalculationContract contract);
    }
}
