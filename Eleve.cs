using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _TP_5
{
    public class Eleve
    {
        private string codeFil;
        private string codeEl;
        private int niveau;
        private string nom;
        private string prenom;

        public Eleve(string cf, string ce, int n, string nm, string pnm)
        {
            codeFil = cf;
            codeEl = ce;
            niveau = n;
            nom = nm;
            prenom = pnm;
        }

        public string CodeFil
        {
            get => codeFil;
            set
            {
                codeFil = value;
            }
        }

        public string CodeEl
        {
            get => codeEl;
            set
            {
                codeEl = value;
            }
        }

        public int Niv
        {
            get => niveau;
            set
            {
                niveau = value;
            }
        }

        public string Nom
        {
            get => nom;
            set
            {
                nom = value;
            }
        }

        public string Pnom
        {
            get => prenom;
            set
            {
                prenom = value;
            }
        }
    }
}