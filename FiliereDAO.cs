using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TP_5
{
    class FiliereDAO : DAO, IDAO<Filiere>
    {
        public FiliereDAO(string host, int port, string BD, string user, string passw, string table = "filiers") : base(host, port, BD, user, passw, table)
        {

        }
        public int Delete(string id)
        {
            return base.Update("delete", null, new Dictionary<string, string>() { { "codeF", id } });
        }

        public int Insert(Filiere M)
        {
            Dictionary<string, string> useless = new Dictionary<string, string>
            {
                { "codeF", M.CodeF },
                { "design", M.Des },
            };
            return base.Update("insert", useless, null);
        }

        public Filiere Select(string id)
        {
            Dictionary<string, string> useless = new Dictionary<string, string>();
            useless.Add("codeF", id);
            var data = base.Select(useless);
            if (data.Count > 0)
            {
                return new Filiere(data[0]["codeF"], data[0]["design"]);
            }
            return new Filiere("", "");
        }

        public int Update(Filiere M)
        {
            Dictionary<string, string> useless = new Dictionary<string, string>
            {
                { "codeF", M.CodeF },
                { "design", M.Des },
            };
            return base.Update("update", useless, new Dictionary<string, string>() { { "codeF", M.CodeF } });
        }
        public List<Dictionary<string, string>> GetAll()
        {
            return base.Select(new Dictionary<string, string>());
        }
    }
}
