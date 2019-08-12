using COMP123_S2019_Assignment5_SophiaBhullar301048344.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5_SophiaBhullar301048344
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

       
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
           if(!HasLoadedDataSource())
            {
                MessageBox.Show("DataSource Not Loaded", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
                this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }

        private void ProductsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            SelectedHarwareTextBox.Text = ProductDataGridViewSelectedItem();
        }

        
    }
}
