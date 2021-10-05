using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface ICalculationHistoryRepository
    {
        CalculationHistoryEntity Insert(CalculationHistoryEntity entity);
        IQueryable<CalculationHistoryEntity> GetAll();
    }
}
