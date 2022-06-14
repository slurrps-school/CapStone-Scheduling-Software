using MaterialSkin.Controls;
using MySql.Data.Types;
using SchedulingSoftware.Class;
using SchedulingSoftware.Data_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingSoftware.Forms
{
    public partial class frmNewAppointment : MaterialForm
    {
        bool isModify; //Bool to hold if form is adding an appointment or editing an existing one
        bool validTime; //Bool to hold if the time is valid

        //Constructor
        public frmNewAppointment(bool modify)
        {
            InitializeComponent();

            isModify = modify; //Set Bool to incoming variable

            //Set Datasource for both datagridviews
            dgCustomers.DataSource = dataProcedures.GetCustomers(); //Customers
            dgAppointments.DataSource = dataProcedures.GetAllAppts(); //Appointments

            //Check if adding a new appointment or editing and existing appointment
            if (modify)
            {
                //load the appointment data
                txtTitle.Text = appointment.title;
                txtDesc.Text = appointment.description;
                txtLocation.Text = appointment.location;
                txtContact.Text = appointment.contact;
                txtType.Text = appointment.type;
                txtURL.Text = appointment.url;

                //Appointment Customer
                foreach (DataGridViewRow row in dgCustomers.Rows)
                {
                    if ((int)row.Cells["customerId"].Value == appointment.customerID)
                    {
                        //Set dgCustomer selection
                        dgCustomers.CurrentCell = dgCustomers.Rows[row.Index].Cells[0];
                        dgCustomers.Rows[row.Index].Selected = true;

                        //Fill customer name
                        txtCustomer.Text = dgCustomers.Rows[row.Index].Cells["customerId"].Value.ToString() + " " + dgCustomers.Rows[row.Index].Cells["customerName"].Value.ToString();
                    }
                }

                //Set the value of the date Pickers by converting the appointment start and end strings to datetime
                dateTimeStart.Value = Convert.ToDateTime(appointment.start).ToLocalTime();
                dateTimeEnd.Value = Convert.ToDateTime(appointment.end).ToLocalTime();
            }
            else //New Appointment
            {
                //Set default Customer to first row
                dgCustomers.CurrentCell = dgCustomers.Rows[0].Cells[0];
                dgCustomers.Rows[0].Selected = true;
                //Fill textbox with default customer
                txtCustomer.Text = dgCustomers.Rows[0].Cells["customerId"].Value.ToString() + " " + dgCustomers.Rows[0].Cells["customerName"].Value.ToString();

                //Default DateTime for new appointment
                dateTimeStart.Value = DateTime.Now;
                dateTimeEnd.Value = DateTime.Now.AddHours(1);
            }
        }

        //Handles dgCustomers CellClick
        private void dgCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Fill the Customer Text
            txtCustomer.Text = dgCustomers.SelectedCells[0].Value.ToString() + " " + dgCustomers.SelectedCells[2].Value.ToString();
        }

        //Closes the form
        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        //Saves the information
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Verify required textboxes are not empty
            if (txtTitle.Text == "" || txtDesc.Text == "" || txtCustomer.Text == "" || txtType.Text == "")
            {
                //Error message
                MessageBox.Show("Please fill out all required fields!");
                return; //Exit the event
            }

            ValidateTime(); //Validate the selected appointment time

            //If the time is valid
            if (validTime)
            {
                //Fill Appointment info
                appointment.title = txtTitle.Text;
                appointment.description = txtDesc.Text;
                appointment.location = txtLocation.Text;
                appointment.contact = txtContact.Text;
                appointment.type = txtType.Text;
                appointment.url = txtURL.Text;
                appointment.customerID = Convert.ToInt32(txtCustomer.Text.Substring(0, 1));
                appointment.userID = user.userId;
                appointment.start = ConvertToMySqlDateTime(dateTimeStart.Value.ToUniversalTime());
                appointment.end = ConvertToMySqlDateTime(dateTimeEnd.Value.ToUniversalTime());

                //Check whether adding a new appointment or editing an existing appointment
                if (isModify)
                {
                    //Update Customer
                    dataProcedures.UpdateAppointment();
                    MessageBox.Show($"Successfully updated appointment {appointment.title}!");
                }
                else
                {

                    dataProcedures.AddAppointment();
                    //Success message
                    MessageBox.Show($"Successfully added appointment!");

                    ////Check if the appointment already exists
                    //if (dataProcedures.VerifyAppointment(appointment.title) == -1)
                    //{
                    //    dataProcedures.AddAppointment();
                    //    //Success message
                    //    MessageBox.Show($"Successfully added appointment!");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("This appointment already exists!"); //Already Exists
                    //    //Clear the form
                    //    ClearForm();

                    //    return; //Exit Event
                    //}
                }
            }
            else
            {
                return; //Exit Event
            }


            this.Close(); //Close the form
        }

        #region Methods
        //TODO: Add Check for withing Business Hours
        private void ValidateTime()
        {
            bool overlap = dataProcedures.CheckOverlapTime(ConvertToMySqlDateTime(dateTimeStart.Value.ToUniversalTime()), ConvertToMySqlDateTime(dateTimeEnd.Value.ToUniversalTime()));

            //Check overlapping appointments
            if (overlap)
            {
                MessageBox.Show("Error selected times overlap with an existing appointment please choose another time!"); //Overlapping Times
                validTime = false;
                return;
            }
            else
            {
                //check if start is before or after hours
                if (Convert.ToDateTime(dateTimeStart.Value.ToShortTimeString()) < Convert.ToDateTime("09:00:00 AM")
                    || Convert.ToDateTime(dateTimeStart.Value.ToShortTimeString()) > Convert.ToDateTime("17:00:00 PM")
                    || Convert.ToDateTime(dateTimeEnd.Value.ToShortTimeString()) > Convert.ToDateTime("17:00:00 PM"))
                {
                    MessageBox.Show("Error selected times are outside the business hours! Please choose an appointment time within business hours from 9 - 5"); //Outside hours
                    validTime = false;
                    return;
                }
                else
                {
                    //Check that the start is not less than the end time
                    if (dateTimeStart.Value.ToUniversalTime() < dateTimeEnd.Value.ToUniversalTime())
                    {
                        //Valid Time
                        validTime = true;
                    }
                    else
                    {
                        MessageBox.Show("Error end time cannot be before start time!"); //Outside hours
                        validTime = false;
                        return;
                    }
                }
            }
            //Check that the start is not less than the end time
            if (dateTimeStart.Value.ToUniversalTime() < dateTimeEnd.Value.ToUniversalTime())
            {
                //Check for overlapping appointments
                if (!overlap)
                {
                    //check if start is before or after hours
                    if (Convert.ToDateTime(dateTimeStart.Value.ToUniversalTime().ToShortTimeString()) < Convert.ToDateTime("09:00:00 AM").ToUniversalTime()
                        || Convert.ToDateTime(dateTimeStart.Value.ToUniversalTime().ToShortTimeString()) > Convert.ToDateTime("17:00:00 PM").ToUniversalTime()
                        || Convert.ToDateTime(dateTimeEnd.Value.ToUniversalTime().ToShortTimeString()) > Convert.ToDateTime("17:00:00 PM").ToUniversalTime())
                    {
                        MessageBox.Show("Error selected times is outside the business hours"); //Outside hours
                        validTime = false;
                        return;
                    }

                    //Valid Time
                    validTime = true;
                }
            }
        }

        //Convert incomming System.DateTime to MySQLDateTime format as a string
        private string ConvertToMySqlDateTime(DateTime time)
        {
            //Format the datetime
            return time.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void ClearForm()
        {
            txtTitle.Text = "";
            txtDesc.Text = "";
            txtLocation.Text = "";
            txtContact.Text = "";
            txtType.Text = "";
            txtURL.Text = "";
            txtCustomer.Text = "";
            dateTimeStart.Value = DateTime.Now;
            dateTimeEnd.Value = DateTime.Now.AddHours(1);
        }
        #endregion

        //Event
        //Handles formatting the time to local time from UTC
        private void dgAppointments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is MySqlDateTime)
            {
                DateTime value = Convert.ToDateTime(e.Value);
                switch (value.Kind)
                {
                    case DateTimeKind.Local:
                        break;
                    case DateTimeKind.Unspecified:
                        e.Value = DateTime.SpecifyKind(value, DateTimeKind.Utc).ToLocalTime();
                        break;
                    case DateTimeKind.Utc:
                        e.Value = value.ToLocalTime();
                        break;
                }
            }
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            DataTable customer;

            customer = dataProcedures.SearchCustomer(txtCustomerName.Text);

            dgCustomers.DataSource = customer;
            dgCustomers.Rows[0].Selected = true;
            
        }

        private void txtAppointmentTitle_TextChanged(object sender, EventArgs e)
        {
            DataTable appointment;

            appointment = dataProcedures.SearchAppointment(txtAppointmentTitle.Text);

            dgAppointments.DataSource = appointment;
        }
    }
}
