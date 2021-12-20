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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LECTURER lecturer = new LECTURER(); //permission id=2
            STUDENT student = new STUDENT(); //permission id=3

            MySqlCommand command = new MySqlCommand("SELECT `permissions` FROM `student` WHERE `id`=1");
            
        }

        private void pridetiNaujaStudentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewStudentForm addStdF = new AddNewStudentForm();
            addStdF.Show(this);
        }

        private void dESTYTOJAIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pridėtiNaująDėstytojąToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewLecturerFrom addLctF = new AddNewLecturerFrom();
            addLctF.Show(this);
        }

        private void studentųSąrašasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentListForm stdLstF = new StudentListForm();
            stdLstF.Show(this);
        }

        private void pašalintiStudentąToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updDltStdF = new UpdateDeleteStudentForm();
            updDltStdF.Show(this);
        }

        private void dėstytojųSąrašasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LecturerListForm lctLstF = new LecturerListForm();
            lctLstF.Show(this);

            //UpdateDeleteLecturerForm updDltLctF = new UpdateDeleteLecturerForm();
            //updDltLctF.Show(this);
        }

        private void sukurtiNaująDalykąToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSubjectForm addSbjF = new AddSubjectForm();
            addSbjF.Show(this);
        }

        private void pridėtiNaująGrupęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGroupForm addGrpF = new AddGroupForm();
            addGrpF.Show(this);
        }

        private void pridėtiStudentusĮGrupęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentsToGroupForm addStdToGrpF = new AddStudentsToGroupForm();
            addStdToGrpF.Show(this);
        }

        private void pAZYMIAIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rodytiPažymiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScoresListForm scrLstF = new ScoresListForm();
            scrLstF.Show(this);
        }

        private void įvestiNaująPažymįToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewScoreForm addNScrF = new AddNewScoreForm();
            addNScrF.Show(this);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
