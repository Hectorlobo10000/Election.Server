using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using Caliburn.Micro;
using Elections.Server.Domain.Entities;
using Elections.Server.Domain.Repositories;
using Elections.Server.Domain.Setup;
using Elections.Server.Presentation.Validators;

namespace Elections.Server.Presentation.ViewModels
{
    public class StudentViewModel : PropertyChangedBase
    {
        private object[] _sexList;
        private object[] _gradeList;
        private object[] _sectionList;

        public object[] SexList
        {
            get{return _sexList;}
            set
            {
                _sexList = value;
                NotifyOfPropertyChange(() => SexList);
            }
        }

        public object[] GradeList
        {
            get
            {
                return _gradeList;
            }
            set
            {
                _gradeList = value;
                NotifyOfPropertyChange(() => GradeList);
            }
        }

        public object[] SectionList
        {
            get { return _sectionList; }
            set
            {
                _sectionList = value;
                NotifyOfPropertyChange(() => SectionList);
            }
        }

        private IRepository _repository;

        public StudentViewModel(MainViewModel mainViewModel, IRepository repository)
        {
            mainViewModel.Height = 434;
            mainViewModel.Width = 268;
            SexList = (object[])repository.GetAllStaticFields()[0];
            GradeList = (object[])repository.GetAllStaticFields()[1];
            SectionList = (object[])repository.GetAllStaticFields()[2];

            _repository = repository;
        }

        public void Save(Object content)
        {
            var student = new Student(null, 1, "0301199202603", "hector", "fernando", "lobo", "chavez", false, 1, 1, 1);
            _repository.InsertStudent(student);
            if (Validate.ValidateFields(content) == 0 || Validate.ValidateCombo(content) == 0)
            {
               
            }
        }
    }
}