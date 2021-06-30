using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.XlsIO;

namespace _TP_5
{
    public partial class Bilan : Form
    {

        readonly FiliereDAO F = new FiliereDAO("localhost", 3306, "gest_etud", "root", "1234");
        readonly EleveDAO E = new EleveDAO("localhost", 3306, "gest_etud", "root", "1234");
        readonly NoteDAO N = new NoteDAO("localhost", 3306, "gest_etud", "root", "1234");
        public Bilan()
        {
            InitializeComponent();
        }

        private void Bilan_Load(object sender, EventArgs e)
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
            comNiveau.Items.AddRange(L);

            dgvNotes.Columns.Add("codeM", "Code Matiere");
            dgvNotes.Columns.Add("des", "Designation");
            dgvNotes.Columns.Add("semestre", "Semestre");
            dgvNotes.Columns.Add("note", "Note");
        }

        private void comFiliere_SelectedIndexChanged(object sender, EventArgs e)
        {
            comEt.SelectedIndex = -1;
            comEt.Items.Clear();
            comNiveau.SelectedIndex = -1;
            var tmp = E.GetAll(new Eleve(comFiliere.SelectedItem.ToString(), "", 0, "", ""));
            foreach (var item in tmp)
            {
                comEt.Items.Add(item["codeE"]);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comEt.SelectedIndex >= 0 && comFiliere.SelectedIndex >= 0 && comNiveau.SelectedIndex >= 0)
            {
                float m = 0F;
                int t = 0;
                var tmp = N.Get($"SELECT M.codeM,M.design,M.semestre,N.note from matiers M,notes N WHERE M.codeM = N.codeM AND N.codeE like '{comEt.SelectedItem}' AND M.codeF like '{comFiliere.SelectedItem}' AND M.niveau like '{comNiveau.SelectedItem}'");
                foreach (var item in tmp)
                {
                    m += Single.Parse(item["note"]);
                    t++;
                    dgvNotes.Rows.Add(item["codeM"],item["design"],item["semestre"],item["note"]);
                }
                if (t>0)
                {
                    m /= t;
                    txtMoy.Text = m.ToString();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgvNotes.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dgvNotes.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }

            ExcelEngine excelEngine = new ExcelEngine();
            IApplication application = excelEngine.Excel;
            application.DefaultVersion = ExcelVersion.Excel2016;

            //Create a new workbook
            IWorkbook workbook = application.Workbooks.Create(1);
            IWorksheet sheet = workbook.Worksheets[0];

            //Import data from the data table with column header, at first row and first column, 
            //and by its column type.
            sheet.ImportDataTable(dt, true, 1, 1, true);

            //Creating Excel table or list object and apply style to the table
            IListObject table = sheet.ListObjects.Create("Employee_PersonalDetails", sheet.UsedRange);

            table.BuiltInTableStyle = TableBuiltInStyles.TableStyleMedium14;

            //Autofit the columns
            sheet.UsedRange.AutofitColumns();

            //Save the file in the given path
            Stream excelStream = File.Create(Path.GetFullPath($"{comFiliere.SelectedItem}_{comNiveau.SelectedItem}.xlsx"));
            workbook.SaveAs(excelStream);
            excelStream.Dispose();
        }
    }
}
