using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyPrudence.Domain.Models
{
    public class CreditCard
    {
        public string? Name { get; set; }

        public IEnumerable<CreditCardStatement>? CreditCardStatements { get; set; }

        public IEnumerable<PaymentPlan>? PaymentPlans { get; set; }

    }
}
