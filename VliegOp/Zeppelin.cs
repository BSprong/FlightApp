using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VliegOp
{
    class Zeppelin : Vliegmachine, IVervoertPersonen
    {
        public Zeppelin(int nummer, int capaciteit, decimal huurprijs)
            : base (nummer, capaciteit, huurprijs)
        { }

        public void VoegPersoonToe(Persoon persoon)
        {
            Lading.Add(persoon);
        }

        public override string ToString()
        {
            return "Zeppelin " + base.ToString();
        }
    }
}
