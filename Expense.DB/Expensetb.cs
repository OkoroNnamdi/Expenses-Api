using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense.DB
{
    public  class Expensetb
    {
        [Key]
        public int Id { get; set; }
        public string? Description { get;set; }
        public double Amount { get; set; }
    }
}
