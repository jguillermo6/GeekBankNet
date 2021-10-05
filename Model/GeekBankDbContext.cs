using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GeekBankDbContext : DbContext
    {
        protected IConfiguration _configuration { get; }

        public virtual DbSet<CalculationHistoryEntity> CalculationHistories { get; set; }

        public GeekBankDbContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}
