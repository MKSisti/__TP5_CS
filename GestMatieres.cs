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
    public partial class GestMatieres : Form
    {
        MatiereDAO M = new MatiereDAO("localhost", 3306, "gest_etud", "root", "1234");
        FiliereDAO F = new FiliereDAO("localhost", 3306, "gest_etud", "root", "1234");
        public GestMatieres()
        {
            InitializeComponent();
        }
        private void Ref()
        {
            dgvMat.Rows.Clear();
            foreach (var item in M.GetAll())
            {
                dgvMat.Rows.Add(item["codeM"], item["codeF"], item["design"], item["niveau"], item["semestre"]);
            }
        }
        private void Clear()
        {
            txtDes.Text = "";
            txtMat.Text = "";
            cbFil.SelectedIndex = 0;
            cbNiv.SelectedIndex = 0;
            cbSem.SelectedIndex = 0;

        }

        private void GestMatieres_Load(object sender, EventArgs e)
        {
            var L = new Object[]
            {
                1,
                2,
                3
            };
            var L2 = new Object[]
            {
                1,
                2
            };
            var fs = F.GetAll();
            foreach (var item in fs)
            {
                cbFil.Items.Add(item["codeF"]);
            }
            cbNiv.Items.AddRange(L);
            cbSem.Items.AddRange(L2);
            dgvMat.Columns.Add("codeM", "Code Matiere");
            dgvMat.Columns.Add("codeF", "Code Filiere");
            dgvMat.Columns.Add("design", "Designation");
            dgvMat.Columns.Add("niveau", "Niveau");
            dgvMat.Columns.Add("semestre", "Semestre");
            foreach (var item in M.GetAll())
            {
                dgvMat.Rows.Add(item["codeM"], item["codeF"], item["design"], item["niveau"], item["semestre"]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMat.Text.Length > 0 && txtDes.Text.Length > 0 )
            {
                M.Insert(new Matiere(txtMat.Text, cbFil.SelectedItem.ToString(), txtDes.Text, Int32.Parse( cbNiv.SelectedItem.ToString()), Int32.Parse( cbSem.SelectedItem.ToString())));
                Ref();
                Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMat.Text.Length > 0 && txtDes.Text.Length > 0)
            {
                M.Update(new Matiere(txtMat.Text, cbFil.SelectedItem.ToString(), txtDes.Text, Int32.Parse(cbNiv.SelectedItem.ToString()), Int32.Parse(cbSem.SelectedItem.ToString())));
                Ref();
                Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMat.Text.Length > 0)
            {
                M.Delete(txtMat.Text);
                Ref();
                Clear();
            }
        }
    }
}
