using GestionBibFormGhoudan.Db;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2.Services
{
    class HomeService
    {

        public  BindingSource afficher()
        {
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * from home";

            MySqlCommand cmd = Connection.getMySqlCommand();
            cmd.CommandText = sqlSelectAll;
            MyDA.SelectCommand = cmd;

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            return bSource;
        }

        public  bool AfficherParIndex(int index)
        {
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * from home where currentPlace="+index;

            MySqlCommand cmd = Connection.getMySqlCommand();
            cmd.CommandText = sqlSelectAll;
            MyDA.SelectCommand = cmd;

            DataTable table = new DataTable();
            MyDA.Fill(table);

            if (table.Rows.Count == 1) return true;
            return false;
        }
        public bool checkZoneDisc(String  Zone)
        {
            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            string sSql = "SELECT count(*) as cc from home where zone= '" + Zone+"' and status='D'";
            sqlConn.ConnectionString = "SERVER=localhost; DATABASE=f1; UID=ayoub; PASSWORD=ayoub";
            sqlCmd.CommandText = sSql;
            sqlCmd.CommandType = CommandType.Text;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            MySqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read()) 
                if(int.Parse(reader["cc"].ToString()) <0) return false;
            return true;
        }
        public String AfficherStatus(int index)
        {

            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            string sSql = "SELECT status from home where currentPlace=" + index;
            sqlConn.ConnectionString = "SERVER=localhost; DATABASE=f1; UID=ayoub; PASSWORD=ayoub";
            sqlCmd.CommandText = sSql;
            sqlCmd.CommandType = CommandType.Text;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            MySqlDataReader reader = sqlCmd.ExecuteReader();
            /*
            string sqlSelectAll = "SELECT status from home where currentPlace="+index;

            MySqlCommand cmd = Connection.getMySqlCommand();
            cmd.CommandText = sqlSelectAll;
            MySqlDataReader reader = cmd.ExecuteReader();*/
            if ((reader.Read())) return reader["status"].ToString();
            return null;
        }

        public  bool Ajouter(home o)
        {
            MySqlCommand cmd = Connection.getMySqlCommand();
            cmd.CommandText = "INSERT INTO home (name, zone,currentPlace,status)" +
                "VALUES(@name, @zone,@currentPlace,@status)";
            cmd.Parameters.AddWithValue("@name", o.Name);
            cmd.Parameters.AddWithValue("@zone", o.Zone);
            cmd.Parameters.AddWithValue("@currentPlace", o.CurrentPlace);
            cmd.Parameters.AddWithValue("@status", o.Status);
            cmd.ExecuteNonQuery();
            return true;
        }

        public  bool delete(int o)
        {
            MySqlCommand cmd = Connection.getMySqlCommand();
            cmd.CommandText = "DELETE FROM home WHERE currentPlace=" + o;
            cmd.ExecuteNonQuery();
            return true;
        }

        public  bool Modifier(int id,String status)
        {
            MySqlCommand cmd = Connection.getMySqlCommand();
            cmd.CommandText = "UPDATE home SET status=@status" +
                    " WHERE currentPlace=" + id;
            cmd.Parameters.AddWithValue("@status", status);
            cmd.ExecuteNonQuery();
            return true;
        }
        public  bool ModifierAll(String Zone,String status)
        {
            MySqlCommand cmd = Connection.getMySqlCommand();
            cmd.CommandText = "UPDATE home SET status=@status" +
                    " WHERE zone LIKE '" + Zone+"'";
            cmd.Parameters.AddWithValue("@status", status);
            cmd.ExecuteNonQuery();
            return true;
        }
        public  bool killSwitch()
        {
            MySqlCommand cmd = Connection.getMySqlCommand();
            cmd.CommandText = "delete  from home where name != 'fridge'";
            cmd.ExecuteNonQuery();
            return true;
        }
    }
}
