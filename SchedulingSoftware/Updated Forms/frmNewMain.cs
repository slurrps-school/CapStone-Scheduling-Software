using MaterialSkin.Controls;
using MySql.Data.Types;
using SchedulingSoftware.Class;
using SchedulingSoftware.Data_Models;
using SchedulingSoftware.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingSoftware.Updated_Forms
{
    public partial class frmNewMain : MaterialForm
    {
        //Constructor
        public frmNewMain()
        {
            InitializeComponent();
            //Set minimum size
            this.MinimumSize = new Size(1048, 788);

            BoldAppointments();

            //DataSources
            dgCustomers.DataSource = dataProcedures.GetCustomers();

            //TODO: Change to only get user and per customer apps?
            dgAppointments.DataSource = dataProcedures.GetUserAppointments();
        }

        //Form load
        private void frmMain_Load(object sender, EventArgs e)
        {
            //Intro Text
            //txtWelcome.Text = $"Welcome {users.userName}";

            //Defaults
            radMonth.Checked = true;

        }

        //Exits the application
        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        //Opens the Reports form
        private void btnReports_Click(object sender, EventArgs e)
        {
            frmNewReports reports = new frmNewReports();
            reports.ShowDialog();
        }

        //Handles the closing of the application
        #region Closing
        private void frmNewMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult to ask user to verify close
            DialogResult result = MessageBox.Show("Are you sure you would like to exit?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //Close
                Environment.Exit(0);
            }
            else
            {
                //Cancel closing the application
                e.Cancel = true;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        //DONE
        //Handles how the calendar view looks
        #region Handles the Calendar View

        private void BoldAppointments()
        {
            List<appointments> appts = dataProcedures.GetListAppointments();

            DateTime[] boldDates = new DateTime[60];
            int iterator = 0;
            appts.ForEach(appt =>
            {
                boldDates[iterator] = appt.start;
                iterator++;
            });

            monthView.BoldedDates = boldDates;
        }
        #endregion

        #region Customers
        //Opens the Customer form as a new customer
        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            //Open the Customer form sending it false indicating a new customer
            SelectedCustomer(false);

            //Refresh datasource
            dgCustomers.DataSource = dataProcedures.GetCustomers();
        }

        //Opens the Customer form modifying a current customer
        private void btnCustomerModify_Click(object sender, EventArgs e)
        {
            //Set the selected Customer ID IMPOTRANT so that the correct customer is selected
            customer.customerID = (int)dgCustomers.SelectedCells[0].Value;

            //Check that customer info is pulled
            if (dataProcedures.GetCustomerInfo())
            {
                //Open the Customer form sending it true indicating modification of a selected customer
                SelectedCustomer(true);
            }
            else
            {
                return; //Return from method
            }

            //Refresh datasource
            //dgCustomers.DataSource = dataProcedures.GetCustomers();
            txtCustomerName.Text = "";
        }

        //Deletes the Selected Custoemr
        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            //DialogResult to verify that the user wants to delete the customer
            DialogResult result = MessageBox.Show("Are you sure you wish to delete this customer? This cannot be undone!", "Alert", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //Set the selected Customer ID IMPORTANT
                customer.customerID = (int)dgCustomers.SelectedCells[0].Value;
                //Load the customer information
                dataProcedures.GetCustomerInfo();
                //Check if the customer was deleted
                if (dataProcedures.DeleteCustomer())
                {
                    //Show success message
                    MessageBox.Show($"customer '{customer.customerName}' was deleted.");
                }
                else
                {
                    return; //return from method
                }
            }

            //Refresh datasource
            dgCustomers.DataSource = dataProcedures.GetCustomers();
        }

        #endregion

        //DONE Handles the appointments in the DB
        #region Appointments
        //Opens the Appointment form as a new appointment
        private void btnAppAdd_Click(object sender, EventArgs e)
        {
            //Open the Appointment giving it false indicating a new appointment
            SelectedApp(false);

            //Refresh the datasource
            dgAppointments.DataSource = dataProcedures.GetUserAppointments();
            //Update calendar
            BoldAppointments();
            SetWeeklyDG();

        }

        //Opens the appointment form modifying a current appointment
        private void btnAppModify_Click(object sender, EventArgs e)
        {
            //Set the selected appointment Id to the selected row in the datagridview
            appointment.appointmentID = (int)dgAppointments.SelectedCells[0].Value;

            //Check for appointment information
            if (dataProcedures.GetAppInfo())
            {
                //Open the Form giving it true indicating modifying a selected appointment
                SelectedApp(true);
            }
            else
            {
                return; //Return from the method
            }

            //Refresh the datasource
            //dgAppointments.DataSource = dataProcedures.GetUserAppointments();
            txtAppTitle.Text = "";
        }

        //deletes the selected appointment
        private void btnAppDelete_Click(object sender, EventArgs e)
        {
            //DialogResult checking if user wants to delete the appointment
            DialogResult result = MessageBox.Show("Are you sure you wish to delete this appointment? This cannot be undone!", "Alert", MessageBoxButtons.YesNo);
            //Check result
            if (result == DialogResult.Yes)
            {
                //Set the selected Customer ID to the selected row if the datagridview
                appointment.appointmentID = (int)dgAppointments.SelectedCells[0].Value;
                //Fill the App Info
                dataProcedures.GetAppInfo();
                //Check that appointment was deleted
                if (dataProcedures.DeleteAppointment())
                {
                    //Sh9ow success message
                    MessageBox.Show($"Appointment '{appointment.title}' was deleted.");
                }
                else
                {
                    return; //Return from the method
                }
            }

            //Refresh datasource
            dgAppointments.DataSource = dataProcedures.GetUserAppointments();
        }

        //Event
        //Handles formatting time to local time from UTC
        private void dgAppointments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Check e.value is MySqlDateTime variable
            if (e.Value is MySqlDateTime)
            {
                //Convert it to system.datetime
                DateTime value = Convert.ToDateTime(e.Value);
                //Check what kind of datetime it is
                switch (value.Kind)
                {
                    //Convert it based on what is found
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
        #endregion

        //Handles opening new forms
        #region Lambda Actions
        //Handles creating a new instance and opening the Customer Form
        Action<bool> SelectedCustomer = curCustomer => new frmNewCustomer(curCustomer).ShowDialog();
        //Handles creating a new instance and opening the Appointment form
        Action<bool> SelectedApp = curApp => new frmNewAppointment(curApp).ShowDialog();


        #endregion

        int weekOfYear;
        DataTable weeklyDT;

        private void radMonth_CheckedChanged(object sender, EventArgs e)
        {
            monthView.Visible = true;
            dgWeekView.Visible = false;
            btnPrev.Visible = false;
            btnNext.Visible = false;
            lblWeek.Visible = false;
        }

        private void radWeek_CheckedChanged(object sender, EventArgs e)
        {
            monthView.Visible = false;
            dgWeekView.Visible = true;
            btnPrev.Visible = true;
            btnNext.Visible = true;
            lblWeek.Visible = true;

            CultureInfo ci = new CultureInfo("en-US");
            Calendar cal = ci.Calendar;

            CalendarWeekRule weekRule = ci.DateTimeFormat.CalendarWeekRule;
            DayOfWeek firstDOW = ci.DateTimeFormat.FirstDayOfWeek;

            weekOfYear = cal.GetWeekOfYear(DateTime.Now, weekRule, firstDOW) - 1;
            lblWeek.Text = $"Week {weekOfYear}";
            SetWeeklyDG();

        }

        private void SetWeeklyDG()
        {
            List<appointments> weekAppts = dataProcedures.GetWeeklyAppts(weekOfYear);
            weeklyDT = new DataTable();

            //Add week day columns
            if (!weeklyDT.Columns.Contains("SUN"))
            {
                weeklyDT.Columns.Add("SUN", typeof(string));
            }
            if (!weeklyDT.Columns.Contains("MON"))
            {
                weeklyDT.Columns.Add("MON", typeof(string));
            }
            if (!weeklyDT.Columns.Contains("TUE"))
            {
                weeklyDT.Columns.Add("TUE", typeof(string));
            }
            if (!weeklyDT.Columns.Contains("WED"))
            {
                weeklyDT.Columns.Add("WED", typeof(string));
            }
            if (!weeklyDT.Columns.Contains("THU"))
            {
                weeklyDT.Columns.Add("THU", typeof(string));
            }
            if (!weeklyDT.Columns.Contains("FRI"))
            {
                weeklyDT.Columns.Add("FRI", typeof(string));
            }
            if (!weeklyDT.Columns.Contains("SAT"))
            {
                weeklyDT.Columns.Add("SAT", typeof(string));
            }

            dgWeekView.DataSource = weeklyDT;

            weekAppts.ForEach(appt =>
            {
                DataRow row;

                switch (appt.start.DayOfWeek.ToString())
                {
                    case "Sunday":
                        row = weeklyDT.Rows.Add();
                        row[0] = appt.title;
                        break;
                    case "Monday":
                        row = weeklyDT.Rows.Add();
                        row[1] = appt.title;
                        break;
                    case "Tuesday":
                        row = weeklyDT.Rows.Add();
                        row[2] = appt.title;
                        break;
                    case "Wednesday":
                        row = weeklyDT.Rows.Add();
                        row[3] = appt.title;
                        break;
                    case "Thursday":
                        row = weeklyDT.Rows.Add();
                        row[4] = appt.title;
                        break;
                    case "Friday":
                        row = weeklyDT.Rows.Add();
                        row[5] = appt.title;
                        break;
                    case "Saturday":
                        row = weeklyDT.Rows.Add();
                        row[6] = appt.title;
                        break;
                }
            });
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (weekOfYear > 0)
            {
                weekOfYear--;
                lblWeek.Text = $"Week {weekOfYear}";
            }

            weeklyDT.Clear();
            SetWeeklyDG();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (weekOfYear > 0)
            {
                weekOfYear++;
                lblWeek.Text = $"Week {weekOfYear}";
            }

            weeklyDT.Clear();
            SetWeeklyDG();
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            DataTable customer;

            customer = dataProcedures.SearchCustomer(txtCustomerName.Text);

            dgCustomers.DataSource = customer;
        }

        private void txtAppTitle_TextChanged(object sender, EventArgs e)
        {
            DataTable customer;

            customer = dataProcedures.SearchAppointment(txtAppTitle.Text);

            dgAppointments.DataSource = customer;
        }

    }
}
