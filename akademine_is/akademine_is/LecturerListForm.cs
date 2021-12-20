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
    public partial class LecturerListForm : Form
    {
        public LecturerListForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        LECTURER lecturer = new LECTURER();

        private void LecturerListForm_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `lecturer`");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 20;
            dataGridView1.DataSource = lecturer.getLecturers(command);
            dataGridView1.AllowUserToAddRows = false;
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            // edit/remove doubleclick
            UpdateDeleteLecturerForm updateDeleteLctF = new UpdateDeleteLecturerForm();
            updateDeleteLctF.textBoxUDLID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeleteLctF.textBoxUDLName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeleteLctF.textBoxUDLLastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeleteLctF.dateTimePickerUDL.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            updateDeleteLctF.textBoxUDLMail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            updateDeleteLctF.textBoxUDLPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeleteLctF.textBoxUDLAdress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            updateDeleteLctF.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            //refresh data in table
            MySqlCommand command = new MySqlCommand("SELECT * FROM `lecturer`");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 20;
            dataGridView1.DataSource = lecturer.getLecturers(command);
            dataGridView1.AllowUserToAddRows = false;
        }
    }
    }

