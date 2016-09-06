using System;
using Caliburn.Micro;
using Elections.Server.Domain.Repositories;

namespace Elections.Server.Presentation.ViewModels
{
    public class MainViewModel : PropertyChangedBase
    {
        private int _height;

        public int Height
        {
            get { return _height; }
            set
            {
                _height = value;
                NotifyOfPropertyChange(() => Height);
            }
        }

        private int _width;

        public int Width
        {
            get { return _width; }
            set
            {
                _width = value;
                NotifyOfPropertyChange(() => Width);
            }
        }

        private Object _screen;

        public Object Screen
        {
            get { return _screen; }
            set
            {
                _screen = value;
                NotifyOfPropertyChange(() => Screen);
            }
        }

        public string Title { get; set; }

        public MainViewModel()
        {
            Screen = new StartViewModel(this);
        }

        public void Main()
        {
            Screen = new StartViewModel(this);
        }

        public void ShowStudent()
        {
            Screen = new StudentViewModel(this, new SexRepository());
        }
    }
}