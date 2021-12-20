
namespace akademine_is
{
    partial class AddSubjectForm
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
            this.textBoxSubjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLecturer = new System.Windows.Forms.ComboBox();
            this.textBoxSubjectInfo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSubjectAdd = new System.Windows.Forms.Button();
            this.buttonSubjectBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSubjectName
            // 
            this.textBoxSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubjectName.Location = new System.Drawing.Point(274, 41);
            this.textBoxSubjectName.Name = "textBoxSubjectName";
            this.textBoxSubjectName.Size = new System.Drawing.Size(234, 31);
            this.textBoxSubjectName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dalyko pavadinimas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Atsakingas dėstytojas:";
            // 
            // comboBoxLecturer
            // 
            this.comboBoxLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLecturer.FormattingEnabled = true;
            this.comboBoxLecturer.Location = new System.Drawing.Point(274, 84);
            this.comboBoxLecturer.Name = "comboBoxLecturer";
            this.comboBoxLecturer.Size = new System.Drawing.Size(234, 32);
            this.comboBoxLecturer.TabIndex = 5;
            this.comboBoxLecturer.SelectedIndexChanged += new System.EventHandler(this.comboBoxLecturer_SelectedIndexChanged);
            // 
            // textBoxSubjectInfo
            // 
            this.textBoxSubjectInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubjectInfo.Location = new System.Drawing.Point(274, 125);
            this.textBoxSubjectInfo.Multiline = true;
            this.textBoxSubjectInfo.Name = "textBoxSubjectInfo";
            this.textBoxSubjectInfo.Size = new System.Drawing.Size(234, 72);
            this.textBoxSubjectInfo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(207, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Apie:";
            // 
            // buttonSubjectAdd
            // 
            this.buttonSubjectAdd.Location = new System.Drawing.Point(433, 218);
            this.buttonSubjectAdd.Name = "buttonSubjectAdd";
            this.buttonSubjectAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonSubjectAdd.TabIndex = 14;
            this.buttonSubjectAdd.Text = "Pridėti";
            this.buttonSubjectAdd.UseVisualStyleBackColor = true;
            this.buttonSubjectAdd.Click += new System.EventHandler(this.buttonSubjectAdd_Click);
            // 
            // buttonSubjectBack
            // 
            this.buttonSubjectBack.Location = new System.Drawing.Point(274, 218);
            this.buttonSubjectBack.Name = "buttonSubjectBack";
            this.buttonSubjectBack.Size = new System.Drawing.Size(75, 23);
            this.buttonSubjectBack.TabIndex = 15;
            this.buttonSubjectBack.Text = "Atšaukti";
            this.buttonSubjectBack.UseVisualStyleBackColor = true;
            this.buttonSubjectBack.Click += new System.EventHandler(this.buttonSubjectBack_Click);
            // 
            // AddSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 284);
            this.Controls.Add(this.buttonSubjectBack);
            this.Controls.Add(this.buttonSubjectAdd);
            this.Controls.Add(this.textBoxSubjectInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxLecturer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSubjectName);
            this.Controls.Add(this.label1);
            this.Name = "AddSubjectForm";
            this.Text = "AddSubjectForm";
            this.Load += new System.EventHandler(this.AddSubjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSubjectAdd;
        private System.Windows.Forms.Button buttonSubjectBack;
        internal System.Windows.Forms.TextBox textBoxSubjectName;
        internal System.Windows.Forms.TextBox textBoxSubjectInfo;
        public System.Windows.Forms.ComboBox comboBoxLecturer;
    }
}