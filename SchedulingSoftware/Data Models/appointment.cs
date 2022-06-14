using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSoftware.Data_Models
{
    //Static class used for a single appointment
    //as the user should not be able to select more than one at a time
    public static class appointment
    {
        //Static Appointment data model
        public static int appointmentID = -1; //ID
        public static int customerID; //Customer ID
        public static int userID; //User ID
        public static string title; //Title of the appointment
        public static string description; //Appointment description
        public static string location; //Location
        public static string contact; //Contact
        public static string type; //Type of appointment
        public static string url; //URL for appointment
        //These are strings as the DateTime format does not match the MYSQL DATETIME Format
        public static string start; //Start time of appointment
        public static string end; //End time of appointment
    }
}
