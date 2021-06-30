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
    public partial class GestEt : Form
    {
        private FiliereDAO F = new  FiliereDAO("localhost",3306,"gest_etud","root","1234");
        private EleveDAO E = new  EleveDAO("localhost",3306,"gest_etud","root","1234");
        public GestEt()
        {
            InitializeComponent();
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Length > 0)
            {
                new GestNotes(txtCode.Text, E.Select(txtCode.Text).CodeFil).ShowDialog();
            }
            else
            {
                MessageBox.Show("Please fill the student code first");
            }
        }

        private void Ref()
        {
            dgvEt.Rows.Clear();
            foreach (var item in E.GetAll())
            {
                dgvEt.Rows.Add(item["codeE"], item["codeF"], item["nom"], item["prenom"], item["niveau"]);
            }

        }

        private void Clear()
        {
            txtCode.Text = "";
            txtNom.Text = "";
            txtPrenom.Text = "";

            comFil.SelectedIndex = 0;
            comNiv.SelectedIndex = 1;
        }

        private void GestEt_Load(object sender, EventArgs e)
        {
            var L = new Object[]
            {
               1,2,3
            };
            comNiv.Items.AddRange(L);
            var fs = F.GetAll();
            foreach (var item in fs)
            {
                comFil.Items.Add(item["codeF"]);
            }
            dgvEt.Columns.Add("codeE", "Code Etudiant");
            dgvEt.Columns.Add("codeF", "Code Filiere");
            dgvEt.Columns.Add("nom", "Nom");
            dgvEt.Columns.Add("prenom", "Prenom");
            dgvEt.Columns.Add("niveau", "Niveau");
            foreach (var item in E.GetAll())
            {
                dgvEt.Rows.Add(item["codeE"], item["codeF"], item["nom"], item["prenom"], item["niveau"]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Length > 0 && txtNom.Text.Length > 0 && txtPrenom.Text.Length > 0)
            {
                E.Insert(new Eleve(comFil.SelectedItem.ToString(), txtCode.Text,Int32.Parse( comNiv.SelectedItem.ToString()), txtNom.Text, txtPrenom.Text));
                Ref();
                Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Length > 0 && txtNom.Text.Length > 0 && txtPrenom.Text.Length > 0)
            {
                E.Update(new Eleve(comFil.SelectedItem.ToString(), txtCode.Text, Int32.Parse(comNiv.SelectedItem.ToString()), txtNom.Text, txtPrenom.Text));
                Ref();
                Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Length > 0)
            {
                E.Delete(txtCode.Text);
                Ref();
                Clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            if (cbCode.Checked)
            {
                if (txtCode.Text.Length > 0)
                {
                    var tmp = E.Select(txtCode.Text);
                    txtCode.Text = tmp.CodeEl;
                    txtNom.Text = tmp.Nom;
                    txtPrenom.Text = tmp.Pnom;
                    comFil.SelectedItem = tmp.CodeFil;
                    comNiv.SelectedItem = tmp.Niv;
                }
            }
            //TODO: implement the search
            //var c = this.components.Components;
            //foreach (var item in c)
            //{
            //    if (item is CheckBox )
            //    {
            //        var itemAsCheck = item as CheckBox;
            //        if (itemAsCheck.Checked)
            //        {

            //        }
            //    }
            //}
        }
    }
}
