using StreamPlayer.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamPlayer.App.Plugins
{
    public class Plugins
    {
        internal static Dictionary<string, Type> plugins = new Dictionary<string, Type>();

        public static List<string> GetPluginsList()
        {
            return plugins.Keys.ToList();
        }

        public static void RegisterPlugin(string name, Type type)
        {
            plugins[name] = type;
        }
        

        public static void SelectPlugin(string name)
        {
            ServiceLocator.RegisterService<IPlugin>(plugins[name]);
        }
    }
}
