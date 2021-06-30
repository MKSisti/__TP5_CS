using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TP_5
{
    class Note
    {
        private int codeE;
        private string codeM;
        private float n;

        public Note(int ce,string cm, float n)
        {
            CodeE = ce;
            CodeM = cm;
            N = n;
        }

        public int CodeE
        {
            get => codeE;
            set
            {
                codeE = value;
            }
        }
        public string CodeM
        {
            get => codeM;
            set
            {
                codeM = value;
            }
        }

        public float N
        {
            get => n;
            set
            {
                n = value;
            }

        }

    }
}
