using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyPrudence.Domain.Models
{
    public class FixedCardExpense
    {
        public DateTime DueAt { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public CreditCard CreditCard { get; set; }

        public CreditCardStatement CreditCardStatement { get; set; }



    }
}
