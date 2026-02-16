using Expense_Tracker.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Tracker
{
    public partial class MainMenu : Form
    {
        List<Expense> expenses = new List<Expense>();
        decimal totalExpenses = 0;
        List<decimal> monthlyExpenses = new List<decimal>(new decimal[12]);

        public MainMenu()
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            expenses = DatabaseHelper.GetExpense(DateTime.Now.Year);
            foreach (Expense expense in expenses)
            {
                totalExpenses += expense.amount;
                monthlyExpenses[expense.date.Month-1] += expense.amount;
            }
            Debug.WriteLine($"Total expenses for the year: {totalExpenses}");
            for (int i = 0; i < monthlyExpenses.Count; i++)
            {
                Debug.WriteLine($"Month {i + 1}: {monthlyExpenses[i]}");
            }
        }

        private void AddExpense_Click(object sender, EventArgs e)
        {
            AddExpenseForm addExpenseWindow = new AddExpenseForm();
            addExpenseWindow.Show();
        }
    }
}
