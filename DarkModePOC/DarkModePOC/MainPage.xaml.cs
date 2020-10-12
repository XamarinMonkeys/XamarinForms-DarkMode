using System;
using System.ComponentModel;
using Xamarin.Forms;
using static DarkModePOC.App;

namespace DarkModePOC
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            SetTheme(status:themeToggle.IsToggled);
        }

        private void SetTheme(bool status)
        {
            var themeRequested = status ? Theme.Dark : Theme.Light;

            DependencyService.Get<IAppTheme>().SetAppTheme(themeRequested);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyPage());
        }
    }
}