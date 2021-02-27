using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RestaurantApp.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Command LoginCommand { get; }
        private string userName;
        private string pass;
        public string UserName
        {
            get => userName;
            set
            {
                userName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("UserName"));
            }
        }
        public string Pass
        {
            get => pass;
            set
            {
                pass = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Pass"));
            }
        }


        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj) /*object obj*/
        {
            //await Shell.Current.GoToAsync($"//{nameof(Admin)}");
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Pass))
                await App.Current.MainPage.DisplayAlert("Empty Values", "Please enter Email and Password", "OK");
            else
            {
                if (UserName == "admin" && Pass == "1234")
                {
                    await App.Current.MainPage.DisplayAlert("Login Success", "", "Ok");
                    await Task.Delay(2000);
                    await Application.Current.MainPage.Navigation.PopAsync();
                     Application.Current.MainPage = new Admin();
                }
                else
                    await App.Current.MainPage.DisplayAlert("Login Fail", "Please enter correct Email and Password", "OK");
            }
        }
        //public ICommand LoginCommand => new Command(() => Application.Current.MainPage = new Admin());
    }
}
