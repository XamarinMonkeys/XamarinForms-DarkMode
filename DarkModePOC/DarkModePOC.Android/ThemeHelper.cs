using DarkModePOC.Common.Styles;
using DarkModePOC.Droid;
using Xamarin.Forms;
using static DarkModePOC.App;

[assembly: Dependency(typeof(ThemeHelper))]

namespace DarkModePOC.Droid
{
    public class ThemeHelper : IAppTheme
    {
        public void SetAppTheme(Theme theme)
        {
            SetTheme(theme);
        }

        private void SetTheme(Theme mode)
        {
            if (mode == Theme.Dark)
            {
                if (AppTheme == Theme.Dark)
                    return;
                Application.Current.Resources = new DarkTheme();
            }
            else
            {
                if (AppTheme != Theme.Dark)
                    return;
                Application.Current.Resources = new LightTheme();
            }

            AppTheme = mode;
        }
    }
}