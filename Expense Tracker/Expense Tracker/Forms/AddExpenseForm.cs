using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Expense_Tracker.Forms
{
    public partial class AddExpenseForm : Form
    {
        Expense expense;
        SuccessFailureForm successFailureForm;
        InvalidInputWarning invalidInputWarning = new InvalidInputWarning();   

        public AddExpenseForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            expense = new Expense();
            decimal result;
            if (Decimal.TryParse(Encoding.Default.GetBytes(AmountBox.Text), out result))
                expense.amount = result;
            else
            {
                //Debug.WriteLine("Invalid user input in amount box");
                Trace.TraceWarning("Invalid user input in amount box: \"{0}\"", AmountBox.Text);
                invalidInputWarning.Show();
                return;
            }

            expense.category = CategoryBox.Text;
            expense.description = DescriptionBox.Text;
            expense.date = DateTime.Now;

            if (DatabaseHelper.AddExpenseEntry(expense))
                (successFailureForm = new SuccessFailureForm(true)).Show();
            else
                (successFailureForm = new SuccessFailureForm(false)).Show();

            this.Close();
        }
    }
}
