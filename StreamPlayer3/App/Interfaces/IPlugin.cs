using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamPlayer.App.Interfaces
{
    public interface IPlugin
    {
        Task<byte[]> GetNextPartAsync();
    }
}
