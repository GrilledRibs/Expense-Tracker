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
    public partial class SuccessFailureForm : Form
    {
        bool success = false;
        public SuccessFailureForm(bool _success)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            success = _success;
            SuccessLabel.Visible = success;
            FailureLabel.Visible = !success;
        }


        private void SuccessFailureForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
