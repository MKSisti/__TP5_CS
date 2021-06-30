using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _TP_5
{
    public partial class MainFrame : Form
    {
        EleveDAO ED = new EleveDAO("localhost",3306,"gest_etud","root","1234","eleves");
        public MainFrame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Eleve n = new Eleve("GSEA", "1111", 1, "mark", "shulz");
            //ED.Insert(n);

            ED.Update(new Eleve("Ginf", "1111", 1, "norman", "shulz"));

            //label1.Text = ED.Select("9999").Nom;
        }

        private void filiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GestFilieres().ShowDialog();
        }

        private void matiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GestMatieres().ShowDialog();
        }

        private void etudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GestEt().ShowDialog();
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsNotes().ShowDialog();
        }

        private void bilanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Bilan().ShowDialog();
        }
    }
}
