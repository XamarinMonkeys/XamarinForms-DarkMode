using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DarkModePOC.Common.Styles;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using static DarkModePOC.App;

//[assembly: ExportRenderer(typeof(ContentPage), typeof(DarkModePOC.iOS.PageRenderer))]
namespace DarkModePOC.iOS
{
    public class PageRenderer: Xamarin.Forms.Platform.iOS.PageRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            SetAppTheme();
        }

        public override void TraitCollectionDidChange(UITraitCollection previousTraitCollection)
        {
            base.TraitCollectionDidChange(previousTraitCollection);

            if (TraitCollection.UserInterfaceStyle != previousTraitCollection.UserInterfaceStyle)
                SetAppTheme();
        }

        void SetAppTheme()
        {
            if (TraitCollection.UserInterfaceStyle == UIUserInterfaceStyle.Dark)
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