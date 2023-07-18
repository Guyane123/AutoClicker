using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AutoClicker
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of Form1
            Form1 form = new Form1();

            // Register the IMessageFilter for capturing global keyboard events
            Application.AddMessageFilter(form);


            // Start the application event loop
            Application.Run(form);
        }
    }
}
