using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyPrudence.Domain
{
    internal class Resumen : IMovementsSource
    {
        public DateTime LastClose { get; set; }
        public DateTime NextClose { get; set; }
        public DateTime DueDate { get; set; }

        public decimal Total {  get; set; }
        public decimal Minimum { get; set; }
        public Card? Card { get; set; }





        public IEnumerable<Movement>? Movements { get; set; }
    }
}
