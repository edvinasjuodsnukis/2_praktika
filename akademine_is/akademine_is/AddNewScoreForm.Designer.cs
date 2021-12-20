
namespace akademine_is
{
    partial class AddNewScoreForm
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
            this.textBoxPazymys = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxLecturer = new System.Windows.Forms.ComboBox();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.buttonScoreBack = new System.Windows.Forms.Button();
            this.buttonScoreAdd = new System.Windows.Forms.Button();
            this.dateTimePickerScore = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxPazymys
            // 
            this.textBoxPazymys.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPazymys.Location = new System.Drawing.Point(147, 20);
            this.textBoxPazymys.Name = "textBoxPazymys";
            this.textBoxPazymys.Size = new System.Drawing.Size(51, 31);
            this.textBoxPazymys.TabIndex = 5;
            this.textBoxPazymys.TextChanged += new System.EventHandler(this.textBoxSubjectName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pazymys:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Destytojas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Studentas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dalykas:";
            // 
            // comboBoxLecturer
            // 
            this.comboBoxLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLecturer.FormattingEnabled = true;
            this.comboBoxLecturer.Location = new System.Drawing.Point(147, 116);
            this.comboBoxLecturer.Name = "comboBoxLecturer";
            this.comboBoxLecturer.Size = new System.Drawing.Size(208, 33);
            this.comboBoxLecturer.TabIndex = 13;
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(147, 157);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(208, 33);
            this.comboBoxStudent.TabIndex = 14;
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(147, 199);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(208, 33);
            this.comboBoxSubject.TabIndex = 15;
            // 
            // buttonScoreBack
            // 
            this.buttonScoreBack.Location = new System.Drawing.Point(147, 273);
            this.buttonScoreBack.Name = "buttonScoreBack";
            this.buttonScoreBack.Size = new System.Drawing.Size(75, 23);
            this.buttonScoreBack.TabIndex = 20;
            this.buttonScoreBack.Text = "Atšaukti";
            this.buttonScoreBack.UseVisualStyleBackColor = true;
            this.buttonScoreBack.Click += new System.EventHandler(this.buttonScoreBack_Click);
            // 
            // buttonScoreAdd
            // 
            this.buttonScoreAdd.Location = new System.Drawing.Point(280, 273);
            this.buttonScoreAdd.Name = "buttonScoreAdd";
            this.buttonScoreAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonScoreAdd.TabIndex = 19;
            this.buttonScoreAdd.Text = "Pridėti";
            this.buttonScoreAdd.UseVisualStyleBackColor = true;
            this.buttonScoreAdd.Click += new System.EventHandler(this.buttonScoreAdd_Click);
            // 
            // dateTimePickerScore
            // 
            this.dateTimePickerScore.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerScore.Location = new System.Drawing.Point(147, 75);
            this.dateTimePickerScore.Name = "dateTimePickerScore";
            this.dateTimePickerScore.Size = new System.Drawing.Size(234, 20);
            this.dateTimePickerScore.TabIndex = 21;
            // 
            // AddNewScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 355);
            this.Controls.Add(this.dateTimePickerScore);
            this.Controls.Add(this.buttonScoreBack);
            this.Controls.Add(this.buttonScoreAdd);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.comboBoxLecturer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPazymys);
            this.Controls.Add(this.label1);
            this.Name = "AddNewScoreForm";
            this.Text = "AddNewScoreForm";
            this.Load += new System.EventHandler(this.AddNewScoreForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox textBoxPazymys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxLecturer;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Button buttonScoreBack;
        private System.Windows.Forms.Button buttonScoreAdd;
        internal System.Windows.Forms.DateTimePicker dateTimePickerScore;
    }
}