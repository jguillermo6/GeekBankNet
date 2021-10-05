using Microsoft.EntityFrameworkCore;
using Model;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CalculationHistoryRepository : ICalculationHistoryRepository
    {
        protected readonly GeekBankDbContext _dbContext;
        protected readonly DbSet<CalculationHistoryEntity> _dbSet;

        public CalculationHistoryRepository(GeekBankDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<CalculationHistoryEntity>();
        }
        public CalculationHistoryEntity Insert(CalculationHistoryEntity entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }
    }
}
