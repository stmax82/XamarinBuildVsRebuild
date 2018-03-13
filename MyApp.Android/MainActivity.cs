using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms;

using MyApp.Shared;

namespace MyApp.Android {
    [Activity(Label = "PreWeldConnect", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity {
        protected override void OnCreate(Bundle bundle) {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            DependencyService.Register<Plugin.FooPlugin.Android.FooPlugin>();

            LoadApplication(new App());
        }
    }
}
