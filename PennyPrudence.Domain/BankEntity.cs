namespace PennyPrudence.Domain
{
    public class BankEntity
    {
        public string Name { get; set; }
        public IEnumerable<Card> Cards { get; set; }
    }
}
