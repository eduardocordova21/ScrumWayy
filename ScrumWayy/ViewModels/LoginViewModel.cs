using Xamarin.Forms;

namespace ScrumWayy.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private void OnLoginClicked(object obj)
        {
            App.Current.MainPage = new AppShell();
        }
    }
}