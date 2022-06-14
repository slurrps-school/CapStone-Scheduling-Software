using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSoftware.Data_Models
{
    //Static Address for single customer
    public static class address
    {
        //Address data model
        public static int addressID; //ID
        public static string address1; //Address line 1
        public static string address2; //Address line 2 apt
        public static int cityID; //City ID
        public static string postal; //Postal Code of address
        public static string phone; //Phone of address
    }
}
