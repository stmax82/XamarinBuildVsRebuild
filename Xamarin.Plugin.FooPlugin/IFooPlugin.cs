using System.Threading.Tasks;

namespace Plugin.FooPlugin {
    public interface IFooPlugin {
        Task<string> GetResult();
    }
}
