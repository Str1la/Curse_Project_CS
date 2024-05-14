using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurseProject
{
    class GraduateStudentContainer : IEnumerable<GraduateStudent>
    {
        private List<GraduateStudent> students; // Список об'єктів класу GraduateStudent
        private List<GraduateStudent> originalStudents;

        // Конструктор
        public GraduateStudentContainer(List<GraduateStudent> students)
        {
            this.students = students;
            originalStudents = new List<GraduateStudent>(students);
        }

        // Метод для додавання студента до контейнера
        public void AddStudent(GraduateStudent student)
        {
            if (student.BirthYear > 2024)
            {
                MessageBox.Show("Рік народження не може бути більшим за теперешній");
            }
            else if (student.Surname != null)
            {
                MessageBox.Show("Не введено призвище");
            }
            else if (student.FirstName != null)
            {
                MessageBox.Show("Не введено ім'я");
            }
            else if (student.MiddleName != null)
            {
                MessageBox.Show("Не введено по батькові");
            }
            else if (student.Specialty != null)
            {
                MessageBox.Show("Не введено спеціальність");
            }
            else if (student.University != null)
            {
                MessageBox.Show("Не введено навчальний заклад");
            }
            else if (student.ThesisTopic != null)
            {
                MessageBox.Show("Не введено тему дипломної");
            }
            else if (student.InternshipPeriod != null)
            {
                MessageBox.Show("Не введено період проходження практики");
            }

            else
            {
                students.Add(student);
            }
            
        }

        // Метод для сортування дипломників за роком народження (за зростанням)
        public void SortByBirthYear()
        {
            students = students.OrderBy(s => s.BirthYear).ToList();
        }

        // Метод для сортування дипломників за імям
        public void SortByName()
        {
            students = students.OrderBy(s => s.FirstName).ToList();
        }

        // Метод для фільтрування дипломників за статусом виконання дипломної роботи
        public void FilterByStatus(ThesisStatus status)
        {
            students = students.Where(s => s.Status == status).ToList();
        }

        public void ClearFilter()
        {
            // Повертаємо список студентів до початкового стану
            students = new List<GraduateStudent>(originalStudents);
        }

        // Реалізація інтерфейсу IEnumerable для побудови ітератора
        public IEnumerator<GraduateStudent> GetEnumerator()
        {
            return students.GetEnumerator(); // Повертаємо ітератор для елементів класу GraduateStudent
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); // Повертаємо ітератор для елементів класу GraduateStudent
        }
    }

}
