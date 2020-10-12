﻿using DarkModePOC.Common.Styles;
using Xamarin.Forms;
using static DarkModePOC.App;

[assembly: Dependency(typeof(DarkModePOC.iOS.ThemeHelper))]
namespace DarkModePOC.iOS
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