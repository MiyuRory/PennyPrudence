namespace PennyPrudence.Domain.Models
{
    public class BankEntity
    {
        public string Name { get; set; }
        public IEnumerable<CreditCard> CreditCards { get; set; }
    }
}
