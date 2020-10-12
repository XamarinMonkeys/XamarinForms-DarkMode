using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DarkModePOC.Common.Styles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LightTheme : ResourceDictionary
    {
        public LightTheme()
        {
            InitializeComponent();
        }
    }
}