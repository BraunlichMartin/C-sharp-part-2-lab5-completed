using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomerMaintenanceClasses;

namespace CustomerMaintenance
{
    // This is the starting point for exercise 12-1 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        //Ex12-1 part 9-MWB_3/6/2019
        //private List<Customer> customers = null;
        //system throws an error when customers is "null"
        private List<Customer> customers = new List<Customer>();

        //Ex12-1 part 10-MWB_3/6/2019
        private void frmCustomerMain_Load(object sender, System.EventArgs e)
        {
            customers = CustomerDB.GetCustomers();
            FillCustomerListBox();
        }
        private void FillCustomerListBox()
        {
            lstCustomers.Items.Clear();
            foreach (Customer c in customers)
            {
                lstCustomers.Items.Add(c.GetDisplayText("\t"));
            }
        }
        //Ex12_1 part 11-MWB_3/6/2019
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            frmAddCustomer newCustomerForm = new frmAddCustomer();
            Customer customer = newCustomerForm.GetNewCustomer();
            if(customer != null)
            {
                customers.Add(customer);
                CustomerDB.SaveCustomers(customers);
                FillCustomerListBox();
            }
        }
        //Ex12-1 part12 -MWB_3/6/2019
        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            int i = lstCustomers.SelectedIndex;
            if (i != -1)
            {
                Customer customer = customers[i];
                string message = "Are you sure you want to delete " + customer.LastName + "?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    customers.Remove(customer);
                    CustomerDB.SaveCustomers(customers);
                    FillCustomerListBox();
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}