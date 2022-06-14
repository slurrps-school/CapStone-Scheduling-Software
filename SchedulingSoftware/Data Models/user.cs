using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSoftware.Data_Models
{
    //Static users for current logged in user
    //Only one logged in user at a time per program so can be static
    public static class user
    {
        //User Data Model
        public static int userId; //ID
        public static string userName; //user Name
    }
}
