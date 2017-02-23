using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VliegOp
{
    class Persoon : Lading
    {
        public Persoon(string naam)
            : base(naam, 100)
        { }
    }
}
