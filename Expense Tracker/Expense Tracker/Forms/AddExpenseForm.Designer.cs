namespace Expense_Tracker.Forms
{
    partial class AddExpenseForm
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AmountBox = new TextBox();
            CategoryBox = new TextBox();
            DescriptionBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 188);
            button1.Name = "button1";
            button1.Size = new Size(250, 23);
            button1.TabIndex = 1;
            button1.Text = "Add Expense";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Amount";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "Description";
            // 
            // AmountBox
            // 
            AmountBox.Location = new Point(90, 23);
            AmountBox.Name = "AmountBox";
            AmountBox.Size = new Size(163, 23);
            AmountBox.TabIndex = 7;
            // 
            // CategoryBox
            // 
            CategoryBox.Location = new Point(90, 56);
            CategoryBox.Name = "CategoryBox";
            CategoryBox.Size = new Size(163, 23);
            CategoryBox.TabIndex = 8;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(90, 90);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(163, 80);
            DescriptionBox.TabIndex = 9;
            // 
            // AddExpenseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 223);
            Controls.Add(DescriptionBox);
            Controls.Add(CategoryBox);
            Controls.Add(AmountBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "AddExpenseForm";
            Text = "AddExpenseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox AmountBox;
        private TextBox CategoryBox;
        private TextBox DescriptionBox;
    }
}