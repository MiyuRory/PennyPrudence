using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyPrudence.Domain.Models
{
    public class Installment
    {
        public DateTime DueAt { get; set; }
        public decimal Amount { get; set; }

        public string? Description => PaymentPlan?.Description;

        public bool AppearsInStatement { get; set; }
        public Installment? NextInstallment { get; set; }

        public bool IsLast => NextInstallment == null;

        public PaymentPlan? PaymentPlan { get; set; }
        public CreditCardStatement? CreditCardStatement { get; set; }

        public Installment GetNextInstallment => new Installment { Amount = this.Amount, DueAt = this.DueAt.AddMonths(1), PaymentPlan = this.PaymentPlan };

    }
}
