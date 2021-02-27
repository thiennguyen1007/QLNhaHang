using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestaurantApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Admin : Xamarin.Forms.Shell
    {
        public Admin()
        {
            InitializeComponent();
        }

        //private void Logout_Clicked(object sender, System.EventArgs e)
        //{
        //    Shell.Current.GoToAsync("//Start");
        //}
    }
}