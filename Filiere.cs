using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TP_5
{
    class Filiere
    {
        private string codeF;
        private string des;

        public Filiere(string c,string d)
        {
            CodeF = c;
            Des = d;
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
    }
}
