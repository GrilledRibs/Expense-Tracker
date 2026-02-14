using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Tracker
{
    internal class UserInput
    {
        Expense expense;
        int id;
        decimal amount;
        string category;
        string description;
        DateTime date;
        public void AddExpense()
        {

            //missing: get input from user

            expense = new Expense(id, amount, category, description, date);
        }
    }
}
