using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CurseProject
{
    public partial class Form1 : Form
    {
        GraduateStudentContainer container;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxStatus.Items.AddRange(Enum.GetValues(typeof(ThesisStatus)).Cast<object>().ToArray());
            comboBoxStatus2.Items.AddRange(Enum.GetValues(typeof(ThesisStatus)).Cast<object>().ToArray());
            comboBoxStatus.SelectedIndex = 0;

            container = new GraduateStudentContainer(new List<GraduateStudent> {/*student1, student2, student3, student4, student5*/});

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.Columns.Add("Surname", "�������");
            dataGridView1.Columns.Add("FirstName", "��'�");
            dataGridView1.Columns.Add("MiddleName", "��-�������");
            dataGridView1.Columns.Add("BirthYear", "г� ����������");
            dataGridView1.Columns.Add("Specialty", "������������");
            dataGridView1.Columns.Add("University", "����������");
            dataGridView1.Columns.Add("ThesisTopic", "���� �������� ������");
            dataGridView1.Columns.Add("InternshipPeriod", "����� ��������");
            dataGridView1.Columns.Add("DefenseDate", "���� �������");
            dataGridView1.Columns.Add("Status", "������ ���������");

            numericUpDown.Maximum = 2024;
            numericUpDown.Minimum = 2000;

            // ������������ �������� ���� �� ������� ����
            dateTimePicker.MinDate = new DateTime(2020, 12, 31); 

            // ������������ ����������� ���� �� ���� ��������� ����
            dateTimePicker.MaxDate = new DateTime(2025, 12, 31);



            foreach (var student in container)
            {
                dataGridView1.Rows.Add(
                    student.Surname, student.FirstName,
                    student.MiddleName, student.BirthYear,
                    student.Specialty, student.University,
                    student.ThesisTopic, student.InternshipPeriod,
                    student.DefenseDate, student.Status);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ������� dataGridView
            dataGridView1.Rows.Clear();



            foreach (var student in container)
            {
                dataGridView1.Rows.Add(
                    student.Surname, student.FirstName,
                    student.MiddleName, student.BirthYear,
                    student.Specialty, student.University,
                    student.ThesisTopic, student.InternshipPeriod,
                    student.DefenseDate, student.Status);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GraduateStudent newStudent = new GraduateStudent();
            try
            {
                newStudent.Surname = TBsurname.Text;
                newStudent.FirstName = TBfirstname.Text;
                newStudent.MiddleName = TBmiddlename.Text;
                newStudent.BirthYear = (int)numericUpDown.Value;
                newStudent.Specialty = TBspeciality.Text;
                newStudent.University = TBuniversity.Text;
                newStudent.ThesisTopic = TBthesis.Text;
                newStudent.InternshipPeriod = TBperid.Text;
                newStudent.DefenseDate = dateTimePicker.Value;
                newStudent.Status = (ThesisStatus)comboBoxStatus.SelectedItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "���������� ������ ���", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (newStudent != null)
            {
                // ������ �������� �� ����������
                container.AddStudent(newStudent);

                RefreshDataGridView();

                // ������� ���� �������� �� ����
                ClearInputFields();
            }
        }

        private void ClearInputFields()
        {
            TBsurname.Clear();
            TBfirstname.Clear();
            TBmiddlename.Clear();
            numericUpDown.Value = DateTime.Now.Year;
            TBspeciality.Clear();
            TBuniversity.Clear();
            TBthesis.Clear();
            TBperid.Clear();
            dateTimePicker.Value = DateTime.Now;
            comboBoxStatus.SelectedIndex = 0;
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sortByDate_Click(object sender, EventArgs e)
        {
            // ������� �������� �� ����� ����������
            container.SortByBirthYear();

            // ��������� dataGridView � ������������� ������
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            // ������� dataGridView
            dataGridView1.Rows.Clear();

            // ������ ������� ��� � ���������� �� dataGridView
            foreach (var student in container)
            {
                dataGridView1.Rows.Add(
                    student.Surname, student.FirstName,
                    student.MiddleName, student.BirthYear,
                    student.Specialty, student.University,
                    student.ThesisTopic, student.InternshipPeriod,
                    student.DefenseDate, student.Status);
            }
        }

        private void comboBoxStatus2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ����������, �� ������� ������� �� � null ����� �������������
            if (comboBoxStatus2.SelectedItem != null)
            {
                container.ClearFilter();

                // �������� �������� ������ � �����-�����
                ThesisStatus selectedStatus = (ThesisStatus)comboBoxStatus2.SelectedItem;

                // Գ������� �������� �� �������� ��������
                container.FilterByStatus(selectedStatus);

                // ��������� dataGridView � ��������������� ������
                RefreshDataGridView();
            }
        }

        private void filterByStatus_Click(object sender, EventArgs e)
        {
            // ������� ����������
            container.ClearFilter();

            // ��������� dataGridView � ������������ ������
            RefreshDataGridView();
        }

        private void WriteToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var student in container)
                {
                    // �������� ��� ��� ������� �������� � ����
                    writer.WriteLine($"{student.Surname},{student.FirstName},{student.MiddleName},{student.BirthYear}," +
                                     $"{student.Specialty},{student.University},{student.ThesisTopic},{student.InternshipPeriod}," +
                                     $"{student.DefenseDate},{student.Status}");
                }
            }
        }

        private void ReadFromFile(string fileName)
        {
            List<GraduateStudent> students = new List<GraduateStudent>();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    GraduateStudent student = new GraduateStudent(parts[0], parts[1], parts[2], int.Parse(parts[3]),
                                                                  parts[4], parts[5], parts[6], parts[7],
                                                                  DateTime.Parse(parts[8]), (ThesisStatus)Enum.Parse(typeof(ThesisStatus), parts[9]));
                    students.Add(student);
                }
            }

            // ��������� ��������� ��������� ������
            container = new GraduateStudentContainer(students);
            RefreshDataGridView(); // ��������� dataGridView
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            WriteToFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "students.txt"));
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            ReadFromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "students.txt"));
        }

        private void sortByName_Click(object sender, EventArgs e)
        {
            // ������� �������� �� ����
            container.SortByName();

            // ��������� dataGridView � ������������� ������
            RefreshDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("� ���� ������ ������������ ������� ��'�������� (late binding) ���������� " +
                "��� ������� ����������� ������ RefreshDataGridView() � ���� ����� Form1. ���� �� " +
                "��������� ��� �����, �� �������������� � ���� GraduateStudentContainer, " +
                "� ���� ��� ���������� �������� ���������� ������ ��� ��������� dataGridView. " +
                "����� �� �� ������ ����� ��������� �� ������� ���� IEnumerable<GraduateStudent>, " +
                "�� �������� �������� ��������� ������ RefreshDataGridView() � ������ " +
                "GraduateStudentContainer ��� ����������� �������� ���� � ������ ���� �����.");
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}
