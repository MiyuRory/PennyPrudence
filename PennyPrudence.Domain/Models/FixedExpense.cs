using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyPrudence.Domain.Models
{
    public class FixedExpense
    {
        public DateTime DueAt { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

    }
}
