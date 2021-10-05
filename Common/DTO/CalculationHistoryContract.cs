using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    public class CalculationHistoryContract : CalculationContract
    {
        public int Id { get; set; }        
        public int Result { get; set; }
    }
}
