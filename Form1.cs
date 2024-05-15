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
            dataGridView1.Columns.Add("Surname", "Прізвище");
            dataGridView1.Columns.Add("FirstName", "Ім'я");
            dataGridView1.Columns.Add("MiddleName", "По-батькові");
            dataGridView1.Columns.Add("BirthYear", "Рік народження");
            dataGridView1.Columns.Add("Specialty", "Спеціальність");
            dataGridView1.Columns.Add("University", "Університет");
            dataGridView1.Columns.Add("ThesisTopic", "Тема дипломної роботи");
            dataGridView1.Columns.Add("InternshipPeriod", "Період практики");
            dataGridView1.Columns.Add("DefenseDate", "Дата захисту");
            dataGridView1.Columns.Add("Status", "Статус виконання");

            numericUpDown.Maximum = 2024;
            numericUpDown.Minimum = 2000;

            // Встановлення мінімальної дати до поточної дати
            dateTimePicker.MinDate = new DateTime(2020, 12, 31); 

            // Встановлення максимальної дати до кінця поточного року
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
            // Очищаємо dataGridView
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
                MessageBox.Show(ex.Message, "Некоректно введені дані", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (newStudent != null)
            {
                // Додаємо студента до контейнера
                container.AddStudent(newStudent);

                RefreshDataGridView();

                // Очищаємо поля введення на формі
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
            // Сортуємо студентів за роком народження
            container.SortByBirthYear();

            // Оновлюємо dataGridView з відсортованими даними
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            // Очищаємо dataGridView
            dataGridView1.Rows.Clear();

            // Додаємо оновлені дані з контейнера до dataGridView
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
            // Перевіряємо, чи обраний елемент не є null перед використанням
            if (comboBoxStatus2.SelectedItem != null)
            {
                container.ClearFilter();

                // Отримуємо вибраний статус з комбо-боксу
                ThesisStatus selectedStatus = (ThesisStatus)comboBoxStatus2.SelectedItem;

                // Фільтруємо студентів за вибраним статусом
                container.FilterByStatus(selectedStatus);

                // Оновлюємо dataGridView з відфільтрованими даними
                RefreshDataGridView();
            }
        }

        private void filterByStatus_Click(object sender, EventArgs e)
        {
            // Очистка фільтрації
            container.ClearFilter();

            // Оновлюємо dataGridView з оригінальними даними
            RefreshDataGridView();
        }

        private void WriteToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var student in container)
                {
                    // Записуємо дані про кожного студента у файл
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

            // Оновлюємо контейнер зчитаними даними
            container = new GraduateStudentContainer(students);
            RefreshDataGridView(); // Оновлюємо dataGridView
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
            // Сортуємо студентів за імям
            container.SortByName();

            // Оновлюємо dataGridView з відсортованими даними
            RefreshDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("У моєму проекті демонстрація пізнього зв'язування (late binding) відбувається " +
                "при виклику віртуального методу RefreshDataGridView() в класі форми Form1. Коли ви " +
                "викликаєте цей метод, він перевизначений в класі GraduateStudentContainer, " +
                "і саме там відбувається фактичне викликання методів для оновлення dataGridView. " +
                "Проте ви це робите через посилання на базовий клас IEnumerable<GraduateStudent>, " +
                "що дозволяє змінювати реалізацію методу RefreshDataGridView() у підкласі " +
                "GraduateStudentContainer без необхідності змінювати його в самому класі форми.");
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}
