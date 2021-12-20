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
    public partial class AddNewScoreForm : Form
    {
        public AddNewScoreForm()
        {
            InitializeComponent();
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSubjectName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonScoreBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNewScoreForm_Load(object sender, EventArgs e)
        {
            LECTURER lecturer = new LECTURER();
            STUDENT student = new STUDENT();
            SUBJECT subject = new SUBJECT();
            SCORE score = new SCORE();

            DataTable dt = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `lecturer`");
            comboBoxLecturer.DataSource = lecturer.getLecturers(command);
            comboBoxLecturer.ValueMember = "id";
            comboBoxLecturer.DisplayMember = "pavarde";

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `student`");
            comboBoxStudent.DataSource = student.getStudents(command2);
            comboBoxStudent.ValueMember = "id";
            comboBoxStudent.DisplayMember = "pavarde";

            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `subject`");
            comboBoxSubject.DataSource = subject.getSubjects(command3);
            comboBoxSubject.ValueMember = "id";
            comboBoxSubject.DisplayMember = "label";
        }

        private void buttonScoreAdd_Click(object sender, EventArgs e)
        {
            SCORE score2 = new SCORE();
            //pazymio nusiuntimas i duomenu baze
            int score = Convert.ToInt32(textBoxPazymys.Text);
            DateTime sdate = dateTimePickerScore.Value;
            string lecturer = comboBoxLecturer.SelectedValue.ToString();
            string student = comboBoxStudent.SelectedValue.ToString();
            string subject = comboBoxSubject.SelectedValue.ToString();

            

            if (verif())
            {
                if (score2.InsertScore(score, sdate, lecturer, student, subject))
                {
                    MessageBox.Show("Pazymys pridėtas", "Prideti pazymi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Prideti pazymi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Uzpildykite laukus", "Prideti pazymi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        //data verification
        bool verif()
        {
            if ((textBoxPazymys.Text.Trim() == "" ) ||
                (comboBoxLecturer.Text.Trim() == "") ||
                (comboBoxStudent.Text.Trim() =="") ||
                (comboBoxSubject.Text.Trim() =="")) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
