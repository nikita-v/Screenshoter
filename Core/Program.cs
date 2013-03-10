using System;
using System.Threading;
using System.Windows.Forms;

namespace Core
{
    internal static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool isFirstInstance;
            using (new Mutex(true, "Screenshoter_mutex", out isFirstInstance))
            {
                if (isFirstInstance)
                {
                    using (new Ui())
                    {
                        Application.Run();
                    }
                }
            }
        }        
    }
}
