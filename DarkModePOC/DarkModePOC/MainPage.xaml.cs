using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //var toggleStatus = themeToggle.IsToggled;
            //SetTheme(toggleStatus);
            
        }

        void SetTheme(bool status)
        {
            Theme themeRequested;
            if (status)
            {
                 themeRequested = Theme.Dark;
            }
            else
            {
                themeRequested = Theme.Light;
            }

            DependencyService.Get<IAppTheme>().SetAppTheme(themeRequested);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyPage());
        }
    }
}
