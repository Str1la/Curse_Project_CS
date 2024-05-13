using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace CurseProject
{
    public partial class Form1 : Form
    {
        GraduateStudentContainer container;

        GraduateStudent student1 = new GraduateStudent("����", "����", "�������������", 1995, "�����������", "�������� �����������", "���� 1", "˳�� 2024", DateTime.Now, ThesisStatus.��������);
        GraduateStudent student2 = new GraduateStudent("������", "�����", "��������", 1996, "������", "��������� �����������", "���� 2", "����� 2024", DateTime.Now, ThesisStatus.��������);
        GraduateStudent student3 = new GraduateStudent("ѳ���", "������", "����������", 1994, "Գ����", "�������� �����������", "���� 3", "���� 2024", DateTime.Now, ThesisStatus.�������);
        GraduateStudent student4 = new GraduateStudent("���������", "����", "�������", 1997, "ճ��", "������������ �����������", "���� 4", "˳�� 2024", DateTime.Now, ThesisStatus.����������);
        GraduateStudent student5 = new GraduateStudent("���������", "����", "����������", 1993, "��������", "���������� �����������", "���� 5", "����� 2024", DateTime.Now, ThesisStatus.�����);

        public Form1()
        {
            InitializeComponent();
            container = new GraduateStudentContainer(new List<GraduateStudent> { student1, student2, student3, student4, student5 });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxStatus.Items.AddRange(Enum.GetValues(typeof(ThesisStatus)).Cast<object>().ToArray());
            comboBoxStatus2.Items.AddRange(Enum.GetValues(typeof(ThesisStatus)).Cast<object>().ToArray());

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.Columns.Add("Surname", "�������");
            dataGridView1.Columns.Add("FirstName", "��'�");
            dataGridView1.Columns.Add("MiddleName", "��-�������");
            dataGridView1.Columns.Add("BirthYear", "г� ����������");
            dataGridView1.Columns.Add("Specialty", "�������������");
            dataGridView1.Columns.Add("University", "�����������");
            dataGridView1.Columns.Add("ThesisTopic", "���� �������� ������");
            dataGridView1.Columns.Add("InternshipPeriod", "����� ��������");
            dataGridView1.Columns.Add("DefenseDate", "���� �������");
            dataGridView1.Columns.Add("Status", "������ ���������");

            numericUpDown.Maximum = 2050;



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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            GraduateStudent newStudent = new GraduateStudent(
                TBsurname.Text,
                TBfirstname.Text,
                TBmiddlename.Text,
                (int)numericUpDown.Value,
                TBspeciality.Text,
                TBuniversity.Text,
                TBthesis.Text,
                TBperid.Text,
                dateTimePicker.Value,
                (ThesisStatus)comboBoxStatus.SelectedItem);

            // ������ �������� �� ����������
            container.AddStudent(newStudent);

            // ������ ���� �������� �� dataGridView
            dataGridView1.Rows.Add(
                newStudent.Surname, newStudent.FirstName,
                newStudent.MiddleName, newStudent.BirthYear,
                newStudent.Specialty, newStudent.University,
                newStudent.ThesisTopic, newStudent.InternshipPeriod,
                newStudent.DefenseDate, newStudent.Status);

            // ������� ���� �������� �� ����
            ClearInputFields();
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

            // ������ �������� ���� � ���������� �� dataGridView
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
    }
}