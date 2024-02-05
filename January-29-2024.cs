using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManagement
{
    public partial class BillingInformation : Form
    {
        DataTable billingInformation = new DataTable();
        public BillingInformation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            skuTextBox.Text = "";
            vendorTextBox.Text = "";
            priceTextBox.Text = "";
            descriptionTextBox.Text = "";
            dateTextBox.Text = "";
            categoryBox.SelectedIndex = -1;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Save all the values from our fields into variables
            String sku = skuTextBox.Text;
            String vendor = vendorTextBox.Text;
            String price = priceTextBox.Text;   
            String description = descriptionTextBox.Text;
            String date = dateTextBox.Text;
            String category = (string)categoryBox.SelectedItem;
        
            // Add these values to the datatable
            billingInformation.Rows.Add(sku, vendor, price, description, date, category);

            // Clear fields after saves
            NewButton_Click(sender, e);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                billingInformation.Rows[BillingInformationGrid.CurrentCell.RowIndex].Delete();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error:   " + err);
            }

        }

        private void BillingInformationGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                skuTextBox.Text = billingInformation.Rows[BillingInformationGrid.CurrentCell.RowIndex].ItemArray[0].ToString();
                vendorTextBox.Text = billingInformation.Rows[BillingInformationGrid.CurrentCell.RowIndex].ItemArray[1].ToString();
                priceTextBox.Text = billingInformation.Rows[BillingInformationGrid.CurrentCell.RowIndex].ItemArray[2].ToString();
                descriptionTextBox.Text = billingInformation.Rows[BillingInformationGrid.CurrentCell.RowIndex].ItemArray[3].ToString();
                dateTextBox.Text = billingInformation.Rows[BillingInformationGrid.CurrentCell.RowIndex].ItemArray[4].ToString();

                String itemToLookFor = billingInformation.Rows[BillingInformationGrid.CurrentCell.RowIndex].ItemArray[5].ToString();
                categoryBox.SelectedIndex = categoryBox.Items.IndexOf(itemToLookFor);
            }
            catch(Exception err)
            {
                Console.WriteLine("There has been an error: " + err);
            }
        }
        
        private void BillingInformationGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BillingInformation_Load(object sender, EventArgs e)
        {
            billingInformation.Columns.Add("SKU");
            billingInformation.Columns.Add("Vendor_Name");
            billingInformation.Columns.Add("Catagory");
            billingInformation.Columns.Add("Price");
            billingInformation.Columns.Add("Description");
            billingInformation.Columns.Add("Date");

            BillingInformationGrid.DataSource = billingInformation;
        }

        private void categoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuantityLabel_Click(object sender, EventArgs e)
        {

        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void skuTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
