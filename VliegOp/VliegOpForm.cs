using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VliegOp
{
    public partial class VliegOpForm : Form
    {
        VliegOpApp app;

        public VliegOpForm()
        {
            InitializeComponent();
            app = new VliegOpApp();
            VerversLijsten();
        }

        public void VerversLijsten()
        {
            lbAlleVliegmachines.Items.Clear();
            foreach (Vliegmachine vliegmachine in app.GeefAlleVliegmachines())
            {
                lbAlleVliegmachines.Items.Add(vliegmachine);
            }
            lbContainers.Items.Clear();
            foreach (Container container in app.GeefVerzameldeContainers())
            {
                lbContainers.Items.Add(container);
            }
            lbPersonen.Items.Clear();
            foreach (Persoon persoon in app.GeefVerzameldePersonen())
            {
                lbPersonen.Items.Add(persoon);
            }
        }

        private void btnVoegLadingToe_Click(object sender, EventArgs e)
        {
            string naam = txtNaam.Text;
            if (string.IsNullOrEmpty(naam))
            {
                MessageBox.Show("Je dient een naam in te voeren.");
                return;
            }

            if (rbPersoon.Checked)
            {
                app.VerzamelPersoon(naam);
            }
            else if (rbContainer.Checked)
            {
                int gewicht;
                if (!int.TryParse(txtGewicht.Text, out gewicht) || gewicht <= 0)
                {
                    MessageBox.Show("Gewicht dient een positieve waarde in gehele Kg te zijn.");
                    return;
                }
                app.VerzamelContainer(naam, gewicht);
            }

            txtNaam.Clear();
            txtGewicht.Clear();
            VerversLijsten();
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            txtGewicht.Enabled = rbContainer.Checked;
            if (!txtGewicht.Enabled)
            {
                txtGewicht.Clear();
            }
        }

        private void btnOpzoeken_Click(object sender, EventArgs e)
        {
            int nummer;
            if (!int.TryParse(txtOpzoeknummer.Text, out nummer))
            {
                MessageBox.Show("Je dient een geldig nummer op te geven.");
                return;
            }

            Vliegmachine vliegmachine = app.GeefVliegmachine(nummer);
            if (vliegmachine == null)
            {
                MessageBox.Show("Er is geen vliegmachine met dat nummer.");
                return;
            }

            txtInformatie.Text = vliegmachine.ToString();

            lbLading.Items.Clear();
            foreach (Lading lading in vliegmachine.Lading)
            {
                lbLading.Items.Add(lading);
            }
        }

        private void btnToekennen_Click(object sender, EventArgs e)
        {
            int nummer;
            if (!int.TryParse(txtToekennummer.Text, out nummer))
            {
                MessageBox.Show("Je dient een geldig nummer op te geven.");
                return;
            }

            Toekenresultaat resultaat = app.KenVliegmachineToe(nummer);
            switch (resultaat)
            {
                case Toekenresultaat.NummerOngeldig: 
                    MessageBox.Show("Er is geen vliegmachine met dat nummer."); 
                    break;
                case Toekenresultaat.StatusOngeldig:
                    MessageBox.Show("Deze vliegmachine is niet beschikbaar.");
                    break;
                case Toekenresultaat.LadingOngeldig: 
                    MessageBox.Show("Deze vliegmachine is niet geschikt voor de lading."); 
                    break;
                case Toekenresultaat.Gelukt: 
                    MessageBox.Show("De vliegmachine is toegekend en vertrokken."); 
                    break;
            }
            VerversLijsten();
        }

        private void btnAutomatischToekennen_Click(object sender, EventArgs e)
        {
            int nummer = app.KenAutomatischToe();
            if (nummer > 0)
            {
                MessageBox.Show("Toegekend aan vliegmachine " + nummer);
            }
            else
            {
                MessageBox.Show("De lading kon niet toegekend worden.");
            }
            VerversLijsten();
        }

        private void btnExporteerVluchten_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                app.ExporteerVluchtenLijst(dialog.FileName);
            }
        }
    }
}
