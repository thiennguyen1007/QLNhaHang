using RestaurantApp.Views;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RestaurantApp.ViewModels
{
    public class StartViewModel : BaseViewModel
    {
        public ICommand LoginCommand => new Command(() => Application.Current.MainPage.Navigation.PushAsync(new LoginPage()));
        public ICommand OrderCommand => new Command(() => Application.Current.MainPage.Navigation.PushAsync(new OrderPage()));
        
    }
}
