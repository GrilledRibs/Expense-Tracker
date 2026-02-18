using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Tracker.Forms
{
    public partial class ConfirmationForm : Form
    {
        private Action onConfirm;
        private Action onConfirm2;
        private string message;

        public ConfirmationForm(Action _onConfirm, Action _onConfirm2, string _message)
        {
            onConfirm = _onConfirm;
            onConfirm2 = _onConfirm2;
            message = _message;
            InitializeComponent();
            this.Text = "Confirmation";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.label1.Text = message;
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            onConfirm?.Invoke();
            onConfirm2?.Invoke();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
