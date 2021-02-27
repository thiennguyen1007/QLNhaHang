using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestaurantApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Start : ContentPage
    {
        public Start()
        {
            InitializeComponent();
            Task.Run(SpinImg);
            //Routing.RegisterRoute("Admin", typeof(Admin));
        }
        private async void SpinImg()
        {
            while (true)
            {
                await img_banner.RelRotateTo(360, 10000, Easing.BounceOut);              
            }
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //}
        //private async Task Button_Clicked_1Async(object sender, EventArgs e)
        //{            
        //}
        //private async void btn_admin_Clicked(object sender, EventArgs e)
        //{
        //    //var state = Shell.Current.CurrentState;
        //    //await Shell.Current.GoToAsync($"{state.Location}/Admin?name={new RestaurantApp.Admin()}");
        //    //await Navigation.PushAsync(new Admin());
        //}
    }
}