using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VliegOp
{
    class Helikopter : Vliegmachine, IVervoertContainers
    {
        public Helikopter(int nummer, int capaciteit, decimal huurprijs)
            : base (nummer, capaciteit, huurprijs)
        { }

        public void VoegContainerToe(Container container)
        {
            Lading.Add(container);
        }

        public override string ToString()
        {
            return "Helicopter " + base.ToString();
        }
    }
}
