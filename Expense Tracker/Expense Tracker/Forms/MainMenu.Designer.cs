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
            AddExpense = new Button();
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
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddExpense);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button AddExpense;
    }
}