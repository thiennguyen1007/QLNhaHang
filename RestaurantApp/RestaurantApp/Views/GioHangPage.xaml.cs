using RestaurantApp.Services;
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
    public partial class GioHangPage : ContentPage
    {
        private UserService _service = new UserService();
        public GioHangPage()
        {
            InitializeComponent();
        }
        //public GioHangPage(string SDT)
        //{

        //    if (SDT == null)
        //    {
        //        lb_SDT.Text = "Chua co thong tin";
        //        lb_name.Text = "Chua co thong tin";
        //    }
        //    else {
        //        BindingContext = _service.GetPerson(SDT);
        //    }
            
        //    InitializeComponent();
        //}

    }
}