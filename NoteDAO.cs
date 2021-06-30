using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TP_5
{
    class NoteDAO : DAO, IDAO<Note>
    {
        public NoteDAO(string host, int port, string BD, string user, string passw, string table = "notes") : base(host, port, BD, user, passw, table)
        {

        }
        public int Delete(string ce, string cm)
        {
            return base.Update("delete", null, new Dictionary<string, string>() { { "codeE", ce }, { "codeM", cm } });
        }

        public int Delete(string id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Note M)
        {
            Dictionary<string, string> useless = new Dictionary<string, string>
            {
                { "codeE", M.CodeE.ToString() },
                { "codeM", M.CodeM },
                { "note", M.N.ToString() },
            };
            return base.Update("insert", useless, null);    
        }

        public Note Select(string id)
        {
            throw new NotImplementedException();
        }
        public Note Select(string ce,string cm)
        {
            Dictionary<string, string> useless = new Dictionary<string, string>
            {
                { "codeE", ce },
                { "codeM", cm }
            };
            var data = base.Select(useless);
            if (data.Count > 0)
            {
                return new Note(Int32.Parse( data[0]["codeE"]), data[0]["codeM"], Single.Parse( data[0]["note"]));
            }
            return new Note(-1, "", -1);
        }

        public int Update(Note M)
        {
            Dictionary<string, string> useless = new Dictionary<string, string>
            {
                { "codeE", M.CodeE.ToString() },
                { "codeM", M.CodeM },
                { "note", M.N.ToString() },
            };
            return base.Update("update", useless, new Dictionary<string, string>() { { "codeE", M.CodeE.ToString() }, { "codeM", M.CodeM } });
        }

    }
}
