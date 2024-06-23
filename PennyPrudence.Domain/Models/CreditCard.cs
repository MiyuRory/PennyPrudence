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

        public BankEntity Bank { get; set; }

        public List<CreditCardStatement>? CreditCardStatements { get; set; } = [];

        public List<PaymentPlan>? PaymentPlans { get; set; } = [];


        public List<FixedCardExpense>? FixedCardsExpenses { get; set; } = [];

        public CreditCardStatement? GetLastStatement => CreditCardStatements?.OrderByDescending(n => n.DueDate).FirstOrDefault();


    }
}
