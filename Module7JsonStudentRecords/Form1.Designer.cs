namespace Module7JsonStudentRecords
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            nudStudentId = new NumericUpDown();
            btnAddStudent = new Button();
            btnSaveJson = new Button();
            btnLoadJson = new Button();
            dgvStudents = new DataGridView();
            btnClear = new Button();
            lblGPA = new Label();
            nudGPA = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblStudentId = new Label();
            txtProgram = new TextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)nudStudentId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGPA).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.Location = new Point(101, 45);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(489, 27);
            txtFirstName.TabIndex = 1;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.Location = new Point(101, 78);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(490, 27);
            txtLastName.TabIndex = 2;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // nudStudentId
            // 
            nudStudentId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudStudentId.Location = new Point(100, 12);
            nudStudentId.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            nudStudentId.Name = "nudStudentId";
            nudStudentId.Size = new Size(489, 27);
            nudStudentId.TabIndex = 0;
            nudStudentId.ValueChanged += nudStudentId_ValueChanged;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Enabled = false;
            btnAddStudent.Location = new Point(168, 193);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(151, 29);
            btnAddStudent.TabIndex = 6;
            btnAddStudent.Text = "add student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnSaveJson
            // 
            btnSaveJson.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSaveJson.Location = new Point(168, 496);
            btnSaveJson.Name = "btnSaveJson";
            btnSaveJson.Size = new Size(151, 29);
            btnSaveJson.TabIndex = 9;
            btnSaveJson.Text = "save json";
            btnSaveJson.UseVisualStyleBackColor = true;
            btnSaveJson.Click += btnSaveJson_Click;
            // 
            // btnLoadJson
            // 
            btnLoadJson.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLoadJson.Location = new Point(10, 496);
            btnLoadJson.Name = "btnLoadJson";
            btnLoadJson.Size = new Size(151, 29);
            btnLoadJson.TabIndex = 8;
            btnLoadJson.Text = "load json";
            btnLoadJson.UseVisualStyleBackColor = true;
            btnLoadJson.Click += btnLoadJson_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToOrderColumns = true;
            dgvStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvStudents.BorderStyle = BorderStyle.None;
            dgvStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.EnableHeadersVisualStyles = false;
            dgvStudents.Location = new Point(10, 228);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(581, 264);
            dgvStudents.TabIndex = 7;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 193);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(151, 29);
            btnClear.TabIndex = 5;
            btnClear.Text = "clear fields";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.Location = new Point(12, 149);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(39, 20);
            lblGPA.TabIndex = 10;
            lblGPA.Text = "GPA:";
            // 
            // nudGPA
            // 
            nudGPA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudGPA.DecimalPlaces = 2;
            nudGPA.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudGPA.Location = new Point(102, 145);
            nudGPA.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            nudGPA.Name = "nudGPA";
            nudGPA.Size = new Size(489, 27);
            nudGPA.TabIndex = 4;
            nudGPA.Value = new decimal(new int[] { 4, 0, 0, 0 });
            nudGPA.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 116);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 12;
            label1.Text = "Program:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 13;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 48);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 13;
            label3.Text = "First Name:";
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(12, 15);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(82, 20);
            lblStudentId.TabIndex = 13;
            lblStudentId.Text = "Student ID:";
            // 
            // txtProgram
            // 
            txtProgram.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProgram.Location = new Point(101, 112);
            txtProgram.Name = "txtProgram";
            txtProgram.Size = new Size(490, 27);
            txtProgram.TabIndex = 3;
            txtProgram.TextChanged += txtProgram_TextChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 526);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(603, 26);
            statusStrip1.TabIndex = 14;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(151, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 552);
            Controls.Add(statusStrip1);
            Controls.Add(lblStudentId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudGPA);
            Controls.Add(lblGPA);
            Controls.Add(dgvStudents);
            Controls.Add(btnClear);
            Controls.Add(btnLoadJson);
            Controls.Add(btnSaveJson);
            Controls.Add(btnAddStudent);
            Controls.Add(nudStudentId);
            Controls.Add(txtProgram);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudStudentId).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGPA).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private NumericUpDown nudStudentId;
        private Button btnAddStudent;
        private Button btnSaveJson;
        private Button btnLoadJson;
        private DataGridView dgvStudents;
        private Button btnClear;
        private Label lblGPA;
        private NumericUpDown nudGPA;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblStudentId;
        private TextBox txtProgram;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
