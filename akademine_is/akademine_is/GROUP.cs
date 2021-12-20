using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace akademine_is
{
    class GROUP
    {
        //studentu grupes klase

        DB db = new DB();

        public bool InsertGroup(string groupname, string groupcapacity)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `groups`(`Pavadinimas`, `TalpaMAX`) VALUES (@name, @maxcap)", db.getConnection);
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = groupname;
            command.Parameters.Add("@maxcap", MySqlDbType.Int32).Value = groupcapacity;
            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public DataTable getGroups(MySqlCommand command)
        {
            command.Connection = db.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
