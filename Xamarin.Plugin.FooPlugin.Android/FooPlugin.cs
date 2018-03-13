using System.Threading.Tasks;

using Android.Content;

namespace Plugin.FooPlugin.Android {
    public class FooPlugin : Java.Lang.Object, IFooPlugin {
        public Task<string> GetResult() {
            var ctx = global::Android.App.Application.Context;

            FooPluginActivity.ResultTaskCompletionSource = new TaskCompletionSource<string>();

            var intent = new Intent(ctx, typeof(FooPluginActivity));
            intent.SetFlags(ActivityFlags.NewTask);
            ctx.StartActivity(intent);

            return FooPluginActivity.ResultTaskCompletionSource.Task;
        }
    }
}