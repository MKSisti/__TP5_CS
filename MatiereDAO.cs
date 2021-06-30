using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TP_5
{
    class MatiereDAO : DAO, IDAO<Matiere>
    {
        public MatiereDAO(string host, int port, string BD, string user, string passw, string table = "matiers") : base(host, port, BD, user, passw, table)
        {

        }
        public int Delete(string id)
        {
            return base.Update("delete", null, new Dictionary<string, string>() { { "codeM", id } });
        }

        public int Insert(Matiere M)
        {
            Dictionary<string, string> useless = new Dictionary<string, string>
            {
                { "codeM", M.CodeM },
                { "codeF", M.CodeF },
                { "design", M.Des },
                { "niveau", M.Niveau.ToString() },
                { "semestre", M.Semestre.ToString() },
            };
            return base.Update("insert", useless, null);
        }

        public Matiere Select(string id)
        {
            Dictionary<string, string> useless = new Dictionary<string, string>();
            useless.Add("codeF", id);
            var data = base.Select(useless);
            if (data.Count > 0)
            {
                return new Matiere(data[0]["codeM"], data[0]["codeF"], data[0]["design"],Int32.Parse( data[0]["niveau"]),Int32.Parse( data[0]["semestre"]));
            }
            return new Matiere("","", "", 0, 0);
        }

        public int Update(Matiere M)
        {
            Dictionary<string, string> useless = new Dictionary<string, string>
            {
                { "codeM", M.CodeM },
                { "codeF", M.CodeF },
                { "design", M.Des },
                { "niveau", M.Niveau.ToString() },
                { "semestre", M.Semestre.ToString() },
            };
            return base.Update("update", useless, new Dictionary<string, string>() { { "codeM", M.CodeM } });
        }
        public List<Dictionary<string, string>> GetAll(Matiere M = null)
        {
            if (M is null)
            {
                return base.Select(new Dictionary<string, string>());
            }
            return base.Select(new Dictionary<string, string>(){ { "codeF" , M.CodeF } });
        }
    }
}
