using Expense_Tracker.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Expense_Tracker
{
    public partial class MainMenu : Form
    {
        
        decimal totalExpensesThisYear = 0;
        decimal totalExpensesLastYear = 0;
        List<Expense> expensesThisYear = new List<Expense>();
        List<Expense> expensesLastYear = new List<Expense>();
        List<decimal> monthlyExpensesThisYear = new List<decimal>(new decimal[12]);
        List<decimal> monthlyExpensesLastYear = new List<decimal>(new decimal[12]);

        public MainMenu()
        {
            InitializeComponent();
            this.Text = "Expense Tracker";
            this.StartPosition = FormStartPosition.CenterScreen;

            UpdateTables();
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView2.RowTemplate.Height = 25;

            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 100;

            dataGridView2.Columns[1].Width = 70;

            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void UpdateTables()
        {
            expensesThisYear = new List<Expense>();
            expensesLastYear = new List<Expense>();
            monthlyExpensesThisYear = new List<decimal>(new decimal[12]);
            monthlyExpensesLastYear = new List<decimal>(new decimal[12]);

            expensesThisYear = DatabaseHelper.GetExpense(DateTime.Now.Year);
            foreach (Expense expense in expensesThisYear)
            {
                totalExpensesThisYear += expense.amount;
                monthlyExpensesThisYear[expense.date.Month - 1] += expense.amount;
            }

            expensesLastYear = DatabaseHelper.GetExpense(DateTime.Now.Year - 1);
            foreach (Expense expense in expensesLastYear)
            {
                totalExpensesLastYear += expense.amount;
                monthlyExpensesLastYear[expense.date.Month - 1] += expense.amount;
            }

            DataTable data = DatabaseHelper.GetExpenseDataTable("amount, date, category, description");
            if (dataGridView1.Rows.Count > 0 && dataGridView1 != null)
                (dataGridView1.DataSource as DataTable).Rows.Clear();
            dataGridView1.DataSource = data;

            string[] monthNames = DateTimeFormatInfo.CurrentInfo.MonthNames;
            int index = 0;
            if (dataGridView2.Rows.Count > 0)
                dataGridView2.Rows.Clear();
            foreach (string month in monthNames)
            {
                if (!string.IsNullOrEmpty(month))
                {
                    dataGridView2.Rows.Add(month, monthlyExpensesThisYear[index]);
                }
                index++;
            }
        }

        private void AddExpense_Click(object sender, EventArgs e)
        {
            AddExpenseForm addExpenseWindow = new AddExpenseForm();
            addExpenseWindow.updateTables = UpdateTables;
            addExpenseWindow.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void thisYear_Click(object sender, EventArgs e)
        {
            string[] monthNames = DateTimeFormatInfo.CurrentInfo.MonthNames;
            int index = 0;
            dataGridView2.Rows.Clear();
            foreach (string month in monthNames)
            {
                if (!string.IsNullOrEmpty(month))
                {
                    dataGridView2.Rows.Add(month, monthlyExpensesThisYear[index]);
                }
                index++;
            }
        }

        private void lastYear_Click(object sender, EventArgs e)
        {
            string[] monthNames = DateTimeFormatInfo.CurrentInfo.MonthNames;
            int index = 0;
            dataGridView2.Rows.Clear();
            foreach (string month in monthNames)
            {
                if (!string.IsNullOrEmpty(month))
                {
                    dataGridView2.Rows.Add(month, monthlyExpensesLastYear[index]);
                }
                index++;
            }
        }

        private void DeleteTable_Click(object sender, EventArgs e)
        {
            DatabaseHelper.DeleteTablePrompt(UpdateTables);
        }
    }
}
