using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VliegOp
{
    abstract class Lading
    {
        public string Naam { get; set; }
        public int Gewicht { get; set; }

        public Lading(string naam, int gewicht)
        {
            Naam = naam;
            Gewicht = gewicht;
        }

        public override string ToString()
        {
            return Naam + " " + Gewicht + "Kg";
        }
    }
}
