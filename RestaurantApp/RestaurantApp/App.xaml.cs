using RestaurantApp.Views;
using Xamarin.Forms;

namespace RestaurantApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Device.SetFlags(new[] { "Shapes_Experimental", "Brush_Experimental" });
            //DependencyService.Register<MockDataStore>();          
            MainPage = new NavigationPage(new Start());
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
