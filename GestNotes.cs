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
    public partial class GestNotes : Form
    {
        readonly MatiereDAO M = new MatiereDAO("localhost", 3306, "gest_etud", "root", "1234");
        readonly NoteDAO N = new NoteDAO("localhost", 3306, "gest_etud", "root", "1234");
        private string code;
        private string fil;
        public GestNotes(string c,string f)
        {
            code = c;
            fil = f;
            InitializeComponent();
        }
        private void Ref()
        {
            inNote.Value = 0;
            comMat.SelectedIndex = -1;
        }

        private void GestNotes_Load(object sender, EventArgs e)
        {
            var tmp = M.GetAll(new Matiere("",fil,"",0,0));
            foreach (var item in tmp)
            {
                comMat.Items.Add(item["codeM"]);
            }
            txtCode.Text = code;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comMat.SelectedIndex >=0)
            {
                N.Insert(new Note(Int32.Parse(txtCode.Text), comMat.SelectedItem.ToString(), Single.Parse(inNote.Value.ToString())));
                Ref();
                MessageBox.Show("Note Added Successfully");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            N.Update(new Note(Int32.Parse(txtCode.Text), comMat.SelectedItem.ToString(), Single.Parse(inNote.Value.ToString())));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            N.Delete(txtCode.Text, comMat.SelectedItem.ToString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var tmp = (Decimal)N.Select(txtCode.Text, comMat.SelectedItem.ToString()).N;
            if (tmp >=0)
            {

                inNote.Value = tmp;
            }
            else
            {
                MessageBox.Show("Note is not set up yet");
            }
        }
    }
}
