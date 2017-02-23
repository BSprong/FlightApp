using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace VliegOp
{
    class VliegOpApp
    {
        private List<Vliegmachine> vliegmachines;
        private List<Lading> verzamellading;

        public VliegOpApp()
        {
            vliegmachines = new List<Vliegmachine>();
            verzamellading = new List<Lading>();
            VulMetDummieData();
        }

        private void VulMetDummieData()
        {
            vliegmachines.Add(new Helikopter(342, 500, 50.95m) { Status = VliegStatus.Beschikbaar });
            vliegmachines.Add(new Helikopter(1982, 400, 40.95m) { Status = VliegStatus.Beschikbaar });
            vliegmachines.Add(new Helikopter(32, 900, 120.95m) { Status = VliegStatus.Vliegt, Lading = { new Container("Kleding", 900) } });
            vliegmachines.Add(new Helikopter(1092, 800, 90.95m) { Status = VliegStatus.Beschikbaar });
            vliegmachines.Add(new Vliegtuig(1024, 60000, 950.0m) { Status = VliegStatus.Beschikbaar });
            vliegmachines.Add(new Vliegtuig(996, 50000, 850.0m) { Status = VliegStatus.Vliegt, Lading = { new Persoon("Gerard"), new Persoon("Tim"), new Container("Bier", 500) } });
            vliegmachines.Add(new Vliegtuig(911, 40000, 750.0m) { Status = VliegStatus.Beschikbaar });
            vliegmachines.Add(new Vliegtuig(344, 28000, 650.0m) { Status = VliegStatus.Vliegt, Lading = { new Persoon("Marcel"), new Persoon("Danny"), new Container("Koffiebonen", 1000) } });
            vliegmachines.Add(new Vliegtuig(992, 62000, 950.0m) { Status = VliegStatus.Beschikbaar });
            vliegmachines.Add(new Zeppelin(81, 1000, 525.95m) { Status = VliegStatus.Vliegt, Lading = { new Persoon("Bas") } });
            vliegmachines.Add(new Zeppelin(924, 1000, 525.95m) { Status = VliegStatus.Vliegt, Lading = { new Persoon("Stefan"), new Persoon("Inge"), new Persoon("Petra"), new Persoon("Martijn") } });
            vliegmachines.Add(new Zeppelin(112, 1200, 725.95m) { Status = VliegStatus.Beschikbaar });
            vliegmachines.Add(new Zeppelin(512, 1100, 625.95m) { Status = VliegStatus.Beschikbaar });
        }

        public IReadOnlyList<Vliegmachine> GeefAlleVliegmachines()
        {
            return vliegmachines.AsReadOnly();
        }

        public Vliegmachine GeefVliegmachine(int nummer)
        {
            foreach (Vliegmachine vliegmachine in vliegmachines)
            {
                if (vliegmachine.Nummer == nummer)
                {
                    return vliegmachine;
                }
            }
            return null;
        }

        public void VerzamelContainer(string naam, int gewicht)
        {
            Container container = new Container(naam, gewicht);
            verzamellading.Add(container);
        }

        public void VerzamelPersoon(string naam)
        {
            Persoon persoon = new Persoon(naam);
            verzamellading.Add(persoon);
        }

        public IReadOnlyList<Container> GeefVerzameldeContainers()
        {
            List<Container> containers = new List<Container>();
            foreach (Lading lading in verzamellading)
            {
                if (lading is Container)
                {
                    containers.Add(lading as Container);
                }
            }
            containers.Sort();
            return containers;
        }

        public IReadOnlyList<Persoon> GeefVerzameldePersonen()
        {
            List<Persoon> personen = new List<Persoon>();
            foreach (Lading lading in verzamellading)
            {
                if (lading is Persoon)
                {
                    personen.Add(lading as Persoon);
                }
            }
            personen.Sort();
            return personen;
        }

        public Toekenresultaat KenVliegmachineToe(int nummer)
        {
            Vliegmachine vliegmachine = GeefVliegmachine(nummer);
            if (vliegmachine == null)
            {
                return Toekenresultaat.NummerOngeldig;
            }

            if (vliegmachine.Status != VliegStatus.Beschikbaar)
            {
                return Toekenresultaat.StatusOngeldig;
            }

            int totaalGewicht = 0;
            foreach (Lading lading in verzamellading)
            {
                totaalGewicht += lading.Gewicht;
            }
            if (totaalGewicht > vliegmachine.Capaciteit)
            {
                return Toekenresultaat.LadingOngeldig;
            }

            IReadOnlyList<Container> verzameldeContainers = GeefVerzameldeContainers();
            if (verzameldeContainers.Count > 0)
            {
                if (!(vliegmachine is IVervoertContainers))
                {
                    return Toekenresultaat.LadingOngeldig;
                }
                IVervoertContainers containerVervoerder = vliegmachine as IVervoertContainers;
                foreach (Container container in verzameldeContainers)
                {
                    containerVervoerder.VoegContainerToe(container);
                }
            }

            IReadOnlyList<Persoon> verzameldePersonen = GeefVerzameldePersonen();
            if (verzameldePersonen.Count > 0)
            {
                if (!(vliegmachine is IVervoertPersonen))
                {
                    return Toekenresultaat.LadingOngeldig;
                }
                IVervoertPersonen personenVervoerder = vliegmachine as IVervoertPersonen;
                foreach (Persoon persoon in verzameldePersonen)
                {
                    personenVervoerder.VoegPersoonToe(persoon);
                }
            }

            verzamellading.Clear();
            vliegmachine.Status = VliegStatus.Vliegt;
            return Toekenresultaat.Gelukt;
        }

        public void ExporteerVluchtenLijst(string bestandsnaam)
        {
            using (StreamWriter writer = new StreamWriter(bestandsnaam))
            {
                foreach (Vliegmachine vliegmachine in vliegmachines)
                {
                    if (vliegmachine.Status == VliegStatus.Vliegt)
                    {
                        writer.WriteLine(vliegmachine.ToString());
                    }
                }
            }
        }

        public int KenAutomatischToe()
        {
            vliegmachines.Sort();
            foreach (Vliegmachine vliegmachine in vliegmachines)
            {
                if (KenVliegmachineToe(vliegmachine.Nummer) == Toekenresultaat.Gelukt)
                {
                    return vliegmachine.Nummer;
                }
            }
            return 0;
        }
    }
}
