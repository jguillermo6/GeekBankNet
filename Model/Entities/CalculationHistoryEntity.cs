using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    [Table("CalculationHistory")]
    public class CalculationHistoryEntity
    {
        [Key]
        public int Id { get; set; }
        public int FirstValue { get; set; }
        public int SecondValue { get; set; }
        public int Result { get; set; }
    }
}
