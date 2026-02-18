using Expense_Tracker.Forms;
using System.Diagnostics;

namespace Expense_Tracker
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            DatabaseHelper.InitializeDatabase();
            Application.Run(new MainMenu());

            
        }
    }
}