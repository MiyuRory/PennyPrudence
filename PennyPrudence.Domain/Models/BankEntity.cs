namespace PennyPrudence.Domain.Models
{
    public class BankEntity
    {
        public string Name { get; set; }
        public List<CreditCard> CreditCards { get; set; } = [];

        public List<PaymentPlan>? PaymentPlans => CreditCards?.SelectMany(n => n.PaymentPlans).ToList();
    }
}
