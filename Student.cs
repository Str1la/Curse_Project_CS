using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurseProject
{
    class Student
    {
        // Поля класу
        private string surname;
        private string firstName;
        private string middleName;
        private int birthYear;
        private string specialty;
        private string university;

        // Конструктор ініціалізації
        public Student(string surname, string firstName, string middleName, int birthYear, string specialty, string university)
        {
            this.surname = surname;
            this.firstName = firstName;
            this.middleName = middleName;
            this.birthYear = birthYear;
            this.specialty = specialty;
            this.university = university;
        }

        // Властивості для доступу до полів

        // Властивість для прізвища
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        // Властивість для імені
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        // Властивість для по-батькові
        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        // Властивість для року народження
        public int BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }

        // Властивість для спеціальності
        public string Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }

        // Властивість для університету
        public string University
        {
            get { return university; }
            set { university = value; }
        }

        // Деструктор
        ~Student()
        {
            // Код деструктора (необов'язково)
        }
    }
}
