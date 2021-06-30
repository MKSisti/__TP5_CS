using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _TP_5
{
    public class EleveDAO : DAO, IDAO<Eleve>
    {
        public EleveDAO(string host, int port, string BD, string user, string passw, string table = "eleves") : base(host, port, BD, user, passw,table)
        {
            
        }

        public int Delete(string id )
        {
            return base.Update("delete", null, new Dictionary<string, string>() { {"codeE",id } });
        }

        public int Insert(Eleve E)
        {
            Dictionary<string, string> useless = new Dictionary<string, string>
            {
                { "codeE", E.CodeEl },
                { "nom", E.Nom },
                { "prenom", E.Pnom },
                { "niveau", E.Niv.ToString() },
                { "codeF", E.CodeFil }
            };
            return base.Update("insert", useless, null);
        }

        public Eleve Select(string id)
        {
            Dictionary<string, string> useless = new Dictionary<string, string>
            {
                { "codeE", id }
            };
            var data = base.Select(useless);
            if (data.Count > 0)
            {
            return new Eleve(data[0]["codeF"], data[0]["codeE"], Int32.Parse( data[0]["niveau"]), data[0]["nom"], data[0]["prenom"]);
            }
            throw new NotImplementedException();
        }

        public int Update(Eleve E)
        {
            Dictionary<string, string> useless = new Dictionary<string, string>
            {
                { "codeE", E.CodeEl },
                { "nom", E.Nom },
                { "prenom", E.Pnom },
                { "niveau", E.Niv.ToString() },
                { "codeF", E.CodeFil }
            };
            return base.Update("update", useless, new Dictionary<string, string>() { { "codeE", E.CodeEl } });
        }
        public List<Dictionary<string, string>> GetAll(Eleve E = null)
        {
            if (E is null)
            {
                return base.Select(new Dictionary<string, string>());
            }
            return base.Select(new Dictionary<string, string>() { { "codeF", E.CodeFil } });
        }
    }

    
}