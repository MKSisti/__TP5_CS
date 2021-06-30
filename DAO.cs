using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace _TP_5
{
    public abstract class MySqlClass
    {
        private string BD;
        private MySqlConnection con;
        private string host;
        private int port;
        private string pass;
        private MySqlDataReader dr;
        private string user;


        public MySqlClass(string host, int port, string BD, string user, string passw)
        {
            this.host = host;
            this.port = port;
            this.BD = BD;
            this.user = user;
            pass = passw;

            con = new MySqlConnection($"Database={BD};Port={port};Server={host};Uid={user};Pwd={passw}");

        }
        public List<Dictionary<string, string>> Get(string sql)
        {
            List<Dictionary<string, string>> L = new List<Dictionary<string, string>>();
            Dictionary<string, string> D = new Dictionary<string, string>();
            List<string> names = new List<string>();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql,con);
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = dr.GetSchemaTable();
                foreach (DataRow row in dt.Rows)
                {
                    names.Add(row.Field<string>("ColumnName"));
                    //Console.WriteLine(row.Field<string>("ColumnName"));    
                }
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        D.Add(names[i], dr[i].ToString());
                    }
                    L.Add(new Dictionary<string, string>(D));
                    D.Clear();
                }
            }
            con.Close();
            return L;
        }

        public int Up(string sql)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql,con);
            var i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }

    public abstract class DAO : MySqlClass
    {
        //private string[] paramCo;
        private string Table;

        public DAO(string host, int port, string BD, string user, string passw , string table):base(host,port,BD,user,passw)
        {
            this.Table = table;
        }

        public List<Dictionary<string, string>> Select(Dictionary<string, string> Cr)
        {

            if (Cr.Count == 0)
            {
                return base.Get($"SELECT * from {Table}");
            }
            string sql = $"SELECT * from {Table} WHERE ";
            var i = Cr.Count;
            foreach ( KeyValuePair<string,string> kvp in Cr)
            {
                i--;
                sql += $"{kvp.Key} = '{kvp.Value}'";
                sql += i > 0 ? " AND " : "";
            }
            
            var tmp = base.Get(sql);
            return tmp;

        }

        public int Update(string action, Dictionary<string, string> data, Dictionary<string, string> cr)
        {
            string sql,inserts,names ;
            int i;
            switch (action)
            {
                case "insert":
                    inserts = "(";
                    names = "(";
                    i = data.Count;
                    foreach (var kvp in data)
                    {
                        i--;
                        names += $"{kvp.Key}";
                        names += i > 0 ? " , " : "";

                        inserts += $"'{kvp.Value}'";
                        inserts += i > 0 ? " , " : "";
                    }
                    names += " )";
                    inserts += " )";
                    return base.Up($"INSERT INTO {Table} {names} VALUES {inserts}");
                case "delete":
                    sql = $"DELETE FROM {Table} WHERE ";
                    i = cr.Count;
                    foreach (var kvp in cr)
                    {
                        i--;
                        sql += $"{kvp.Key} = '{kvp.Value}'";
                        sql +=  i > 0 ? " AND " : "";
                    }
                    return base.Up(sql);
                case "update":
                    inserts = "";
                    i = data.Count;
                    foreach (var kvp in data)
                    {
                        i--;
                        inserts += $"{kvp.Key}='{kvp.Value}'";
                        inserts += i > 0 ? " , " : "";
                    }
                    sql = "";
                    i = cr.Count;
                    foreach (var kvp in cr)
                    {
                        i--;
                        sql += $"{kvp.Key} = '{kvp.Value}'";
                        sql += i > 0 ? " AND " : "";
                    }
                    return base.Up($"UPDATE {Table} SET {inserts} WHERE {sql}");
                default:
                    break;
            }
            throw new System.NotImplementedException();
        }
    }
}