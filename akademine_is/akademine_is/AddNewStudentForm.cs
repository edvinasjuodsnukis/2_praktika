using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace akademine_is
{
    public partial class AddNewStudentForm : Form
    {
        public AddNewStudentForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddNewStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonStudentAdd_Click(object sender, EventArgs e)
        {
            //Studento pridejimas
            //public bool InsertStudent(String fname, string lname, DateTime bdate, string mail, string phone, string address)
            STUDENT student = new STUDENT();
            string fname = textBoxStudentName.Text;
            string lname = textBoxStudentLastName.Text;
            DateTime bdate = dateTimePickerStudent.Value;
            string mail = textBoxStudentMail.Text;
            string phone = textBoxStudentPhone.Text;
            string address = textBoxStudentAdress.Text;
            string permission = "3";

            int born_year = dateTimePickerStudent.Value.Year;
            int this_year = DateTime.Now.Year;



            if(((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("Studento amzius turi buti tarp 10 ir 100", "Netinkama gimimo data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(verif())
            {
                if (student.InsertStudent(fname,lname,bdate,mail,phone,address))
                {
                    student.InsertStudentToUsers(fname, lname, permission);
                    MessageBox.Show("Studentas pridėtas", "Prideti studenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Prideti studenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Uzpildykite laukus", "Prideti studenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        

        }
        //data verification
        bool verif()
        {
            if((textBoxStudentName.Text.Trim() == "") ||
                (textBoxStudentLastName.Text.Trim() == "") ||
                (textBoxStudentPhone.Text.Trim() == "" ||
                textBoxStudentAdress.Text.Trim() == "" ||
                textBoxStudentMail.Text.Trim() == ""))
            {
                return false;
            } 
            else
            {
                return true;
            }
        }

        private void buttonStudentBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    } 
}
