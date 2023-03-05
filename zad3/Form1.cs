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
using zad3;
using static zad3.Program;

namespace zad3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        public Siec siec = new Siec();
        public List<Probka> probkiUczace = new List<Probka>();
        public List<List<double>> ukryteWejscia = new List<List<double>>();
        public List<List<List<double>>> wagi = new List<List<List<double>>>();


        private void btn_crSiec_Click(object sender, EventArgs e)
        {
            siec.stworz(siec_text.Text);
            btn_prUczace.Enabled = true;
        }

        public static T wczytajXml<T>(string fileName)
        where T : class
        {
            using (var stream = System.IO.File.OpenRead(fileName))
            {
                var serializer = new XmlSerializer(typeof(T));
                return serializer.Deserialize(stream) as T;
            }
        }

        private void btn_prUczace_Click(object sender, EventArgs e)
        {
            string filePath;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                probkiUczace = wczytajXml<List<Probka>>(filePath);
            }
            wygWagi.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            siec.genWagi(double.Parse(wagi_pocz.Text), double.Parse(wagi_kon.Text));
            ucz.Enabled = true;
        }

        private void ucz_Click(object sender, EventArgs e)
        {
            siec.Ucz(int.Parse(epoki.Text), probkiUczace,double.Parse(ni.Text),double.Parse(beta.Text)) ;
            koniec.Text = siec.wypisz(probkiUczace, double.Parse(beta.Text));
        }

        private void koniec_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
