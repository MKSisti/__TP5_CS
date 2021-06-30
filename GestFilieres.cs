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
    public partial class GestFilieres : Form
    {
        private FiliereDAO F = new  FiliereDAO("localhost",3306,"gest_etud","root","1234");
        public GestFilieres()
        {
            InitializeComponent();
        }

        private void Ref()
        {
            dgvFil.Rows.Clear();
            foreach (var item in F.GetAll())
            {
                dgvFil.Rows.Add(item["codeF"], item["design"]);
            }

        }

        private void Clear()
        {
            txtCode.Text = "";
            txtDes.Text = "";
        }

        private void GestFilieres_Load(object sender, EventArgs e)
        {
            dgvFil.Columns.Add("codeF","Code Filiere");
            dgvFil.Columns.Add("design","Designation");
            foreach (var item in F.GetAll())
            {
                dgvFil.Rows.Add(item["codeF"],item["design"]);
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Length > 0 && txtDes.Text.Length > 0)
            {
                F.Insert(new Filiere(txtCode.Text, txtDes.Text));
                Ref();
                Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Length > 0 && txtDes.Text.Length > 0)
            {
                F.Update(new Filiere(txtCode.Text, txtDes.Text));
                Ref();
                Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Length > 0)
            {
                F.Delete(txtCode.Text);
                Ref();
                Clear();
            }
        }
    }
}
