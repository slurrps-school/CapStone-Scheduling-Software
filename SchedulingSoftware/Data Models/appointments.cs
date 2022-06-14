using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSoftware.Data_Models
{
    //non static as it is used for a list of appointments
    public class appointments
    {
        //Non static Appointment data model
        public int appointmentID = -1; //ID
        public int customerID; //Customer ID
        public string customerName; //Customer Name
        public int userID; //User ID
        public string userName; //User Name
        public string title; //Title of appointment
        public string description; //Appointment description
        public string location; //Appointment location
        public string contact; //Appointment contact
        public string type; //Appointment Type
        public string url; //Appointment url
        public DateTime start; //Start time
        public DateTime end; //End time
    }
}
