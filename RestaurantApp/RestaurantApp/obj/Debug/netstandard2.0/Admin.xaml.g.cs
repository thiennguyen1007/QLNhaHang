//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("RestaurantApp.Admin.xaml", "Admin.xaml", typeof(global::RestaurantApp.Admin))]

namespace RestaurantApp {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Admin.xaml")]
    public partial class Admin : global::Xamarin.Forms.Shell {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::RestaurantApp.ViewModels.AdminPageViewModel vm;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.MenuItem Logout;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(Admin));
            vm = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::RestaurantApp.ViewModels.AdminPageViewModel>(this, "vm");
            Logout = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.MenuItem>(this, "Logout");
        }
    }
}
