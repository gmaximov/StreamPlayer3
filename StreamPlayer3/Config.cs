using System.Collections.Generic;
using System.IO;

namespace StreamPlayer3
{
    public static class Config
    {

        public static string playerPath = @"MPC-BE\mpc-be.exe";
        public static string playerArgs = @"-";
        public static List<string> favorites = new List<string>();

        public static void Load()
        {
            if ( File.Exists(@"config.ini") )
            {
                using ( StreamReader sr = File.OpenText(@"config.ini") )
                {
                    string s = "";
                    if ( (s = sr.ReadLine()) != null )
                    {
                        playerPath = s;
                    }
                    else
                    {
                        Save();
                        return;
                    }
                    if ( (s = sr.ReadLine()) != null )
                    {
                        playerArgs = s;
                    }
                    else
                    {
                        Save();
                        return;
                    }
                    while ( (s = sr.ReadLine()) != null )
                    {
                        favorites.Add(s);
                    }
                }
            }
            else
            {
                Save();
            }
        }
        public static void Save()
        {
            string text = playerPath + "\n" + playerArgs + "\n";
            File.WriteAllText(@"config.ini", text);
            File.AppendAllLines(@"config.ini", favorites);
        }
    }
}
