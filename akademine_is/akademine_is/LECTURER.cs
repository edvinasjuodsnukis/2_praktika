using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace akademine_is
{
    class LECTURER
    {
        // destytojo klase

        DB db = new DB();
        public bool InsertLecturer(string fname, string lname, DateTime bdate, string mail, string phone, string address)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `lecturer`(`vardas`, `pavarde`, `gimimo_data`, `el_pastas`, `tel_numeris`, `adresas`) VALUES (@fn,@ln,@bdt,@mail,@phn,@adrs)", db.getConnection);
            //@fn,@ln,@bdt,@mail,@phn,@adrs
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", MySqlDbType.Text).Value = address;

            db.openConnection();

            if(command.ExecuteNonQuery() == 1)
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

        public bool InsertLecturerToUsers(string fname, string lname, string permission)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`username`, `password`, `permission`) VALUES (@fn,@ln,@prm)", db.getConnection);
            //@fn,@psw,@prm
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@prm", MySqlDbType.VarChar).Value = "2";
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

        //return data from db
        public DataTable getLecturers(MySqlCommand command)
        {
            command.Connection = db.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteLecturer(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `lecturer` WHERE `id`=@lecturerID", db.getConnection);
            //@lecturerID
            command.Parameters.Add("@lecturerID", MySqlDbType.Int32).Value = id;

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

        //function to update lecturers information
        public bool updateLecturer(int id, string fname, string lname, DateTime bdate, string mail, string phone, string address)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `lecturer` SET `vardas`=@fn,`pavarde`=@ln,`gimimo_data`=@bdt,`el_pastas`=@mail,`tel_numeris`=@phn,`adresas`=@adrs WHERE `id`=@ID", db.getConnection);
            //@ID,@fn,@ln,@bdt,@mail,@phn,@adrs
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", MySqlDbType.Text).Value = address;

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

    }
}
