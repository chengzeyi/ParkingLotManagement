using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingLotManagement
{
    /// <summary>
    /// Contain the main entrance point of the application
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entrance point of the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserIdentificationForm());
        }
    }
}
