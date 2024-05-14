using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public Student() { }

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

        public virtual void DisplayFields()
        {
            Console.WriteLine($"Прізвище: {Surname}");
            Console.WriteLine($"Ім'я: {FirstName}");
            Console.WriteLine($"По-батькові: {MiddleName}");
            Console.WriteLine($"Рік народження: {BirthYear}");
            Console.WriteLine($"Спеціальність: {Specialty}");
            Console.WriteLine($"ВУЗ: {University}");
        }

        // Перевірка на наявність непотрібних символів
        public bool ContainsDigits(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return false; // Якщо знайдено хоча б одну цифру, повертаємо true
                }
            }
            return true; // Якщо жодної цифри не знайдено, повертаємо false
        }

        // Властивості для доступу до полів

        // Властивість для прізвища
        public string Surname
        {
            get { return surname; }
            set {
                if (ContainsDigits(value))
                {
                    surname = value;
                }
                else
                {
                    throw new Exception("Введен некоректне значення прізвища");
                }
            }
        }

        // Властивість для імені
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (ContainsDigits(value))
                {
                    firstName = value;
                }
                else
                {
                    throw new Exception("Введен некоректне значення імені");
                }
            }
        }

        // Властивість для по-батькові
        public string MiddleName
        {
            get { return middleName; }
            set
            {
                if (ContainsDigits(value))
                {
                    middleName = value;
                }
                else
                {
                    throw new Exception("Введен некоректне значення імені");
                }
            }
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
