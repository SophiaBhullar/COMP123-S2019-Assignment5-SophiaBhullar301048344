using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5_SophiaBhullar301048344
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }

        private void backToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
