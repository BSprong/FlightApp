using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VliegOp
{
    abstract class Vliegmachine : IComparable<Vliegmachine>
    {
        public int Nummer { get; set; }
        public int Capaciteit { get; set; }
        public decimal Huurprijs { get; set; }
        public VliegStatus Status { get; set; }
        public List<Lading> Lading { get; set; }

        public Vliegmachine(int nummer, int capaciteit, decimal huurprijs)
        {
            Nummer = nummer;
            Capaciteit = capaciteit;
            Huurprijs = huurprijs;
            Lading = new List<Lading>();
        }

        public int CompareTo(Vliegmachine other)
        {
            return Huurprijs.CompareTo(other.Huurprijs);
        }

        public override string ToString()
        {
            return Nummer + " " + Status + " " + Capaciteit + "kg " + Huurprijs.ToString("C"); 
        }
    }
}
