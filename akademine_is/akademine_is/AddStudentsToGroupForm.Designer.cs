
namespace akademine_is
{
    partial class AddStudentsToGroupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxGroupList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGroupAdd = new System.Windows.Forms.Button();
            this.buttonGroupBack = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // comboBoxGroupList
            // 
            this.comboBoxGroupList.FormattingEnabled = true;
            this.comboBoxGroupList.Location = new System.Drawing.Point(342, 64);
            this.comboBoxGroupList.Name = "comboBoxGroupList";
            this.comboBoxGroupList.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGroupList.TabIndex = 1;
            this.comboBoxGroupList.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroupList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Studentų nepriklausančių grupei sąrašas:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grupės:";
            // 
            // buttonGroupAdd
            // 
            this.buttonGroupAdd.Location = new System.Drawing.Point(388, 500);
            this.buttonGroupAdd.Name = "buttonGroupAdd";
            this.buttonGroupAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonGroupAdd.TabIndex = 17;
            this.buttonGroupAdd.Text = "Pridėti";
            this.buttonGroupAdd.UseVisualStyleBackColor = true;
            this.buttonGroupAdd.Click += new System.EventHandler(this.buttonGroupAdd_Click);
            // 
            // buttonGroupBack
            // 
            this.buttonGroupBack.Location = new System.Drawing.Point(388, 471);
            this.buttonGroupBack.Name = "buttonGroupBack";
            this.buttonGroupBack.Size = new System.Drawing.Size(75, 23);
            this.buttonGroupBack.TabIndex = 18;
            this.buttonGroupBack.Text = "Atšaukti";
            this.buttonGroupBack.UseVisualStyleBackColor = true;
            this.buttonGroupBack.Click += new System.EventHandler(this.buttonGroupBack_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(63, 64);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(224, 469);
            this.checkedListBox1.TabIndex = 19;
            // 
            // AddStudentsToGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 572);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.buttonGroupBack);
            this.Controls.Add(this.buttonGroupAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxGroupList);
            this.Name = "AddStudentsToGroupForm";
            this.Text = "AddStudentsToGroup";
            this.Load += new System.EventHandler(this.AddStudentsToGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxGroupList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGroupAdd;
        private System.Windows.Forms.Button buttonGroupBack;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}