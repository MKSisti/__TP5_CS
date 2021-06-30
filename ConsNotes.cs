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
    public partial class ConsNotes : Form
    {
        readonly MatiereDAO M = new MatiereDAO("localhost", 3306, "gest_etud", "root", "1234");
        readonly FiliereDAO F = new FiliereDAO("localhost", 3306, "gest_etud", "root", "1234");
        readonly NoteDAO N = new NoteDAO("localhost", 3306, "gest_etud", "root", "1234");
        public ConsNotes()
        {
            InitializeComponent();
        }

        private void ConsNotes_Load(object sender, EventArgs e)
        {
            var L = new Object[]
            {
                1,2,3
            };
            var fs = F.GetAll();
            foreach (var item in fs)
            {
                comFiliere.Items.Add(item["codeF"]);
            }
            var ms = M.GetAll();
            foreach (var item in ms)
            {
                comMatiere.Items.Add(item["codeM"]);
            }
            comNiveau.Items.AddRange(L);
            dgvNotes.Columns.Add("codeE", "Code Eleve");
            dgvNotes.Columns.Add("nom", "Nom");
            dgvNotes.Columns.Add("prenom", "Prenom");
            dgvNotes.Columns.Add("note", "Note");
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comFiliere.SelectedIndex>=0 && comMatiere.SelectedIndex >= 0 && comNiveau.SelectedIndex>=0)
            {
                float m = 0F;
                int t = 0;
                Console.WriteLine("in search");
                var tmp = N.Get($"select E.codeE, E.nom, E.prenom, N.note from eleves E,notes N where E.codeE = N.codeE AND E.codeF like '{comFiliere.SelectedItem}' AND N.codeM like '{comMatiere.SelectedItem}' And E.niveau like '{comNiveau.SelectedItem}'");
                foreach (var item in tmp)
                {
                    t++;
                    m += Single.Parse (item["note"]);
                    Console.WriteLine(item);
                    dgvNotes.Rows.Add(item["codeE"], item["nom"], item["prenom"], item["note"]);
                }
                if (t>0)
                {
                    m /= t;
                    txtMoy.Text = m.ToString();
                }
            }
        }
    }
}
