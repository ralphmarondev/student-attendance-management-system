namespace StudentAttendanceManagementSystem.ClassModule
{
    partial class UpdateClassForm
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
            this.gb_add_class = new System.Windows.Forms.GroupBox();
            this.cb_semester_add = new System.Windows.Forms.ComboBox();
            this.btn_finish_add = new System.Windows.Forms.Button();
            this.tb_school_year_add = new System.Windows.Forms.TextBox();
            this.lbl_school_year_add = new System.Windows.Forms.Label();
            this.lbl_semester_add = new System.Windows.Forms.Label();
            this.tb_subject_name_add = new System.Windows.Forms.TextBox();
            this.lbl_subject_name_add = new System.Windows.Forms.Label();
            this.tb_subject_code_add = new System.Windows.Forms.TextBox();
            this.lbl_subject_code_add = new System.Windows.Forms.Label();
            this.gb_add_class.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_add_class
            // 
            this.gb_add_class.BackColor = System.Drawing.Color.LightCyan;
            this.gb_add_class.Controls.Add(this.cb_semester_add);
            this.gb_add_class.Controls.Add(this.btn_finish_add);
            this.gb_add_class.Controls.Add(this.tb_school_year_add);
            this.gb_add_class.Controls.Add(this.lbl_school_year_add);
            this.gb_add_class.Controls.Add(this.lbl_semester_add);
            this.gb_add_class.Controls.Add(this.tb_subject_name_add);
            this.gb_add_class.Controls.Add(this.lbl_subject_name_add);
            this.gb_add_class.Controls.Add(this.tb_subject_code_add);
            this.gb_add_class.Controls.Add(this.lbl_subject_code_add);
            this.gb_add_class.Location = new System.Drawing.Point(29, 22);
            this.gb_add_class.Name = "gb_add_class";
            this.gb_add_class.Size = new System.Drawing.Size(407, 495);
            this.gb_add_class.TabIndex = 2;
            this.gb_add_class.TabStop = false;
            // 
            // cb_semester_add
            // 
            this.cb_semester_add.Font = new System.Drawing.Font("Courier New", 12F);
            this.cb_semester_add.FormattingEnabled = true;
            this.cb_semester_add.Items.AddRange(new object[] {
            "First Semester",
            "Second Semester"});
            this.cb_semester_add.Location = new System.Drawing.Point(25, 244);
            this.cb_semester_add.Name = "cb_semester_add";
            this.cb_semester_add.Size = new System.Drawing.Size(357, 30);
            this.cb_semester_add.TabIndex = 9;
            // 
            // btn_finish_add
            // 
            this.btn_finish_add.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_finish_add.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finish_add.Location = new System.Drawing.Point(25, 396);
            this.btn_finish_add.Name = "btn_finish_add";
            this.btn_finish_add.Size = new System.Drawing.Size(357, 52);
            this.btn_finish_add.TabIndex = 8;
            this.btn_finish_add.Text = "UPDATE";
            this.btn_finish_add.UseVisualStyleBackColor = false;
            this.btn_finish_add.Click += new System.EventHandler(this.btn_finish_add_Click);
            // 
            // tb_school_year_add
            // 
            this.tb_school_year_add.Font = new System.Drawing.Font("Courier New", 12F);
            this.tb_school_year_add.Location = new System.Drawing.Point(25, 321);
            this.tb_school_year_add.Name = "tb_school_year_add";
            this.tb_school_year_add.Size = new System.Drawing.Size(357, 30);
            this.tb_school_year_add.TabIndex = 7;
            // 
            // lbl_school_year_add
            // 
            this.lbl_school_year_add.AutoSize = true;
            this.lbl_school_year_add.Font = new System.Drawing.Font("Courier New", 9F);
            this.lbl_school_year_add.Location = new System.Drawing.Point(21, 289);
            this.lbl_school_year_add.Name = "lbl_school_year_add";
            this.lbl_school_year_add.Size = new System.Drawing.Size(116, 17);
            this.lbl_school_year_add.TabIndex = 6;
            this.lbl_school_year_add.Text = "School Year:";
            // 
            // lbl_semester_add
            // 
            this.lbl_semester_add.AutoSize = true;
            this.lbl_semester_add.Font = new System.Drawing.Font("Courier New", 9F);
            this.lbl_semester_add.Location = new System.Drawing.Point(22, 213);
            this.lbl_semester_add.Name = "lbl_semester_add";
            this.lbl_semester_add.Size = new System.Drawing.Size(89, 17);
            this.lbl_semester_add.TabIndex = 4;
            this.lbl_semester_add.Text = "Semester:";
            // 
            // tb_subject_name_add
            // 
            this.tb_subject_name_add.Font = new System.Drawing.Font("Courier New", 12F);
            this.tb_subject_name_add.Location = new System.Drawing.Point(25, 157);
            this.tb_subject_name_add.Name = "tb_subject_name_add";
            this.tb_subject_name_add.Size = new System.Drawing.Size(357, 30);
            this.tb_subject_name_add.TabIndex = 3;
            // 
            // lbl_subject_name_add
            // 
            this.lbl_subject_name_add.AutoSize = true;
            this.lbl_subject_name_add.Font = new System.Drawing.Font("Courier New", 9F);
            this.lbl_subject_name_add.Location = new System.Drawing.Point(21, 125);
            this.lbl_subject_name_add.Name = "lbl_subject_name_add";
            this.lbl_subject_name_add.Size = new System.Drawing.Size(125, 17);
            this.lbl_subject_name_add.TabIndex = 2;
            this.lbl_subject_name_add.Text = "Subject Name:";
            // 
            // tb_subject_code_add
            // 
            this.tb_subject_code_add.Font = new System.Drawing.Font("Courier New", 12F);
            this.tb_subject_code_add.Location = new System.Drawing.Point(25, 71);
            this.tb_subject_code_add.Name = "tb_subject_code_add";
            this.tb_subject_code_add.Size = new System.Drawing.Size(357, 30);
            this.tb_subject_code_add.TabIndex = 1;
            // 
            // lbl_subject_code_add
            // 
            this.lbl_subject_code_add.AutoSize = true;
            this.lbl_subject_code_add.Font = new System.Drawing.Font("Courier New", 9F);
            this.lbl_subject_code_add.Location = new System.Drawing.Point(21, 39);
            this.lbl_subject_code_add.Name = "lbl_subject_code_add";
            this.lbl_subject_code_add.Size = new System.Drawing.Size(125, 17);
            this.lbl_subject_code_add.TabIndex = 0;
            this.lbl_subject_code_add.Text = "Subject Code:";
            // 
            // UpdateClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 540);
            this.Controls.Add(this.gb_add_class);
            this.Name = "UpdateClassForm";
            this.Text = "UpdateClassForm";
            this.Load += new System.EventHandler(this.UpdateClassForm_Load);
            this.gb_add_class.ResumeLayout(false);
            this.gb_add_class.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_add_class;
        private System.Windows.Forms.ComboBox cb_semester_add;
        private System.Windows.Forms.Button btn_finish_add;
        private System.Windows.Forms.TextBox tb_school_year_add;
        private System.Windows.Forms.Label lbl_school_year_add;
        private System.Windows.Forms.Label lbl_semester_add;
        private System.Windows.Forms.TextBox tb_subject_name_add;
        private System.Windows.Forms.Label lbl_subject_name_add;
        private System.Windows.Forms.TextBox tb_subject_code_add;
        private System.Windows.Forms.Label lbl_subject_code_add;
    }
}