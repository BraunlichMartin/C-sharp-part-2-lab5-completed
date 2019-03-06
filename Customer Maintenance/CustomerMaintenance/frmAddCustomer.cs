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

    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }
        //Ex12-1 part5 MWB
        private Customer customer = null;

        //Ex12-1 part6: add a public method named "GetNewCustomer" that displays the form as a dialog box and returns a Customer as object
        public Customer GetNewCustomer()
        {
            this.ShowDialog();
            return customer;
        }

        //Ex12-1 part7 -MWB_3/6/2019
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(IsValidData())
            {
                customer = new Customer(txtFirstName.Text, txtLastName.Text,
                    txtEmail.Text);
                this.Close();
            }
        }
        private bool IsValidData()
        {
            return Validator.IsPresent(txtFirstName) &&
                    Validator.IsPresent(txtLastName) &&
                    Validator.IsPresent(txtEmail) &&
                    Validator.IsValidEmail(txtEmail);
        }
        //Ex12-1 part8 -MWB_3/6/2019
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    
    }
}