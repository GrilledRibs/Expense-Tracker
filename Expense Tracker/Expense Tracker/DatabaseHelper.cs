using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using System.IO;

namespace Expense_Tracker
{
    internal class DatabaseHelper
    {
        private static string connectionString = @"Data Source=D:\Projects\Expense Tracker\Expense Tracker\Files\ExpenseData.db";
        public static void InitializeDatabase()
        {
            //SQLiteConnection.CreateFile(@"..\..\Files\ExpenseData.db");
            SQLiteConnection.CreateFile(@"D:\Projects\Expense Tracker\Expense Tracker\Files\ExpenseData.db");
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                //create tables
                string createExpenseTableQuery = @"
                    CREATE TABLE IF NOT EXISTS  expenses (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        amount DECIMAL,
                        category TEXT NOT NULL,
                        description TEXT NOT NULL,
                        date TEXT NOT NULL
                    )";

                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = createExpenseTableQuery;
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddExpenseEntry(Expense expense)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"
                        INSERT INTO expenses (id, amount, category, description, date)
                        VALUES (@id, @amount, @category, @description, @date)
                    ";
                    command.Parameters.AddWithValue("@id", expense.id);
                    command.Parameters.AddWithValue("@amount", expense.amount);
                    command.Parameters.AddWithValue("@category", expense.category);
                    command.Parameters.AddWithValue("@description", expense.description);
                    command.Parameters.AddWithValue("@date", expense.date);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }                  
            }
        }

        public static List<Expense> GetAllExpense()
        {
            List<Expense> expenseList = new List<Expense>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM expenses";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(reader.GetOrdinal("id"));
                            decimal amount = reader.GetDecimal(reader.GetOrdinal("amount"));
                            string category = reader.GetString(reader.GetOrdinal("category"));
                            string description = reader.GetString(reader.GetOrdinal("description"));
                            DateTime date = reader.GetDateTime(reader.GetOrdinal("date"));

                            expenseList.Add(new Expense(id, amount, category, description, date));
                        }
                    }
                }
            }
            return expenseList;
        }
    }
}
