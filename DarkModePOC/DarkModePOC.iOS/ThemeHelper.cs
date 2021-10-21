using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using UIKit;
using DarkModePOC;
using static DarkModePOC.App;
using DarkModePOC.Common.Styles;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;

[assembly:Dependency(typeof(DarkModePOC.iOS.ThemeHelper))]
namespace DarkModePOC.iOS
{
    public class ThemeHelper : IAppTheme
    {
        //Set App Theme
        public void SetAppTheme(App.Theme theme)
        {
            SetTheme(theme);
        }
        //Set Theme 
        void SetTheme(Theme mode)
        {
            if (mode == Theme.Dark)
            {
                if (App.AppTheme == Theme.Dark)
                    return;
                App.Current.Resources = new DarkTheme();
            }
            else
            {
                if (App.AppTheme != Theme.Dark)
                    return;
                App.Current.Resources = new LightTheme();
            }
            App.AppTheme = mode;
        }
    }
}
