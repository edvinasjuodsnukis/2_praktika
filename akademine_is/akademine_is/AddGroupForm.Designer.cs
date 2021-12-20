
namespace akademine_is
{
    partial class AddGroupForm
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
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGroupMaxCapacity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGroupBack = new System.Windows.Forms.Button();
            this.buttonGroupAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroupName.Location = new System.Drawing.Point(289, 51);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(234, 31);
            this.textBoxGroupName.TabIndex = 5;
            this.textBoxGroupName.TextChanged += new System.EventHandler(this.textBoxSubjectName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Grupes pavadinimas:";
            // 
            // textBoxGroupMaxCapacity
            // 
            this.textBoxGroupMaxCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroupMaxCapacity.Location = new System.Drawing.Point(289, 106);
            this.textBoxGroupMaxCapacity.Name = "textBoxGroupMaxCapacity";
            this.textBoxGroupMaxCapacity.Size = new System.Drawing.Size(234, 31);
            this.textBoxGroupMaxCapacity.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Grupes maksimali talpa:";
            // 
            // buttonGroupBack
            // 
            this.buttonGroupBack.Location = new System.Drawing.Point(289, 158);
            this.buttonGroupBack.Name = "buttonGroupBack";
            this.buttonGroupBack.Size = new System.Drawing.Size(75, 23);
            this.buttonGroupBack.TabIndex = 17;
            this.buttonGroupBack.Text = "Atšaukti";
            this.buttonGroupBack.UseVisualStyleBackColor = true;
            // 
            // buttonGroupAdd
            // 
            this.buttonGroupAdd.Location = new System.Drawing.Point(448, 158);
            this.buttonGroupAdd.Name = "buttonGroupAdd";
            this.buttonGroupAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonGroupAdd.TabIndex = 16;
            this.buttonGroupAdd.Text = "Pridėti";
            this.buttonGroupAdd.UseVisualStyleBackColor = true;
            this.buttonGroupAdd.Click += new System.EventHandler(this.buttonGroupAdd_Click);
            // 
            // AddGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 216);
            this.Controls.Add(this.buttonGroupBack);
            this.Controls.Add(this.buttonGroupAdd);
            this.Controls.Add(this.textBoxGroupMaxCapacity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxGroupName);
            this.Controls.Add(this.label1);
            this.Name = "AddGroupForm";
            this.Text = "AddGroupForm";
            this.Load += new System.EventHandler(this.AddGroupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox textBoxGroupMaxCapacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGroupBack;
        private System.Windows.Forms.Button buttonGroupAdd;
    }
}