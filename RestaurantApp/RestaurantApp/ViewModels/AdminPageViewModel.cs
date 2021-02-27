using RestaurantApp.Views;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RestaurantApp.ViewModels
{
    class AdminPageViewModel : BaseViewModel
    {
        public ICommand LogoutCommand => new Command(() =>
        {
            //Shell.Current.GoToAsync("//Start");
            Task.Delay(2000);
            Application.Current.MainPage.Navigation.PopAsync();          
            Application.Current.MainPage.Navigation.PushAsync(new Start());
        });
    }
}
