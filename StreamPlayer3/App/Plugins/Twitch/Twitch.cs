using StreamPlayer.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamPlayer.App.Plugins.Twitch
{
    public class Twitch : IPlugin
    {
        public Task<byte[]> GetNextPartAsync()
        {
            throw new NotImplementedException();
        }
    }
}
