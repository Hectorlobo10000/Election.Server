using System;
using System.Collections.Generic;
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
        private List<Sex> _sexList;

        public List<Sex> SexList
        {
            get{return _sexList;}
            set
            {
                _sexList = value;
                NotifyOfPropertyChange(() => SexList);
            }
        }

        public StudentViewModel(MainViewModel mainViewModel, ISexRepository sexRepository)
        {
            mainViewModel.Height = 434;
            mainViewModel.Width = 268;
            SexList = sexRepository.GetAll();
        }

        public void Save(Object content)
        {
            if (Validate.ValidateFields(content) == 0 || Validate.ValidateCombo(content) == 0)
            {
                
            }
        }
    }
}