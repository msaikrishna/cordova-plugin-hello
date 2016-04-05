using WP7CordovaClassLib.Cordova;
using WP7CordovaClassLib.Cordova.Commands;
using WP7CordovaClassLib.Cordova.JSON;

namespace Cordova.Extension.Commands
{
    public class Hello : BaseCommand
    {
        public void greet(string args)
        {
            string name = JsonHelper.Deserialize<string>(args);
            string message = "Hello, " + name[0];
            PluginResult result = new PluginResult(PluginResult.Status.OK, message);
            DispatchCommandResult(result);
        }
    }
}
