namespace VliegOp
{
    partial class VliegOpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbAlleVliegmachines = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGewicht = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbContainer = new System.Windows.Forms.RadioButton();
            this.rbPersoon = new System.Windows.Forms.RadioButton();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.btnVoegLadingToe = new System.Windows.Forms.Button();
            this.lbContainers = new System.Windows.Forms.ListBox();
            this.lbPersonen = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAutomatischToekennen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtToekennummer = new System.Windows.Forms.TextBox();
            this.btnToekennen = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnOpzoeken = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInformatie = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOpzoeknummer = new System.Windows.Forms.TextBox();
            this.lbLading = new System.Windows.Forms.ListBox();
            this.btnExporteerVluchten = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbType.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbAlleVliegmachines);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alle vliegmachines";
            // 
            // lbAlleVliegmachines
            // 
            this.lbAlleVliegmachines.FormattingEnabled = true;
            this.lbAlleVliegmachines.Location = new System.Drawing.Point(6, 19);
            this.lbAlleVliegmachines.Name = "lbAlleVliegmachines";
            this.lbAlleVliegmachines.Size = new System.Drawing.Size(524, 69);
            this.lbAlleVliegmachines.TabIndex = 0;
            this.lbAlleVliegmachines.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtGewicht);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.gbType);
            this.groupBox2.Controls.Add(this.txtNaam);
            this.groupBox2.Controls.Add(this.btnVoegLadingToe);
            this.groupBox2.Controls.Add(this.lbContainers);
            this.groupBox2.Controls.Add(this.lbPersonen);
            this.groupBox2.Location = new System.Drawing.Point(182, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Verzamel een lading";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Containers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Personen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gewicht";
            // 
            // txtGewicht
            // 
            this.txtGewicht.Location = new System.Drawing.Point(12, 144);
            this.txtGewicht.Name = "txtGewicht";
            this.txtGewicht.Size = new System.Drawing.Size(113, 20);
            this.txtGewicht.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naam";
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbContainer);
            this.gbType.Controls.Add(this.rbPersoon);
            this.gbType.Location = new System.Drawing.Point(6, 19);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(164, 50);
            this.gbType.TabIndex = 4;
            this.gbType.TabStop = false;
            this.gbType.Text = "Type";
            // 
            // rbContainer
            // 
            this.rbContainer.AutoSize = true;
            this.rbContainer.Checked = true;
            this.rbContainer.Location = new System.Drawing.Point(6, 19);
            this.rbContainer.Name = "rbContainer";
            this.rbContainer.Size = new System.Drawing.Size(70, 17);
            this.rbContainer.TabIndex = 2;
            this.rbContainer.TabStop = true;
            this.rbContainer.Text = "Container";
            this.rbContainer.UseVisualStyleBackColor = true;
            this.rbContainer.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbPersoon
            // 
            this.rbPersoon.AutoSize = true;
            this.rbPersoon.Location = new System.Drawing.Point(94, 19);
            this.rbPersoon.Name = "rbPersoon";
            this.rbPersoon.Size = new System.Drawing.Size(64, 17);
            this.rbPersoon.TabIndex = 3;
            this.rbPersoon.Text = "Persoon";
            this.rbPersoon.UseVisualStyleBackColor = true;
            this.rbPersoon.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(12, 98);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(143, 20);
            this.txtNaam.TabIndex = 4;
            // 
            // btnVoegLadingToe
            // 
            this.btnVoegLadingToe.Location = new System.Drawing.Point(80, 170);
            this.btnVoegLadingToe.Name = "btnVoegLadingToe";
            this.btnVoegLadingToe.Size = new System.Drawing.Size(75, 23);
            this.btnVoegLadingToe.TabIndex = 6;
            this.btnVoegLadingToe.Text = "Voeg toe";
            this.btnVoegLadingToe.UseVisualStyleBackColor = true;
            this.btnVoegLadingToe.Click += new System.EventHandler(this.btnVoegLadingToe_Click);
            // 
            // lbContainers
            // 
            this.lbContainers.FormattingEnabled = true;
            this.lbContainers.Location = new System.Drawing.Point(176, 38);
            this.lbContainers.Name = "lbContainers";
            this.lbContainers.Size = new System.Drawing.Size(88, 160);
            this.lbContainers.TabIndex = 1;
            this.lbContainers.TabStop = false;
            // 
            // lbPersonen
            // 
            this.lbPersonen.FormattingEnabled = true;
            this.lbPersonen.Location = new System.Drawing.Point(270, 38);
            this.lbPersonen.Name = "lbPersonen";
            this.lbPersonen.Size = new System.Drawing.Size(88, 160);
            this.lbPersonen.TabIndex = 0;
            this.lbPersonen.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAutomatischToekennen);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtToekennummer);
            this.groupBox3.Controls.Add(this.btnToekennen);
            this.groupBox3.Location = new System.Drawing.Point(182, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 77);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ken een vliegmachine toe";
            // 
            // btnAutomatischToekennen
            // 
            this.btnAutomatischToekennen.Location = new System.Drawing.Point(173, 17);
            this.btnAutomatischToekennen.Name = "btnAutomatischToekennen";
            this.btnAutomatischToekennen.Size = new System.Drawing.Size(91, 51);
            this.btnAutomatischToekennen.TabIndex = 9;
            this.btnAutomatischToekennen.Text = "Ken automatisch toe";
            this.btnAutomatischToekennen.UseVisualStyleBackColor = true;
            this.btnAutomatischToekennen.Click += new System.EventHandler(this.btnAutomatischToekennen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nummer";
            // 
            // txtToekennummer
            // 
            this.txtToekennummer.Location = new System.Drawing.Point(55, 19);
            this.txtToekennummer.Name = "txtToekennummer";
            this.txtToekennummer.Size = new System.Drawing.Size(100, 20);
            this.txtToekennummer.TabIndex = 7;
            // 
            // btnToekennen
            // 
            this.btnToekennen.Location = new System.Drawing.Point(80, 45);
            this.btnToekennen.Name = "btnToekennen";
            this.btnToekennen.Size = new System.Drawing.Size(75, 23);
            this.btnToekennen.TabIndex = 8;
            this.btnToekennen.Text = "Toekennen";
            this.btnToekennen.UseVisualStyleBackColor = true;
            this.btnToekennen.Click += new System.EventHandler(this.btnToekennen_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnOpzoeken);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtInformatie);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtOpzoeknummer);
            this.groupBox4.Controls.Add(this.lbLading);
            this.groupBox4.Location = new System.Drawing.Point(12, 119);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 296);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opzoeken";
            // 
            // btnOpzoeken
            // 
            this.btnOpzoeken.Location = new System.Drawing.Point(81, 48);
            this.btnOpzoeken.Name = "btnOpzoeken";
            this.btnOpzoeken.Size = new System.Drawing.Size(75, 23);
            this.btnOpzoeken.TabIndex = 1;
            this.btnOpzoeken.Text = "Opzoeken";
            this.btnOpzoeken.UseVisualStyleBackColor = true;
            this.btnOpzoeken.Click += new System.EventHandler(this.btnOpzoeken_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Lading";
            // 
            // txtInformatie
            // 
            this.txtInformatie.Location = new System.Drawing.Point(7, 98);
            this.txtInformatie.Multiline = true;
            this.txtInformatie.Name = "txtInformatie";
            this.txtInformatie.ReadOnly = true;
            this.txtInformatie.Size = new System.Drawing.Size(147, 43);
            this.txtInformatie.TabIndex = 6;
            this.txtInformatie.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Informatie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nummer";
            // 
            // txtOpzoeknummer
            // 
            this.txtOpzoeknummer.Location = new System.Drawing.Point(56, 22);
            this.txtOpzoeknummer.Name = "txtOpzoeknummer";
            this.txtOpzoeknummer.Size = new System.Drawing.Size(100, 20);
            this.txtOpzoeknummer.TabIndex = 0;
            // 
            // lbLading
            // 
            this.lbLading.FormattingEnabled = true;
            this.lbLading.Location = new System.Drawing.Point(9, 166);
            this.lbLading.Name = "lbLading";
            this.lbLading.Size = new System.Drawing.Size(145, 121);
            this.lbLading.TabIndex = 0;
            this.lbLading.TabStop = false;
            // 
            // btnExporteerVluchten
            // 
            this.btnExporteerVluchten.Location = new System.Drawing.Point(458, 352);
            this.btnExporteerVluchten.Name = "btnExporteerVluchten";
            this.btnExporteerVluchten.Size = new System.Drawing.Size(94, 62);
            this.btnExporteerVluchten.TabIndex = 10;
            this.btnExporteerVluchten.Text = "Exporteer vluchtenlijst";
            this.btnExporteerVluchten.UseVisualStyleBackColor = true;
            this.btnExporteerVluchten.Click += new System.EventHandler(this.btnExporteerVluchten_Click);
            // 
            // VliegOpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 427);
            this.Controls.Add(this.btnExporteerVluchten);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VliegOpForm";
            this.Text = "Luchttransportorganisatie Vlieg Op";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbAlleVliegmachines;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbPersonen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGewicht;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton rbContainer;
        private System.Windows.Forms.RadioButton rbPersoon;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Button btnVoegLadingToe;
        private System.Windows.Forms.ListBox lbContainers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAutomatischToekennen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtToekennummer;
        private System.Windows.Forms.Button btnToekennen;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbLading;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOpzoeknummer;
        private System.Windows.Forms.Button btnOpzoeken;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInformatie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExporteerVluchten;
    }
}

