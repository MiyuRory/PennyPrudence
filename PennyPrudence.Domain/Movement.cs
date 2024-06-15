using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyPrudence.Domain
{
    public class Movement
    {
        public bool Direction { get; set; }

        public IMovementsSource? MovementsSource { get; set; }   
    }
}
