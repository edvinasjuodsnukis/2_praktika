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
    public partial class AddNewLecturerFrom : Form
    {
        public AddNewLecturerFrom()
        {
            InitializeComponent();
        }

        private void AddNewLecturerFrom_Load(object sender, EventArgs e)
        {

        }

        private void buttonLecturerAdd_Click(object sender, EventArgs e)
        {
            //Destytojo pridejimas
            LECTURER lecturer = new LECTURER();
            string fname = textBoxLecturerName.Text;
            string lname = textBoxLecturerLastName.Text;
            DateTime bdate = dateTimePickerLecturer.Value;
            string mail = textBoxLecturerMail.Text;
            string phone = textBoxLecturerPhone.Text;
            string address = textBoxLecturerAdress.Text;
            string permission = "2";

            int born_year = dateTimePickerLecturer.Value.Year;
            int this_year = DateTime.Now.Year;

            if(((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("Destytojo amžius turi buti tarp 10 ir 100", "Netinkama gimimo data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                if (lecturer.InsertLecturer(fname, lname, bdate, mail, phone, address))
                {
                    lecturer.InsertLecturerToUsers(fname, lname, permission);
                    MessageBox.Show("Destytojas pridėtas", "Prideti destytoja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Prideti destytoja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Uzpildykite laukus", "Prideti destytoja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        //data verification
        bool verif()
        {
            if ((textBoxLecturerName.Text.Trim() == "") ||
                (textBoxLecturerLastName.Text.Trim() == "") ||
                (textBoxLecturerPhone.Text.Trim() == "" ||
                textBoxLecturerAdress.Text.Trim() == "" ||
                textBoxLecturerMail.Text.Trim() == ""))
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


