using System.Windows;
using Caliburn.Micro;
using Elections.Server.Presentation.ViewModels;

namespace Elections.Server.Presentation
{
    public class PresentationBootstrapper : BootstrapperBase
    {

        public PresentationBootstrapper()
        {
            Initialize();
        }

        private static Application _application;

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainViewModel>();
            _application = Application;
            _application.MainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            _application.MainWindow.ResizeMode = ResizeMode.NoResize;
            _application.MainWindow.Title = "Panel de Control";
        }

        public static void SetTitle(string title)
        {
            _application.MainWindow.Title = title;
        }
    }
}