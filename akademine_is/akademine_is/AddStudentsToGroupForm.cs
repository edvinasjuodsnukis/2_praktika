using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace akademine_is
{
    public partial class AddStudentsToGroupForm : Form
    {
        public AddStudentsToGroupForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();
        GROUP group = new GROUP();


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void AddStudentsToGroup_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` WHERE `grupe`=0");
            DataTable dt = new DataTable();
            checkedListBox1.DataSource = student.getStudents(command);
            checkedListBox1.ValueMember = "id";
            checkedListBox1.DisplayMember = "pavarde";

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `groups` WHERE ID!=0");
            comboBoxGroupList.DataSource = group.getGroups(command2);
            comboBoxGroupList.ValueMember = "id";
            comboBoxGroupList.DisplayMember = "Pavadinimas";
        }

        private void buttonGroupBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGroupAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxGroupList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}