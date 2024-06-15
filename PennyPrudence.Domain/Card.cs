using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyPrudence.Domain
{
    public class Card : IMovementsSource
    {
        public string? Name { get; set; }

        public IEnumerable<Movement>? Movements { get; set; }

    }
}
