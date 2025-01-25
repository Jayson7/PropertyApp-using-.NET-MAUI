using PropertyApp.View;

namespace PropertyApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Set the root page inside the CreateWindow method
            return new Window(new NavigationPage(new LandingPage())); // or use AppShell if that's your root
        }
    }
}
