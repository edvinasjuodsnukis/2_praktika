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
    public partial class AddGroupForm : Form
    {
        public AddGroupForm()
        {
            InitializeComponent();
        }

        private void textBoxSubjectName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddGroupForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonGroupAdd_Click(object sender, EventArgs e)
        {
            //grupes pridejimas
            GROUP group = new GROUP();
            string groupname = textBoxGroupName.Text;
            string groupcapacity = textBoxGroupMaxCapacity.Text;

            if (verif())
            {
                if (group.InsertGroup(groupname, groupcapacity))
                {
                    MessageBox.Show("Grupe prideta", "Grupes pridejimas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Grupes pridejimas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Uzpildykite laukus", "Grupes pridejimas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((textBoxGroupName.Text.Trim() == "") ||
                (textBoxGroupMaxCapacity.Text.Trim() == ""))
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
