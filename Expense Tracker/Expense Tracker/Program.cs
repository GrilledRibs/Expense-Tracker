using System.Diagnostics;

namespace Expense_Tracker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            DateTime date = DateTime.Now;
            Debug.WriteLine(date.Date);


            DatabaseHelper.InitializeDatabase();
            //Expense expense = new Expense(01, decimal.Parse("19.99"), "Test Category", "Test Description", DateTime.Now);
            //Expense expense = new Expense(02, decimal.Parse("29.99"), "Test Category 2", "Test Description 2", date);
            //DatabaseHelper.AddExpenseEntry(expense);

            List<Expense> expenseList = DatabaseHelper.GetExpense(2026,2);
            Debug.WriteLine($"id:{expenseList[0].id}, Amount: {expenseList[0].amount}, Description:{expenseList[0].description}");
  
        }
    }
}