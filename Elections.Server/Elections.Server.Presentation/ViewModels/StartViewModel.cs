using Caliburn.Micro;

namespace Elections.Server.Presentation.ViewModels
{
    public class StartViewModel : PropertyChangedBase
    {
        public StartViewModel(MainViewModel mainViewModel)
        {
            mainViewModel.Width = 500;
            mainViewModel.Height = 450;
        }
    }
}