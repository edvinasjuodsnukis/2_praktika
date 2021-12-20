using MySql.Data.MySqlClient;
using System.Data;

namespace akademine_is
{
    class DB
    {

        private MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=praktika_db");

        public MySqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        //function to open connection
        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        //function to close connection
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
