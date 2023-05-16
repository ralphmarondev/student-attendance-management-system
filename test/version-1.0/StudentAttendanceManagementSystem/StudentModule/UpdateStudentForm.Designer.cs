﻿namespace StudentAttendanceManagementSystem.StudentModule
{
    partial class UpdateStudentForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_school_year = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_semester = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_college = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_name_of_guardian = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id_number = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_contact_number = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "College:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aquamarine;
            this.panel2.Controls.Add(this.cb_school_year);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cb_semester);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cb_department);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cb_college);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 161);
            this.panel2.TabIndex = 6;
            // 
            // cb_school_year
            // 
            this.cb_school_year.FormattingEnabled = true;
            this.cb_school_year.Items.AddRange(new object[] {
            "2022-2023",
            "2023-2024",
            "2024-2025",
            "2025-2026",
            "2026-2027",
            "2027-2028",
            "2028-2029"});
            this.cb_school_year.Location = new System.Drawing.Point(258, 113);
            this.cb_school_year.Name = "cb_school_year";
            this.cb_school_year.Size = new System.Drawing.Size(158, 28);
            this.cb_school_year.TabIndex = 17;
            this.cb_school_year.Text = "2022-2023";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(254, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "School Year:";
            // 
            // cb_semester
            // 
            this.cb_semester.FormattingEnabled = true;
            this.cb_semester.Items.AddRange(new object[] {
            "FIRST SEMESTER",
            "SECOND SEMESTER"});
            this.cb_semester.Location = new System.Drawing.Point(44, 113);
            this.cb_semester.Name = "cb_semester";
            this.cb_semester.Size = new System.Drawing.Size(158, 28);
            this.cb_semester.TabIndex = 15;
            this.cb_semester.Text = "FIRST SEMESTER";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Semester:";
            // 
            // cb_department
            // 
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Items.AddRange(new object[] {
            "BSCPE",
            "BSCE",
            "BSEE",
            "BSCHEM"});
            this.cb_department.Location = new System.Drawing.Point(256, 41);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(158, 28);
            this.cb_department.TabIndex = 13;
            this.cb_department.Text = "BSCPE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Department:";
            // 
            // cb_college
            // 
            this.cb_college.FormattingEnabled = true;
            this.cb_college.Items.AddRange(new object[] {
            "COEA",
            "CPAD",
            "CAS",
            "CHK"});
            this.cb_college.Location = new System.Drawing.Point(43, 41);
            this.cb_college.Name = "cb_college";
            this.cb_college.Size = new System.Drawing.Size(158, 28);
            this.cb_college.TabIndex = 1;
            this.cb_college.Text = "COEA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Name of Guardian:";
            // 
            // tb_name_of_guardian
            // 
            this.tb_name_of_guardian.Location = new System.Drawing.Point(30, 343);
            this.tb_name_of_guardian.Name = "tb_name_of_guardian";
            this.tb_name_of_guardian.Size = new System.Drawing.Size(283, 27);
            this.tb_name_of_guardian.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Number:";
            // 
            // tb_id_number
            // 
            this.tb_id_number.Location = new System.Drawing.Point(30, 63);
            this.tb_id_number.Name = "tb_id_number";
            this.tb_id_number.Size = new System.Drawing.Size(283, 27);
            this.tb_id_number.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Contact Number:";
            // 
            // tb_contact_number
            // 
            this.tb_contact_number.Location = new System.Drawing.Point(30, 268);
            this.tb_contact_number.Name = "tb_contact_number";
            this.tb_contact_number.Size = new System.Drawing.Size(283, 27);
            this.tb_contact_number.TabIndex = 7;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(30, 128);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(283, 27);
            this.tb_name.TabIndex = 3;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(30, 196);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(283, 27);
            this.tb_address.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_name_of_guardian);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_id_number);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_contact_number);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_address);
            this.groupBox1.Location = new System.Drawing.Point(59, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 471);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information:";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Orchid;
            this.btn_update.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(30, 400);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(283, 43);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address:";
            // 
            // UpdateStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 663);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateStudentForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_school_year;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_semester;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_college;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_name_of_guardian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id_number;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_contact_number;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}