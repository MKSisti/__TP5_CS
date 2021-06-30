using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TP_5
{
    class Matiere
    {
        private string codeM;
        private string codeF;
        private string des;
        private int niv;
        private int sem;

        public Matiere(string cm, string cf, string d, int n, int s)
        {
            CodeF = cf;
            CodeM = cm;
            Des = d;
            Niveau = n;
            Semestre = s;
        }

        public string CodeM
        {
            get => codeM;
            set
            {
                codeM = value;
            }
        }

        public string CodeF
        {
            get => codeF;
            set
            {
                codeF = value;
            }
        }

        public string Des
        {
            get => des;
            set
            {
                des = value;
            }
        }

        public int Niveau
        {
            get => niv;
            set
            {
                niv = value;
            }
        }

        public int Semestre
        {
            get => sem;
            set
            {
                sem = value;
            }
        }

    }
}
