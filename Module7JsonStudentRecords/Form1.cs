
using System.Text.Json;

namespace Module7JsonStudentRecords
{
    public partial class Form1 : Form
    {
        private List<Student> students = [];

        public Form1()
        {
            InitializeComponent();
            RefreshInputs();
        }

        void AddStudent()
        {
           students.Add(new() {
               StudentId = (int)nudStudentId.Value,
               FirstName = txtFirstName.Text,
               LastName = txtLastName.Text,
               ProgramName = txtProgram.Text,
               GPA = (double)nudGPA.Value
           });
        }
        bool ValidateInput()
        {
            return nudStudentId.Value >= 0
                && students.All(x => x.StudentId != nudStudentId.Value)
                && nudGPA.Value is >= 0 and <= 4
                && !string.IsNullOrWhiteSpace(txtFirstName.Text)
                && !string.IsNullOrWhiteSpace(txtLastName.Text)
                && !string.IsNullOrWhiteSpace(txtProgram.Text);
        }

        void SaveStudents()
        {
            using var dialog = new SaveFileDialog
            {
                Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*"
            };
            if (dialog.ShowDialog() != DialogResult.OK) return;
            try
            {
                using var fileStream = dialog.OpenFile();
                var json = JsonSerializer.Serialize(students);
                using var writer = new StreamWriter(fileStream);
                writer.Write(json);
            }
            catch (ArgumentException exn)
            {
                MessageBox.Show(exn.Message);
            }
        }

        void LoadStudents()
        {
            using var dialog = new OpenFileDialog
            {
                Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*"
            };
            if (dialog.ShowDialog() != DialogResult.OK) return;
            try
            {
                using var fileStream = dialog.OpenFile();
                using var reader = new StreamReader(fileStream);
                var json = reader.ReadToEnd();
                students = JsonSerializer.Deserialize<List<Student>>(json)
                    ?? throw new ArgumentException("Invalid JSON data.");
                RefreshStudentList();
            }
            catch (ArgumentException exn)
            {
                MessageBox.Show(exn.Message);
            }
        }

        void ClearInputFields()
        {
            nudStudentId.Value = 0;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtProgram.Text = "";
        }

        void RefreshStudentList()
        {
            dgvStudents.DataSource = typeof(List<Student>);
            dgvStudents.DataSource = students;
        }

        void RefreshInputs()
        {
            var valid = ValidateInput();
            btnAddStudent.Enabled = valid;
            var status = "";
            if (valid)
            {
                status = "Ready to add student.";
            }
            else
            {
                status = "Missing: ";
                if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    status += "First Name, ";
                }
                if (string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    status += "Last Name, ";
                }
                if (string.IsNullOrWhiteSpace(txtProgram.Text))
                {
                    status += "Program, ";
                }
                status = status.TrimEnd(',', ' ');
            }
            toolStripStatusLabel1.Text = status;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent();
            ClearInputFields();
            RefreshStudentList();
        }

        private void btnLoadJson_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            SaveStudents();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            RefreshInputs();
        }

        private void txtProgram_TextChanged(object sender, EventArgs e)
        {
            RefreshInputs();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            RefreshInputs();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            RefreshInputs();
        }

        private void nudStudentId_ValueChanged(object sender, EventArgs e)
        {
            RefreshInputs();
        }
    }
}
