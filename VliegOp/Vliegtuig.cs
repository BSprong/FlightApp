using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VliegOp
{
    class Vliegtuig : Vliegmachine, IVervoertContainers, IVervoertPersonen
    {
        public Vliegtuig(int nummer, int capaciteit, decimal huurprijs)
            : base (nummer, capaciteit, huurprijs)
        { }

        public void VoegContainerToe(Container container)
        {
            Lading.Add(container);
        }

        public void VoegPersoonToe(Persoon persoon)
        {
            Lading.Add(persoon);
        }

        public override string ToString()
        {
            return "Vliegtuig " + base.ToString();
        }
    }
}
