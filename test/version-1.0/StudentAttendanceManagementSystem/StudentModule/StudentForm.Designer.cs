namespace StudentAttendanceManagementSystem.StudentModule
{
    partial class StudentForm
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
            this.dgv_classes_lists = new System.Windows.Forms.DataGridView();
            this.btn_search_student = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_student_id_search = new System.Windows.Forms.Label();
            this.tb_student_id_search = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_delete_student = new System.Windows.Forms.Button();
            this.btn_add_student = new System.Windows.Forms.Button();
            this.btn_update_student = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classes_lists)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_classes_lists
            // 
            this.dgv_classes_lists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_classes_lists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_classes_lists.Location = new System.Drawing.Point(0, 0);
            this.dgv_classes_lists.Name = "dgv_classes_lists";
            this.dgv_classes_lists.RowHeadersWidth = 51;
            this.dgv_classes_lists.RowTemplate.Height = 24;
            this.dgv_classes_lists.Size = new System.Drawing.Size(897, 549);
            this.dgv_classes_lists.TabIndex = 0;
            this.dgv_classes_lists.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_classes_lists_CellContentClick);
            // 
            // btn_search_student
            // 
            this.btn_search_student.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_student.Location = new System.Drawing.Point(720, 13);
            this.btn_search_student.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search_student.Name = "btn_search_student";
            this.btn_search_student.Size = new System.Drawing.Size(173, 45);
            this.btn_search_student.TabIndex = 9;
            this.btn_search_student.Text = "Search";
            this.btn_search_student.UseVisualStyleBackColor = true;
            this.btn_search_student.Click += new System.EventHandler(this.btn_search_student_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.lbl_student_id_search);
            this.panel1.Controls.Add(this.tb_student_id_search);
            this.panel1.Controls.Add(this.btn_search_student);
            this.panel1.Location = new System.Drawing.Point(224, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 71);
            this.panel1.TabIndex = 25;
            // 
            // lbl_student_id_search
            // 
            this.lbl_student_id_search.AutoSize = true;
            this.lbl_student_id_search.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_student_id_search.Location = new System.Drawing.Point(521, 13);
            this.lbl_student_id_search.Name = "lbl_student_id_search";
            this.lbl_student_id_search.Size = new System.Drawing.Size(107, 17);
            this.lbl_student_id_search.TabIndex = 11;
            this.lbl_student_id_search.Text = "Student ID:";
            // 
            // tb_student_id_search
            // 
            this.tb_student_id_search.Location = new System.Drawing.Point(525, 31);
            this.tb_student_id_search.Name = "tb_student_id_search";
            this.tb_student_id_search.Size = new System.Drawing.Size(180, 27);
            this.tb_student_id_search.TabIndex = 10;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_back.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(22, 569);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(173, 45);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_refresh.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(22, 129);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(173, 45);
            this.btn_refresh.TabIndex = 6;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_delete_student
            // 
            this.btn_delete_student.BackColor = System.Drawing.Color.DeepPink;
            this.btn_delete_student.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_student.Location = new System.Drawing.Point(22, 181);
            this.btn_delete_student.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete_student.Name = "btn_delete_student";
            this.btn_delete_student.Size = new System.Drawing.Size(173, 45);
            this.btn_delete_student.TabIndex = 8;
            this.btn_delete_student.Text = "DELETE STUDENTS";
            this.btn_delete_student.UseVisualStyleBackColor = false;
            this.btn_delete_student.Click += new System.EventHandler(this.btn_delete_student_Click);
            // 
            // btn_add_student
            // 
            this.btn_add_student.BackColor = System.Drawing.Color.Lime;
            this.btn_add_student.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_student.Location = new System.Drawing.Point(22, 22);
            this.btn_add_student.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_student.Name = "btn_add_student";
            this.btn_add_student.Size = new System.Drawing.Size(173, 45);
            this.btn_add_student.TabIndex = 0;
            this.btn_add_student.Text = "ADD STUDENT";
            this.btn_add_student.UseVisualStyleBackColor = false;
            this.btn_add_student.Click += new System.EventHandler(this.btn_add_class_Click);
            // 
            // btn_update_student
            // 
            this.btn_update_student.BackColor = System.Drawing.Color.HotPink;
            this.btn_update_student.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_student.Location = new System.Drawing.Point(22, 77);
            this.btn_update_student.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update_student.Name = "btn_update_student";
            this.btn_update_student.Size = new System.Drawing.Size(173, 45);
            this.btn_update_student.TabIndex = 7;
            this.btn_update_student.Text = "UPDATE STUDENT";
            this.btn_update_student.UseVisualStyleBackColor = false;
            this.btn_update_student.Click += new System.EventHandler(this.btn_update_student_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_classes_lists);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(224, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 549);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_back);
            this.panel3.Controls.Add(this.btn_refresh);
            this.panel3.Controls.Add(this.btn_delete_student);
            this.panel3.Controls.Add(this.btn_add_student);
            this.panel3.Controls.Add(this.btn_update_student);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 626);
            this.panel3.TabIndex = 24;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classes_lists)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_classes_lists;
        private System.Windows.Forms.Button btn_search_student;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_student_id_search;
        private System.Windows.Forms.TextBox tb_student_id_search;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_delete_student;
        private System.Windows.Forms.Button btn_add_student;
        private System.Windows.Forms.Button btn_update_student;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}