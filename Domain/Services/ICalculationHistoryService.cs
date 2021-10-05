using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface ICalculationHistoryService
    {
        CalculationHistoryContract Insert(CalculationHistoryContract contract);
    }
}
