using System;

using Android.App;
using Android.OS;
using Android.Views;
using Android.Support.V7.App;
using Android.Content.PM;
using System.Threading.Tasks;

namespace Plugin.FooPlugin.Android {
    [Activity(Label = "QR-Scanner", Icon = "@drawable/icon", Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class FooPluginActivity : AppCompatActivity {
        public static TaskCompletionSource<string> ResultTaskCompletionSource;

        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Foo);

            var preview = FindViewById<SurfaceView>(Resource.Id.cameraPreview);

            if (preview == null)
                throw new Exception("Failed to find SurfaceView!");

            ResultTaskCompletionSource.TrySetResult("foo");

            Finish();
        }
    }
}