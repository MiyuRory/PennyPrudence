using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyPrudence.Domain.Models
{
    public class User
    {
        public string? UserName { get; set; }

        public List<BankEntity>? BankEntities { get; set; }

        public List<FixedCardExpense>? FixedCardExpenses { get; set; }
        public List<FixedExpense>? FixedExpenses { get; set; }

        public decimal? GetFixedExpenses => FixedExpenses?.Select(z=>z.Amount).Sum();
        public decimal? GetFixedCardExpenses => FixedCardExpenses?.Select(z=>z.Amount).Sum();
        public decimal? GetTotalFixedExpenses => GetFixedExpenses + GetFixedCardExpenses;

        public List<PaymentPlan>? PaymentPlans => BankEntities?.SelectMany(n => n.PaymentPlans).ToList();
    }
}
