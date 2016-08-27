using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamPlayer3
{
    class M3U8
    {
        public static string[] Build(string rawfile)
        {
            string[] line = rawfile.Split('\n');

            if ( !line.Any() )
            {
                throw new InvalidOperationException("The provided file does not contain any data.");
            }
            if ( line[0] != "#EXTM3U" )
            {
                throw new InvalidOperationException("The provided file is not a well-formed M3U8 playlist.");
            }
            return line;
        }
        
    }
}
