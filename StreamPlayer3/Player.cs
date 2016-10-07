using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamPlayer3
{
    class Player
    {
        Process process;
        StreamWriter StandardInput;

        public Player()
        {
            process = new Process();
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.FileName = Config.playerPath;
            process.StartInfo.Arguments = Config.playerArgs;
        }

        public void Start()
        {
            process.Start();
            StandardInput = process.StandardInput;
        }

        public void Close()
        {
            StandardInput.BaseStream.Flush();
            process.Kill();
        }

        public async Task WriteByteArray(byte[] byteArray)
        {
            await StandardInput.BaseStream.WriteAsync(byteArray, 0, byteArray.Length);
            //await StandardInput.BaseStream.FlushAsync();
        }
    }
}
