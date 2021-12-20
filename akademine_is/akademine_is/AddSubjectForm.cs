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
using System.Data;

namespace akademine_is
{

    public partial class AddSubjectForm : Form
    {
        
        public AddSubjectForm()
        {
            InitializeComponent();
            

        }

        LECTURER lecturer = new LECTURER();




        public void buttonSubjectAdd_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `lecturer`");
            DataTable dt = new DataTable();
            string subName = textBoxSubjectName.Text;
            string subLecturer = comboBoxLecturer.SelectedValue.ToString();
            string subInfo = textBoxSubjectInfo.Text;

            SUBJECT subject = new SUBJECT();

            if(subject.insertSubject(subName,subLecturer,subInfo))
            {
                MessageBox.Show("Naujas dalykas pridetas", "Naujas dalykas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Naujas dalykas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddSubjectForm_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `lecturer`");
            //DataTable dt = new DataTable();
            comboBoxLecturer.DataSource = lecturer.getLecturers(command);
            comboBoxLecturer.ValueMember = "id";
            comboBoxLecturer.DisplayMember = "pavarde";
        }

        private void buttonSubjectBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxLecturer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
