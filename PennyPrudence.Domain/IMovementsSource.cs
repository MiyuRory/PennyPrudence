using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyPrudence.Domain
{
    public interface IMovementsSource
    {
        public IEnumerable<Movement>? Movements { get; set; }
    }
}
