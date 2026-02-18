namespace Expense_Tracker.Forms
{
    partial class ConfirmationForm
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
            ContinueButton = new Button();
            CancelButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ContinueButton
            // 
            ContinueButton.Location = new Point(12, 27);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(75, 23);
            ContinueButton.TabIndex = 0;
            ContinueButton.Text = "Continue";
            ContinueButton.UseVisualStyleBackColor = true;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(93, 27);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ConfirmationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 62);
            Controls.Add(label1);
            Controls.Add(CancelButton);
            Controls.Add(ContinueButton);
            Name = "ConfirmationForm";
            Text = "ConfirmationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ContinueButton;
        private Button CancelButton;
        private Label label1;
    }
}