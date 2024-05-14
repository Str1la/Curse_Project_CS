using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseProject
{
    public enum ThesisStatus
    {
        Узгодження,
        ВПроцесі,
        Здано,
        Допущено,
        Захищено
    }

    class GraduateStudent : Student
    {
        // Поля класу GraduateStudent
        private string thesisTopic;
        private string internshipPeriod;
        private DateTime defenseDate;
        private ThesisStatus status;

        public GraduateStudent() { }

        // Конструктор ініціалізації
        public GraduateStudent(string surname, string firstName, string middleName, int birthYear, string specialty, string university,
                                string thesisTopic, string internshipPeriod, DateTime defenseDate, ThesisStatus status)
            : base(surname, firstName, middleName, birthYear, specialty, university)
        {
            this.thesisTopic = thesisTopic;
            this.internshipPeriod = internshipPeriod;
            this.defenseDate = defenseDate;
            this.status = status;
        }

        // Конструктор копіювання
        public GraduateStudent(GraduateStudent other) : base(other)
        {
            // Копіюємо значення всіх полів з іншого об'єкта GraduateStudent
            ThesisTopic = other.ThesisTopic;
            InternshipPeriod = other.InternshipPeriod;
            DefenseDate = other.DefenseDate;
            Status = other.Status;
        }

        // Перевантаження оператору виведення
        public static void PrintGraduateStudentInfo(GraduateStudent student)
        {
            PrintStudentInfo(student); // Виводимо інформацію про студента (виклик методу базового класу)

            Console.WriteLine($"Тема дипломної роботи: {student.ThesisTopic}");
            Console.WriteLine($"Період практики: {student.InternshipPeriod}");
            Console.WriteLine($"Дата захисту: {student.DefenseDate}");
            Console.WriteLine($"Статус: {student.Status}");
        }

        // Перевантаження оператору введення
        public static GraduateStudent ReadGraduateStudentInfo()
        {
            Console.WriteLine("Введіть інформацію про студента:");

            Student baseStudent = ReadStudentInfo(); // Виклик методу базового класу

            Console.Write("Введіть тему дипломної роботи: ");
            string thesisTopic = Console.ReadLine();

            Console.Write("Введіть період практики: ");
            string internshipPeriod = Console.ReadLine();

            Console.Write("Введіть дату захисту: ");
            DateTime defenseDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Введіть статус: ");
            string statusString = Console.ReadLine();
            ThesisStatus status = (ThesisStatus)Enum.Parse(typeof(ThesisStatus), statusString);

            return new GraduateStudent(baseStudent.Surname, baseStudent.FirstName, baseStudent.MiddleName,
                                        baseStudent.BirthYear, baseStudent.Specialty, baseStudent.University,
                                        thesisTopic, internshipPeriod, defenseDate, status);
        }

        // Перевизначення віртуального методу для виведення полів класу
        public override void DisplayFields()
        {
            base.DisplayFields(); // Викликаємо базовий метод для виведення полів батьківського класу
            Console.WriteLine($"Тема дипломної роботи: {ThesisTopic}");
            Console.WriteLine($"Терміни проходження практики: {InternshipPeriod}");
            Console.WriteLine($"Дата захисту роботи: {DefenseDate}");
            Console.WriteLine($"Стан виконання дипломної роботи: {Status}");
        }

        // Властивості для доступу до полів

        // Властивість для теми дипломної роботи
        public string ThesisTopic
        {
            get { return thesisTopic; }
            set { thesisTopic = value; }
        }

        // Властивість для періоду проходження практики
        public string InternshipPeriod
        {
            get { return internshipPeriod; }
            set { internshipPeriod = value; }
        }

        // Властивість для дати захисту роботи
        public DateTime DefenseDate
        {
            get { return defenseDate; }
            set { defenseDate = value; }
        }

        // Властивість для статусу виконання дипломної роботи
        public ThesisStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        // Деструктор
        ~GraduateStudent()
        {
            // Код деструктора (необов'язково)
        }
    }
}
