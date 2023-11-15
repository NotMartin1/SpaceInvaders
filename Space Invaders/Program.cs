using Space_Invaders.Forms;
using System;
using System.Windows.Forms;

namespace Space_Invaders
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuForm());
        }

    }
}
