using MaterialSkin.Controls;
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

namespace SchedulingSoftware.Updated_Forms
{
    public partial class frmNewReminder : MaterialForm
    {
        //Constructor requires an incomming appointment
        public frmNewReminder(appointments appt)
        {
            InitializeComponent();

            //Load the forms controls with incomming appointment details
            lblCustomer.Text = appt.customerName;
            txtTitle.Text = appt.title;
            txtDescription.Text = appt.description;
            txtLocation.Text = appt.location;
            txtType.Text = appt.type;
            txtContact.Text = appt.contact;
            txtURL.Text = appt.url;
            startDateTimePicker.Value = appt.start.ToLocalTime();
            endDateTimePicker.Value = appt.end.ToLocalTime();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }
    }
}
