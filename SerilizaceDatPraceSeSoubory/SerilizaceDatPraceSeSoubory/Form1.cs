using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace SerilizaceDatPraceSeSoubory
{
    public partial class Form1 : Form
    {
        
        private List<Uzivatel> uzivatele = new List<Uzivatel>();
        public Form1()
        {
            InitializeComponent();
             

        }
         

        private void button1_Click(object sender, EventArgs e)
        {
            // Uzivatel uzivatel = new Uzivatel(textBox1.Text, textBox2.Text, dateTimePicker1.Value);

            Uzivatel uzivatel = new Uzivatel()
            {
              Jmeno = textBox1.Text,
              Prijmeni = textBox2.Text,
              DatumNarozeni = dateTimePicker1.Value
            };

            uzivatele.Add(uzivatel);
            //obnovení zdroje dat listbocu
            
            listBox1.DataSource = null;
            listBox1.DataSource = uzivatele;
            textBox1.Clear();
            textBox2.Clear();
            Serializuj();

        }

        private void Serializuj()
        {
            try
            {
                // Vytvoříme si XmlSerializer na typ List<Uzivatel>
                XmlSerializer serX = new XmlSerializer(uzivatele.GetType());

                // Alternativní forma, jak by to šlo také zapsat
                //XmlSerializer serializer = new XmlSerializer(typeof(List<Uzivatel>));

                // Vytvoříme Stream pomocí kterého budeme serializovat
                using (StreamWriter sw = new StreamWriter("uzivatele.xml"))
                {
                    // Zavoláme metodu Serialize(), kde první parametr je Stream
                    // Ten jsme vytvořili o řádek výše
                    // Druhý parametr je objekt, který serializujeme

                    serX.Serialize(sw, uzivatele);

                }
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }
        private void Deserializuj()
        {
            try
            {
                if (File.Exists("uzivatele.xml"))
                {
                    XmlSerializer serX = new XmlSerializer(uzivatele.GetType());
                    using (StreamReader sr = new StreamReader("uzivatele.xml"))
                    {
                        uzivatele = (List<Uzivatel>)serX.Deserialize(sr);
                    }
                }
                else throw new FileNotFoundException("Soubor nenalezen");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Deserializuj();
            listBox1.DataSource = uzivatele;
        }
    }
}
