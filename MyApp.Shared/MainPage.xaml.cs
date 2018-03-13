using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Plugin.FooPlugin;

namespace MyApp.Shared {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();

            btn.Clicked += async (s, e) => await OnButtonClicked();
        }

        private async Task OnButtonClicked() {
            var result = await DependencyService.Get<IFooPlugin>().GetResult();

            await DisplayAlert("Result", result, "Ok");
        }
    }
}
