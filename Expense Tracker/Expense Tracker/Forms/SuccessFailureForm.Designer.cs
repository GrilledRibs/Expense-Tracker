namespace Expense_Tracker.Forms
{
    partial class SuccessFailureForm
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
            SuccessLabel = new Label();
            FailureLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // SuccessLabel
            // 
            SuccessLabel.AutoSize = true;
            SuccessLabel.Font = new Font("Segoe UI", 15F);
            SuccessLabel.Location = new Point(42, 23);
            SuccessLabel.Name = "SuccessLabel";
            SuccessLabel.Size = new Size(175, 28);
            SuccessLabel.TabIndex = 0;
            SuccessLabel.Text = "Tasked Succeeded!";
            // 
            // FailureLabel
            // 
            FailureLabel.AutoSize = true;
            FailureLabel.Font = new Font("Segoe UI", 15F);
            FailureLabel.Location = new Point(72, 23);
            FailureLabel.Name = "FailureLabel";
            FailureLabel.Size = new Size(110, 28);
            FailureLabel.TabIndex = 1;
            FailureLabel.Text = "Task Failed!";
            // 
            // button1
            // 
            button1.Location = new Point(12, 70);
            button1.Name = "button1";
            button1.Size = new Size(226, 23);
            button1.TabIndex = 2;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SuccessFailureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 105);
            Controls.Add(button1);
            Controls.Add(FailureLabel);
            Controls.Add(SuccessLabel);
            Name = "SuccessFailureForm";
            Text = "SuccessFailureForm";
            Load += SuccessFailureForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SuccessLabel;
        private Label FailureLabel;
        private Button button1;
    }
}