using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSVsoubory
{
    public partial class Form1 : Form
    {
        private Databaze databaze;
        public Form1()
        {
            InitializeComponent();
            labelJmeno.Text = "";
            labelVek.Text = "";
            labelRegistrace.Text = "";

            string cesta = "";
            try
            {
                cesta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DatabazeUzivatelu");
                if (!Directory.Exists(cesta))
                    Directory.CreateDirectory(cesta);
            }
            catch
            {
                MessageBox.Show("Nepodařilo se vytvořit složku " + cesta + ", zkontrolujte prosím svá oprávnění.",
                  "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // vytvoření databáze
            databaze = new Databaze(Path.Combine(cesta, "uzivatele.csv"));




        }

        private void tlacitkoUlozit_Click(object sender, EventArgs e)
        {
            try
            {
                databaze.Uloz();
            }
            catch
            {
                MessageBox.Show("Databázi se nepodařilo uložit, zkontrolujte přístupová práva k souboru.",
                    "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nacistUzivatele_Click(object sender, EventArgs e)
        {
            try
            {
                databaze.Nacti();
                listUzivatelu.Items.Clear();
                listUzivatelu.Items.AddRange(databaze.VratVsechny());
            }
            catch
            {
                MessageBox.Show("Databázi se nepodařilo načíst, soubor zřejmě neexisituje.",
                   "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listUzivatelu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listUzivatelu.SelectedItem != null)
            {
                Uzivatel u = (Uzivatel)listUzivatelu.SelectedItem;
                labelJmeno.Text = u.Jmeno;
                labelVek.Text = u.Vek.ToString();
                labelRegistrace.Text = u.Registrovan.ToShortDateString();
            }
        }

        private void tlacitkoPridat_Click(object sender, EventArgs e)
        {
            string jmeno = textBox1.Text;
            int vek = Convert.ToInt32(numericUpDown1.Value);
            DateTime registrovan = dateTimePicker1.Value;
            databaze.PridejUzivatele(jmeno, vek, registrovan);
            listUzivatelu.Items.Add(new Uzivatel(jmeno, vek, registrovan));
        }
    }
}
