using System;
using System.Windows.Forms;

namespace Elections.Server.Domain.Entities
{
    public class Student
    {
        public int? Index { get; set; } 
        public int Number { get; set; }
        public string Identity { get; set; }

        private string _firstName;
        private string _secondName;
        private string _firstLastName;
        private string _secondLastName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                _firstName = SubString.GetStringFixed(_firstName);
            }
        }

        public string SecondName
        {
            get { return _secondName; }
            set
            {
                _secondName = value;
                _secondName = SubString.GetStringFixed(_secondName);
            }
        }

        public string FirstLastName
        {
            get { return _firstLastName; }
            set
            {
                _firstLastName = value;
                _firstLastName = SubString.GetStringFixed(_firstLastName);
            }
        }

        public string SecondLastName
        {
            get { return _secondLastName; }
            set
            {
                _secondLastName = value;
                _secondLastName = SubString.GetStringFixed(_secondLastName);
            }
        }

        public bool Vote { get; set; }
        public int IdSex { get; set; }
        public int IdGrade { get; set; }
        public int IdSection { get; set; }

        public Student()
        {
            
        }

        public Student(int? index, 
            int number, 
            string identity, 
            string firstName, 
            string secondName, 
            string firstLastName, 
            string secondLastName, 
            bool vote, 
            int idSex, 
            int idGrade, 
            int idSection)
        {
            Index = index;
            Number = number;
            Identity = identity;
            FirstName = firstName;
            SecondName = secondName;
            FirstLastName = firstLastName;
            SecondLastName = secondLastName;
            Vote = vote;
            IdSex = idSex;
            IdGrade = idGrade;
            IdSection = idSection;
        }
    }
}