using StreamPlayer.App.Forms;
using System;
using System.Windows.Forms;

namespace StreamPlayer
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormStreamPlayer());
        }
    }
}
