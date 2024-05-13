using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
