using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DarkModePOC.Common.Styles;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using static DarkModePOC.App;

//[assembly: ExportRenderer(typeof(ContentPage), typeof(DarkModePOC.Droid.PageRenderer))]
namespace DarkModePOC.Droid
{
    public class PageRenderer: Xamarin.Forms.Platform.Android.PageRenderer
    {
        public PageRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
            SetAppTheme();
        }

        void SetAppTheme()
        {
            if (Resources.Configuration.UiMode.HasFlag(UiMode.NightYes))
            {
                SetTheme(Theme.Dark);
            }
            else
            {
                SetTheme(Theme.Light);
            }
        }

        void SetTheme(Theme mode)
        {
            if (mode == Theme.Dark)
            {
                if (App.AppTheme == Theme.Dark)
                    return;

                App.Current.Resources = new DarkTheme();

                App.AppTheme = Theme.Dark;
            }
            else
            {
                if (App.AppTheme != Theme.Dark)
                    return;
                App.Current.Resources = new LightTheme();
                App.AppTheme = Theme.Light;
            }

        }
    }
}