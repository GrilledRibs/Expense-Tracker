namespace Expense_Tracker
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            AddExpense = new Button();
            expenseBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            Month = new DataGridViewTextBoxColumn();
            Expense = new DataGridViewTextBoxColumn();
            thisYear = new Button();
            lastYear = new Button();
            DeleteTable = new Button();
            ((System.ComponentModel.ISupportInitialize)expenseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // AddExpense
            // 
            AddExpense.Location = new Point(12, 12);
            AddExpense.Name = "AddExpense";
            AddExpense.Size = new Size(94, 23);
            AddExpense.TabIndex = 0;
            AddExpense.Text = "Add Expense ";
            AddExpense.UseVisualStyleBackColor = true;
            AddExpense.Click += AddExpense_Click;
            // 
            // expenseBindingSource
            // 
            expenseBindingSource.DataSource = typeof(Expense);
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(460, 325);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Month, Expense });
            dataGridView2.Location = new Point(478, 41);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(176, 325);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Month
            // 
            Month.DataPropertyName = "Month";
            Month.HeaderText = "Month";
            Month.Name = "Month";
            // 
            // Expense
            // 
            Expense.DataPropertyName = "Expense";
            Expense.HeaderText = "Expense";
            Expense.Name = "Expense";
            // 
            // thisYear
            // 
            thisYear.Location = new Point(478, 12);
            thisYear.Name = "thisYear";
            thisYear.Size = new Size(75, 23);
            thisYear.TabIndex = 3;
            thisYear.Text = "This Year";
            thisYear.UseVisualStyleBackColor = true;
            thisYear.Click += thisYear_Click;
            // 
            // lastYear
            // 
            lastYear.Location = new Point(559, 12);
            lastYear.Name = "lastYear";
            lastYear.Size = new Size(75, 23);
            lastYear.TabIndex = 4;
            lastYear.Text = "Last Year";
            lastYear.UseVisualStyleBackColor = true;
            lastYear.Click += lastYear_Click;
            // 
            // DeleteTable
            // 
            DeleteTable.Location = new Point(112, 12);
            DeleteTable.Name = "DeleteTable";
            DeleteTable.Size = new Size(75, 23);
            DeleteTable.TabIndex = 5;
            DeleteTable.Text = "Delete Data";
            DeleteTable.UseVisualStyleBackColor = true;
            DeleteTable.Click += DeleteTable_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 379);
            Controls.Add(DeleteTable);
            Controls.Add(lastYear);
            Controls.Add(thisYear);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(AddExpense);
            Name = "MainMenu";
            Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)expenseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddExpense;
        private BindingSource expenseBindingSource;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Month;
        private DataGridViewTextBoxColumn Expense;
        private Button thisYear;
        private Button lastYear;
        private Button DeleteTable;
    }
}