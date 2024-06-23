using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyPrudence.Domain.Models
{
    public class PaymentPlan
    {
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal TotalAmount { get; set; }

        public int Number { get; set; }

        public List<Installment> Installments { get; set; } = [];

        public void FillInstallments()
        {
            Installment firstInstallment = new();
            Installment next = firstInstallment;
            for (int i = 0; i < Number; i++)
            {
                if (i == 0)
                {
                    firstInstallment.DueAt = CreatedAt;
                    firstInstallment.PaymentPlan = this;
                    firstInstallment.Amount = TotalAmount / Number;
                }
                else
                {
                    next.NextInstallment = next.GetNextInstallment;
                    next = next.NextInstallment;
                }
            }
        }

        public bool IsValid => Installments?.Select(n => n.Amount).Sum() == TotalAmount;

        public decimal GetTotalFromInstallments => Installments.Select(n=>n.Amount).Sum();



    }
}
