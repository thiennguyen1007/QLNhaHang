using RestaurantApp.Models;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace RestaurantApp.ViewModels
{
    public class GioHangViewModel
    {
        public GioHangViewModel()
        {
            menuList = GetMenu();
        }
        public List<Pick> menuList { get; }
        //public ICommand DienThongTinCommand => new Command(async () =>
        //{
        //    await Application.Current.MainPage.Navigation.PushAsync(new Views.InforThanhToanPage());
        //});

        private List<Pick> GetMenu()
        {
            return new List<Pick>
            {
                new Pick { Title = "Chicken Rice", Image = "IMG05.png", Desc = "Nhung con ga vung Tay A, mui vi that ngon va tuoi mat", Price = "$23.99" },
                new Pick { Title = "Banana cream", Image = "IMG04.png", Desc = "Kem chuối là món ngon, món quà vặt tuổi thơ quen thuộc của nhiều người…", Price = "$19.99" },
                new Pick { Title = "Juicy Chicken", Image = "IMG01.png", Desc = "Sụn gà rang muối là một món ăn cực kỳ hấp dẫn, được nhiều người yêu thích…", Price = "$25.25" },
                new Pick { Title = "Pizza", Image = "pizza.png", Desc = "Mon an duoc nhieu nguoi yeu thich, nhanh va hoan hao...", Price = "$25.25" },
            };
        }
    }
}
