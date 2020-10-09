using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DarkModePOC.Common.Styles;
using Xamarin.Forms;
using static DarkModePOC.App;

[assembly: Dependency(typeof(DarkModePOC.Droid.ThemeHelper))]
namespace DarkModePOC.Droid
{
    public class ThemeHelper : IAppTheme
    {
        public void SetAppTheme(App.Theme theme)
        {

            SetTheme(theme);
        }
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