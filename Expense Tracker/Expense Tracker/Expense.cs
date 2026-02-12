using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Tracker
{
    public class Expense
    {
        public int id { get; set; }
        public decimal amount { get; set; }
        public string category { get; set; } = string.Empty;
        public string description { get; set; }
        public DateTime date { get; set; }

        public Expense(int _id, decimal _amount, string _category, string _description, DateTime _date)
        {
            id = _id;
            amount = _amount;
            category = _category;
            description = _description;
            date = _date;
        }

    }


}
