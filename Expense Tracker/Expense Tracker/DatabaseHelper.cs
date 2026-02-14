using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Tracker
{
    internal class DatabaseHelper
    {
        private static string connectionString = @"Data Source=D:\Projects\Expense Tracker\Expense Tracker\Files\ExpenseData.db";
        
        // creates a database file and/or table in the SQLite database if there isnt one already
        public static void InitializeDatabase()
        {
            if(!File.Exists(@"D:\Projects\Expense Tracker\Expense Tracker\Files\ExpenseData.db"))
            {
                SQLiteConnection.CreateFile(@"D:\Projects\Expense Tracker\Expense Tracker\Files\ExpenseData.db");
            }

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

        // adds an entry to the espenses table data base and returns true if the data was added successfully
        public static bool AddExpenseEntry(Expense expense)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                int rowCount = 0;
                string query = "SELECT COUNT(*) FROM expenses;";

                // get row cownt for ids
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null)
                        rowCount = Convert.ToInt32(result);                  
                    else
                    {
                        Debug.WriteLine("!!! Error row count returned as null");
                        return false;
                    }                   
                }

                // upload data
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"
                        INSERT INTO expenses (id, amount, category, description, date)
                        VALUES (@id, @amount, @category, @description, @date)
                    ";
                    command.Parameters.AddWithValue("@id", rowCount+1);
                    command.Parameters.AddWithValue("@amount", expense.amount);
                    command.Parameters.AddWithValue("@category", expense.category);
                    command.Parameters.AddWithValue("@description", expense.description);
                    command.Parameters.AddWithValue("@date", expense.date);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }

                // check if data was uploaded successfully by comparing dates
                string checkQuery = $"SELECT * FROM expenses WHERE id LIKE {rowCount+1}";
                using (SQLiteCommand command = new SQLiteCommand(checkQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime date = reader.GetDateTime(reader.GetOrdinal("date"));
                            if(date == expense.date)
                                return true;
                            
                        }
                    }
                }
            }
            return false;
        }

        // takes an SQL query and returns a list of expenses based on the query
        private static List<Expense> ReadExpenses(string query)
        {
            List<Expense> expenseList = new List<Expense>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
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
            return expenseList ;
        }

        // SQL queries to be passed on to the ReadExpenses() function
        public static List<Expense> GetExpense()
        {
            string query = "SELECT * FROM expenses";
            return ReadExpenses(query);
        }
        public static List<Expense> GetExpense(int year)
        {
            string query = $"SELECT * FROM expenses WHERE date LIKE '%{year.ToString()}%'";
            return ReadExpenses(query);
        }
        public static List<Expense> GetExpense(int year, int month)
        {
            string query = $"SELECT * FROM expenses WHERE date LIKE '%{year.ToString()}-{month.ToString("00")}%'";
            return ReadExpenses(query);
        }
        public static List<Expense> GetExpense(int year, int month, int day)
        {
            string query = $"SELECT * FROM expenses WHERE date LIKE '%{year.ToString()}-{month.ToString("00")}-{day.ToString("00")}%'";
            return ReadExpenses(query);
        }
        public static List<Expense> GetExpense(DateTime date)
        {
            string query = $"SELECT * FROM expenses WHERE date LIKE '%{date.Year.ToString()}-{date.Month.ToString("00")}-{date.Day.ToString("00")}%'";
            return ReadExpenses(query);
        }
    }
}
