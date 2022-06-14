using MaterialSkin.Controls;
using SchedulingSoftware.Class;
using SchedulingSoftware.Data_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingSoftware.Updated_Forms
{
    public partial class frmNewCustomer : MaterialForm
    {
        bool isModify;

        //Constructor
        public frmNewCustomer(bool modify)
        {
            InitializeComponent();

            isModify = modify; //Set bool wether you are modifying an existing customer

            if (modify)
            {
                //Load the Customer data
                txtName.Text = customer.customerName; //Name
                txtAddress.Text = address.address1; //Address1
                txtAddress2.Text = address.address2; //Address2
                txtCity.Text = city.cityName; //City
                txtCountry.Text = country.countryName; //Country
                txtPostal.Text = address.postal; //Postal
                txtPhone.Text = address.phone; //Phone
                chkActive.Checked = Convert.ToBoolean(customer.isActive); //Active
            }
            else
            {
                chkActive.Checked = true; //Default for new customers
            }
        }

        #region Events
        //Close the form 
        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        //Check the checkbox and set customer active or not
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Check if checkbox is checked
            if (chkActive.Checked)
            {
                customer.isActive = 1; //True
            }
            else
            {
                customer.isActive = 0; //False
            }
        }

        //Save the information
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Check the required textboxes are not empty
            if (txtName.Text == "" || txtAddress.Text == "" || txtCity.Text == "" || txtCountry.Text == "" || txtPostal.Text == "" || txtPhone.Text == "")
            {
                //Error message
                MessageBox.Show("Please enter all information before proceeding!");
                return; //Exit Event
            }

            //Fill the appropriate data models with the information of the textboxes
            customer.customerName = txtName.Text;
            address.address1 = txtAddress.Text;
            address.address2 = txtAddress2.Text;
            city.cityName = txtCity.Text;
            country.countryName = txtCountry.Text;
            address.postal = txtPostal.Text;
            address.phone = txtPhone.Text;

            //Check whether it is a new customer to be added or to edit an existing customer
            if (isModify)
            {
                //Update Customer
                dataProcedures.UpdateCustomer();
                //Success message
                MessageBox.Show($"Successfully updated customer {customer.customerName}!");
            }
            else
            {
                //Verify the customer does not exist
                if (dataProcedures.VerifyCustomer(customer.customerName) == -1)
                {
                    //Add Customer
                    dataProcedures.AddCustomer();
                    //Success message
                    MessageBox.Show($"Successfully added new customer {customer.customerName}!");
                }
                else
                {
                    //Error Customer already exists
                    MessageBox.Show("This customer already exists!");
                    //Clear the form
                    ClearAll();
                    return; //Exit Event
                }
            }

            this.Close(); //Close the form
        }
        #endregion

        #region Methods
        //Clear the Form
        private void ClearAll()
        {
            //Clear the controls
            txtName.Clear();
            txtAddress.Clear();
            txtAddress2.Clear();
            txtCity.Clear();
            txtCountry.Clear();
            txtPostal.Clear();
            txtPhone.Clear();

            //Clear the data models
            customer.customerName = "";
            address.address1 = "";
            address.address2 = "";
            city.cityName = "";
            country.countryName = "";
            address.postal = "";
            address.phone = "";
        }
        #endregion

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            txtPhone.Text = PhoneNumberFormatter(txtPhone.Text);
            txtPhone.SelectionStart = txtPhone.Text.Length;
        }

        private string PhoneNumberFormatter(string value)
        {
            //Regex to make sure incomming string is all digits
            value = new Regex(@"\D").Replace(value, string.Empty);

            //Check String length
            if (value.Length > 3 & value.Length < 7)
            {
                //format string
                value = string.Format("{0}-{1}", value.Substring(0, 3), value.Substring(3, value.Length - 3));
                return value; //return string
            }
            //Check String length
            if (value.Length > 6 & value.Length < 11)
            {
                //format string
                value = string.Format("({0})-{1}-{2}", value.Substring(0, 3), value.Substring(3, 3), value.Substring(6));
                return value; //return string
            }
            //Check String length
            if (value.Length > 10)
            {
                //remove 1 character
                value = value.Remove(value.Length - 1, 1);
                //Format string
                value = string.Format("({0})-{1}-{2}", value.Substring(0, 3), value.Substring(3, 3), value.Substring(6));
                return value; //return string
            }
            return value; //return string
        }
    }
}
