using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyPrudence.Domain.Models
{
    public class CreditCardStatement
    {
        public DateTime LastClose { get; set; }
        public DateTime NextClose { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Total { get; set; }
        public decimal Minimum { get; set; }
        public CreditCard? CreditCard { get; set; }
        public List<Installment>? Installments { get; set; }

        public decimal? GetTotalInstallments => Installments == null ? null : Installments.Sum(n => n.Amount);
        public decimal? GetConsumesWithoutInstallments => Installments == null ? Total : Total - GetTotalInstallments;
    }
}
