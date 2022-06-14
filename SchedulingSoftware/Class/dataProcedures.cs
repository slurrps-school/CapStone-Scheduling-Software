using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using SchedulingSoftware.Data_Models;
using System.Windows.Forms;
using System.IO;
using MySql.Data.Types;
using System.Web.UI.WebControls;
using System.Globalization;

namespace SchedulingSoftware.Class
{
    public class dataProcedures : connection //Inherits Connection class
    {
        //DONE
        //Verify Data in the Database
        #region Verify Data
        //Done
        //Used to Verify User information and login information
        #region Login
        //Verifies if the user exists in the database
        public static bool VerifyUser(string name)
        {
            DataTable results; //DataTable to hold results

            //Set results to SQL string datatable
            results = GetDataTableSQL($"select * from user where userName = '{name}'");

            //Check if any rows returned
            if(results.Rows.Count == 0)
            {
                return false; //False
            }

            return true; //True
        }

        //Verifies the user login information
        public static bool VerifyLogin(string name, string password)
        {
            DataTable results; //DataTable to hold results

            //Hash the password
            password = passwordEncryption.HashedPassword(password);

            //Set results to SQL string datatable
            results = GetDataTableSQL($"select * from user where userName = '{name}' and password = '{password}'");

            //Check if any rows returned
            if (results.Rows.Count == 0)
            {
                return false; //True
            }

            //Update Data Model Users to the incomming user information
            user.userId = (int)results.Rows[0]["userId"]; //UserId
            user.userName = results.Rows[0]["userName"].ToString(); //UserName
            return true; //True
        }
        #endregion

        //DONE
        //Verifies if the Customer exists in the database
        #region Customer
        public static int VerifyCustomer(string custName)
        {
            DataTable results; //Holds the results datatable

            //Set the results table to the incoming table from the SQL query
            results = GetDataTableSQL($"select customerId from customer where customerName = '{custName}'");

            //Try Catch statement to return the customerId
            try
            {
                return (int)results.Rows[0][0]; //Return the CustomerId from the results table
            }
            catch
            {
                return -1; //No rows exists return -1
            }
        }
        #endregion

        //DONE
        //Verifies if the Appointment exists in the database
        #region Appointment
        public static int VerifyAppointment(string title)
        {
            DataTable results; //Holds the results datatable

            //Set the results table to the incoming table from the SQL query
            results = GetDataTableSQL($"select appointmentId from appointment where title = '{title}'");

            //Try Catch statement to return the appointmentId
            try
            {
                return (int)results.Rows[0][0]; //Return the appointmentId from the results table
            }
            catch
            {
                return -1; //No rows exists return -1
            }
        }
        #endregion

        //DONE
        //Verifies if the incomming Address Information Exists in the system
        #region Address Data
        //Verifies if the country exists in the database
        public static int VerifyCountry(string country)
        {
            DataTable results; //Holds the results datatable

            //Set the results table to the incoming table from the SQL query
            results = GetDataTableSQL($"select countryId from country where countryName = '{country}'");

            //Try Catch statement to return the countryId
            try
            {
                return (int)results.Rows[0][0]; //Return the appointmentId from the results table
            }
            catch
            {
                return -1; //No rows exists return -1
            }
        }

        //Verifies if the city with the specific countryId exists in the database
        public static int VerifyCity(string city, int countryId)
        {
            DataTable results; //Holds the results datatable

            //Set the results table to the incoming table from the SQL query
            results = GetDataTableSQL($"select cityId from city where city = '{city}' and countryId = '{countryId}'");

            //Try Catch statement to return the cityId
            try
            {
                return (int)results.Rows[0][0]; //Return the appointmentId from the results table
            }
            catch
            {
                return -1; //No rows exists return -1
            }
        }

        //Verifies if the address with the specific cityId, address1, address2, and postal exists in the database
        public static int VerifyAddress(string curAddress, string curAddress2, int cityId, string curPostal)
        {
            DataTable results; //Holds the results datatable

            //Set the results table to the incoming table from the SQL query
            results = GetDataTableSQL($"select addressId from address where address = '{curAddress}' and address2 = '{curAddress2}' and cityId = '{cityId}' and postalCode = '{curPostal}'");

            //Try Catch statement to return the addressId
            try
            {
                return (int)results.Rows[0][0]; //Return the appointmentId from the results table
            }
            catch
            {
                return -1; //No rows exists return -1
            }
        }
        #endregion

        //DONE
        //Verifies that the times do not overlap with existing appointments and that the incomming times are not for an existing appointment
        #region Time Overlap
        public static bool CheckOverlapTime(string start, string end) //Requires start and end times as strings
        {
            //MySQL Connection
            MySqlConnection conn = new MySqlConnection(BuildPrimaryConnection());

            //Try Statement to run the SQL command to check if the times overlap
            try
            {
                //Open connection
                conn.Open();
                //Create a new command
                MySqlCommand cmd = conn.CreateCommand();
                //Set the command text to check that the appointment does not already exists and does not overlap
                cmd.CommandText = $"select exists(select * from appointment where start <= '{end}' and end >= '{start}' and userId = '{user.userId}')";

                return Convert.ToBoolean(cmd.ExecuteScalar()); //Return the result converted to boolean
            }
            catch (Exception ex)
            {
                throw new Exception("Exception thrown checking for overlapping appointments: " + ex); //Error
            }
            finally
            {
                conn.Close(); //Close the connection
            }
        }
        #endregion
        #endregion

        //DONE
        //Gets requested information from the DB
        #region GetInfo

        //DONE
        //Gets Customer Information from the DB
        #region Customers
        //Gets the selected customer information from the database and then loads it into the data model customer
        public static bool GetCustomerInfo()
        {
            DataTable results;

            //SQL to get all customer information
            results = GetDataTableSQL("select c.customerName, c.active, a.addressId, a.address, a.address2, a.cityId, ci.city, a.postalCode, a.phone ,ci.countryId, co.country " +
                                        "from customer c " +
                                        "inner join address a " +
                                        "on c.addressId = a.addressId " +
                                        "inner join city ci " +
                                        "on ci.cityId = a.cityId " +
                                        "inner join country co " +
                                        "on co.countryId = ci.countryId " +
                                        "where c.customerId = " + customer.customerID);

            try
            {
                //Fill out the customer data model
                customer.customerName = results.Rows[0]["customerName"].ToString();
                customer.isActive = Convert.ToInt32(results.Rows[0]["active"]);
                address.addressID = (int)results.Rows[0]["addressId"];
                address.address1 = results.Rows[0]["address"].ToString();
                address.address2 = results.Rows[0]["address2"].ToString();
                address.postal = results.Rows[0]["postalCode"].ToString();
                address.phone = results.Rows[0]["phone"].ToString();
                address.cityID = (int)results.Rows[0]["cityId"];
                city.cityName = results.Rows[0]["city"].ToString();
                city.countryID = (int)results.Rows[0]["countryId"];
                country.countryName = results.Rows[0]["country"].ToString();
            }
            catch(Exception ex)
            {
                //Error message
                MessageBox.Show("Selected Customer does not exist, " + ex);
                return false;
            }

            return true;
        }

        //Gets all customers in the database
        public static DataTable GetCustomers()
        {
            DataTable results;

            //Gets all of the current customers information in the system
            results = GetDataTableSQL("select c.customerId, c.active, c.customerName, a.address, a.address2, ci.city, a.postalCode, a.phone , co.country " +
                                        "from customer c " +
                                        "inner join address a " +
                                        "on c.addressId = a.addressId " +
                                        "inner join city ci " +
                                        "on ci.cityId = a.cityId " +
                                        "inner join country co " +
                                        "on co.countryId = ci.countryId");

            //Returns a data table
            return results;
        }

        #endregion

        //DONE
        //Gets Appointment information from the DB
        #region Appointments

        //Gets the selected appointment information and loads it into the data models
        public static bool GetAppInfo()
        {
            DataTable results;

            //Searches the selected appointment information
            results = GetDataTableSQL("select a.appointmentId, a.title, a.description, a.location, a.contact, a.type, a.url, a.start, a.end, a.customerId, " +
                "c.customerName, a.userId, u.userName " +
                "from appointment a " +
                "inner join customer c " +
                "on a.customerId = c.customerId " +
                "inner join user u " +
                "on a.userId = u.userId " +
                $"where a.appointmentId = '{appointment.appointmentID}'");

            try
            {
                //Fill out the appointment data model
                appointment.customerID = (int)results.Rows[0]["customerId"];
                appointment.userID = (int)results.Rows[0]["userId"];
                appointment.title = results.Rows[0]["title"].ToString();
                appointment.description = results.Rows[0]["description"].ToString();
                appointment.location = results.Rows[0]["location"].ToString();
                appointment.contact = results.Rows[0]["contact"].ToString();
                appointment.type = results.Rows[0]["type"].ToString();
                appointment.url = results.Rows[0]["url"].ToString();
                appointment.start = results.Rows[0]["start"].ToString();
                appointment.end = results.Rows[0]["end"].ToString();
            }
            catch(Exception ex)
            {
                //Error appointment does not exist
                MessageBox.Show("Appointment does not exist, " + ex);
                return false;
            }

            return true;
        }

        //Gets all the appointments attatched to the user
        ////TODO: Maybe Change to user and selected customer
        public static DataTable GetUserAppointments()
        {
            DataTable results; //Datatable to hold results

            //SQL to search for the appointments
            results = GetDataTableSQL($"Select * from appointment where userId = {user.userId}");

            //Return a datatable
            return results;
        }

        //Gets all appointments in the system minimum information to check start and end times
        public static DataTable GetAllAppts()
        {
            DataTable results; //Datatable to hold results

            //SQL to search for the appointments
            results = GetDataTableSQL($"Select title, description, start, end from appointment where userId = {user.userId}");

            //Return a datatable
            return results;
        }
        #endregion

        //DONE
        //Gets lists of the appointments for a user
        #region Appointment Lists
        //Returns a list of all appointments for logged in user
        public static List<appointments> GetListAppointments()
        {
            //Create a list to hold the appointments
            List<appointments> appts = new List<appointments>();

            //Seti[ the connection
            MySqlConnection conn = new MySqlConnection(BuildPrimaryConnection());


            try
            {
                //Open the connection
                conn.Open();
                //Setup a new sql command
                MySqlCommand cmd = conn.CreateCommand();

                //Search the appointment information based on logged in user
                cmd.CommandText = ($"select a.appointmentId, a.title, a.description, a.location, a.contact, a.type, a.url, a.start, a.end, a.customerId, " +
                "c.customerName, a.userId, u.userName " +
                "from appointment a " +
                "inner join customer c " +
                "on a.customerId = c.customerId " +
                "inner join user u " +
                "on a.userId = u.userId " +
                $"where a.userId = '{user.userId}'");

                cmd.ExecuteNonQuery(); //Execute

                //Using a sql reader read the information
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    //While reading
                    while (reader.Read())
                    {
                        //Add a new appointment to the list appts
                        appts.Add(new appointments()
                        {
                            //Fill in the appointment information
                            customerID = (int)reader["customerId"],
                            customerName = reader["customerName"].ToString(),
                            userName = reader["userName"].ToString(),
                            title = reader["title"].ToString(),
                            description = reader["description"].ToString(),
                            location = reader["location"].ToString(),
                            contact = reader["contact"].ToString(),
                            type = reader["type"].ToString(),
                            url = reader["url"].ToString(),
                            start = Convert.ToDateTime(reader["start"]),
                            end = Convert.ToDateTime(reader["end"])
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close(); //Close the connection
            }

            //Return the list
            return appts;
        }

        //Returns a list of appointments that are within 15 minutes of login
        public static appointments CheckAppReminders()
        {
            //Create a list to hole the appointments
            appointments appt = new appointments();

            //Create a string to format the datetime to the appropriate mysql format
            string currentTime = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");

            //Setup a new connection
            MySqlConnection conn = new MySqlConnection(BuildPrimaryConnection());

            try
            {
                //Open the connection
                conn.Open();
                //Setup a new sql command
                MySqlCommand cmd = conn.CreateCommand();

                //Sql string to search for all appointments for a logged in user that is within 15 minutes of current time
                cmd.CommandText = ($"select a.appointmentId, a.title, a.description, a.location, a.contact, a.type, a.url, a.start, a.end, a.customerId, " +
                "c.customerName, a.userId, u.userName " +
                "from appointment a " +
                "inner join customer c " +
                "on a.customerId = c.customerId " +
                "inner join user u " +
                "on a.userId = u.userId " +
                $"where a.userId = '{user.userId}' and TIMESTAMPDIFF(MINUTE, start, '{currentTime}') < 15");

                cmd.ExecuteNonQuery(); //Execute

                //Using sql reader
                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    //While reading
                    while (reader.Read())
                    {
                        //Fill in appointment data
                        appt.appointmentID = (int)reader["appointmentId"];
                        appt.customerID = (int)reader["customerId"];
                        appt.customerName = reader["customerName"].ToString();
                        appt.title = reader["title"].ToString();
                        appt.description = reader["description"].ToString();
                        appt.location = reader["location"].ToString();
                        appt.contact = reader["contact"].ToString();
                        appt.type = reader["type"].ToString();
                        appt.url = reader["url"].ToString();
                        appt.start = Convert.ToDateTime(reader["start"]);
                        appt.end = Convert.ToDateTime(reader["end"]);
                    }
                }
            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close(); //Close the connection
            }

            //Return list
            return appt;
        }

        public static DateTime FirstDay(int week)
        {
            DateTime jan1 = new DateTime(2021, 1, 1);
            int offset = DayOfWeek.Thursday - jan1.DayOfWeek;

            DateTime firstThursday = jan1.AddDays(offset);
            var cal = CultureInfo.CurrentCulture.Calendar;
            int firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            var weekNum = week;

            if(firstWeek == 1)
            {
                weekNum -= 1;
            }

            var result = firstThursday.AddDays(weekNum * 7);

            return result.AddDays(-4);
        }

        public static List<appointments>GetWeeklyAppts(int week)
        {
            List<appointments> appts = new List<appointments>();
            MySqlConnection conn = new MySqlConnection(BuildPrimaryConnection());

            DateTime startWeek = FirstDay(week);
            DateTime endWeek = startWeek.AddDays(7);


            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"Select start, end, title from appointment where userId = '{user.userId}' and start between '{startWeek.ToString("yyyy-MM-dd HH:mm:ss")}' and '{endWeek.ToString("yyyy-MM-dd HH:mm:ss")}'";

                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        appts.Add(new appointments()
                        {
                            start = Convert.ToDateTime(reader["start"]),
                            end = Convert.ToDateTime(reader["end"]),
                            title = reader["title"].ToString()
                        });
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error getting weeks appointments! \n" + ex);
            }
            finally
            {
                conn.Close();
            }

            return appts;
        }
        #endregion

        #endregion

        //DONE
        //Adds new information to the DB
        #region Create Data

        //Adds new user to the DB
        #region User
        //Creates a new user into the database
        public static bool CreateUser(string userName, string password, string creator)
        {
            //New Connection
            MySqlConnection conn = new MySqlConnection(BuildPrimaryConnection());

            try
            {
                //Open Connection
                conn.Open();
                //New sql Command
                MySqlCommand cmd = conn.CreateCommand();

                //Insert a new customer
                cmd.CommandText = $"insert into user(userName, password, active, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                    $" values('{userName}', '{password}', " +
                $"1, curDate(), '{creator}', timestamp(curDate()), '{creator}')";

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                //Error
                MessageBox.Show("Failed to add a new customer " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close(); //Close connection
            }

            return true;
        }
        #endregion

        //Adds new customer to the DB
        #region Customer
        //Adds a new customer to the database and returns its Id
        public static int AddCustomer()
        {
            int newId, newAddressId, newCityId, newCountryId;
            newId = -1;

            MySqlConnection conn = new MySqlConnection(BuildPrimaryConnection());

            //Check if country exists
            newCountryId = VerifyCountry(country.countryName);
            if(newCountryId == -1)
            {
                newCountryId = AddCountry(country.countryName);
            }

            //Check if city exists
            newCityId = VerifyCity(city.cityName, newCountryId);
            if (newCityId == -1)
            {
                newCityId = AddCity(city.cityName, newCountryId);
            }

            //Check if address exists
            newAddressId = VerifyAddress(address.address1, address.address2, newCityId, address.postal);
            if (newAddressId == -1)
            {
                newAddressId = AddAddress(address.address1, address.address2, newCityId, address.postal, address.phone);
            }

            //Try to add new customer
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = $"insert into customer(customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                    $" values('{customer.customerName}', '{newAddressId}', '{customer.isActive}', curDate(), '{user.userName}', timestamp(curDate()), '{user.userName}')";

                cmd.ExecuteNonQuery();

                cmd.CommandText = "select customerId from customer order by customerId desc limit 1";

                newId = (int)cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                throw new Exception("Failed to add customer" + ex);
            }
            finally
            {
                conn.Close();
            }

            return newId;
        }

        //Adds new Address information to the DB
        #region Address
        //Adds a new country to the database and returns its Id
        public static int AddCountry(string newCountry)
        {
            int newId = -1;

            MySqlConnection conn = new MySqlConnection(BuildPrimaryConnection());

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = $"insert into country(country, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                    $" values('{newCountry}', curDate(), '{user.userName}', timestamp(curDate()), '{user.userName}')";

                cmd.ExecuteNonQuery();

                cmd.CommandText = "select countryId from country order by countryId desc limit 1";

                newId = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return newId;
        }

        //Adds a new city to the database and returns its Id
        public static int AddCity(string newCity, int countryId)
        {
            int newId = -1;

            MySqlConnection conn = new MySqlConnection(BuildPrimaryConnection());

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = $"insert into city(city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                    $" values('{newCity}', '{countryId}', curDate(), '{user.userName}', timestamp(curDate()), '{user.userName}')";

                cmd.ExecuteNonQuery();

                cmd.CommandText = "select cityId from city order by cityId desc limit 1";

                newId = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return newId;
        }

        //Adds a new address to the database and returns its Id
        public static int AddAddress(string newAddress, string newAddress2, int cityId, string newPostal, string newPhone)
        {
            int newId = -1;

            MySqlConnection conn = new MySqlConnection(BuildPrimaryConnection());

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = $"insert into address(address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                    $" values('{newAddress}', '{newAddress2}', '{cityId}', '{newPostal}', '{newPhone}', curDate(), '{user.userName}', timestamp(curDate()), '{user.userName}')";

                cmd.ExecuteNonQuery();

                cmd.CommandText = "select addressId from address order by addressId desc limit 1";

                newId = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return newId;
        }
        #endregion

        #endregion

        //Adds a new appointment to the DB
        #region Appointment
        public static int AddAppointment()
        {
            int newId = -1;

            MySqlConnection conn = new MySqlConnection(BuildPrimaryConnection());

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = $"insert into appointment(customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                    $"values('{appointment.customerID}', '{appointment.userID}', '{appointment.title}', '{appointment.description}', '{appointment.location}', '{appointment.contact}', '{appointment.type}', '{appointment.url}', " +
                    $"'{appointment.start}', '{appointment.end}', curDate(), '{user.userName}', timestamp(curDate()), '{user.userName}')";

                cmd.ExecuteNonQuery();

                cmd.CommandText = "select appointmentId from appointment order by appointmentId desc limit 1";

                newId = (int)cmd.ExecuteScalar();
            }
            catch
            {
                throw new Exception("Failed to add appointment!");
            }
            finally
            {
                conn.Close();
            }

            return newId;
        }
        #endregion
        #endregion

        //DONE
        //Updates data from the DB
        #region Update Data
        //Updates the selected customer in the database
        public static bool UpdateCustomer()
        {
            int newAddressId, newCityId, newCountryId;

            MySqlConnection conn = new MySqlConnection(BuildPrimaryConnection());

            //Check if country exists
            newCountryId = VerifyCountry(country.countryName);
            if (newCountryId == -1)
            {
                newCountryId = AddCountry(country.countryName);
            }

            //Check if city exists
            newCityId = VerifyCity(city.cityName, newCountryId);
            if (newCityId == -1)
            {
                newCityId = AddCity(city.cityName, newCountryId);
            }

            //Check if address exists
            newAddressId = VerifyAddress(address.address1, address.address2, newCityId, address.postal);
            if (newAddressId == -1)
            {
                newAddressId = AddAddress(address.address1, address.address2, newCityId, address.postal, address.phone);
            }

            //Try updating customer
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();



                cmd.CommandText = $"update customer set " +
                    $"customerName = '{customer.customerName}', " +
                    $"addressId = '{newAddressId}', " +
                    $"active = '{customer.isActive}', " +
                    $"lastUpdate = timestamp(curDate()), " +
                    $"lastUpdateBy = '{user.userName}' " +
                    $"where customerId = '{customer.customerID}'";

                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Failed to update customer information");
            }
            finally
            {
                conn.Close();
            }

            return true;
        }

        //Updates the selected appointment in the DB
        public static bool UpdateAppointment()
        {
            MySqlConnection conn = new MySqlConnection(BuildPrimaryConnection());

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = $"update appointment set " +
                    $"customerId = '{appointment.customerID}', " +
                    $"userId = '{appointment.userID}', " +
                    $"title = '{appointment.title}', " +
                    $"description = '{appointment.description}', " +
                    $"location = '{appointment.location}', " +
                    $"contact = '{appointment.contact}', " +
                    $"type = '{appointment.type}', " +
                    $"url = '{appointment.url}', " +
                    $"start = '{appointment.start}', " +
                    $"end = '{appointment.end}' " +
                    $"where appointmentId = '{appointment.appointmentID}'";
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Failed to update appointment!");
            }
            finally
            {
                conn.Close();
            }

            return true;
        }
        #endregion

        //DONE
        //Deletes data from the DB
        #region Delete Data
        //Deletes the selected customer
        public static bool DeleteCustomer()
        {
            MySqlConnection conn = new MySqlConnection(BuildPrimaryConnection());

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = $"delete from customer where customerId = '{customer.customerID}'";

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                //throw new Exception("Failed to delete customer!");
                MessageBox.Show("Cannot delete a customer with an existing appointment, please be sure to delete their appointment first! " + ex);
                return false;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }

        //Deletes the selected appointment
        public static bool DeleteAppointment()
        {
            MySqlConnection conn = new MySqlConnection(BuildPrimaryConnection());

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = $"delete from appointment where appointmentId = '{appointment.appointmentID}'";

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }
        #endregion

        //TODO Update 
        //Gets information for reports from the DB
        #region Reports
        //Get the distinct number of types of appointments by month
        public static DataTable GetApptTypesByMonth()
        {
            DataTable results;

            results = GetDataTableSQL("Select MonthName(createDate) Month, type, Count(type) as Types from appointment group by type order by createDate, type");

            return results;
        }

        public static DataTable GetWeeklyHours()
        {
            DataTable results;

            results = GetDataTableSQL("SELECT distinct u.userName, sec_to_time(sum(time_to_sec(timediff(a.end, a.start)))) as hours " +
                "FROM   appointment a " +
                "inner join user u " +
                "on u.userId = a.userId " +
                "WHERE  YEARWEEK(`start`, 1) = YEARWEEK(CURDATE(), 1)" +
                "Group By u.userName; ");

            return results;
        }

        public static DataTable GetUserSchedules()
        {
            DataTable results;

            results = GetDataTableSQL("Select u.userName, a.Title, c.customerName, a.start, a.end " +
                "from appointment a " +
                "inner join user u " +
                "on u.userId = a.userId " +
                "inner join customer c " +
                "on c.customerId = a.customerId " +
                "WHERE  YEARWEEK(`start`, 1) = YEARWEEK(CURDATE(), 1) " +
                "order by a.start, u.userName; ");

            return results;
        }

        
        #endregion

        //DONE
        //Logs Activity
        #region Logs
        //Logs user activity of logging on
        public static void logUserActivity(string logText)
        {
            //Gets current directory information to write the log file to.
            DirectoryInfo info = new DirectoryInfo(".");

            string logPath = info + "\\logFile.txt";//<---- change directory
            if (!File.Exists(logPath))
            {
                var file = File.Create(logPath);
                file.Close();
                TextWriter textWriter = new StreamWriter(logPath);
                textWriter.WriteLine(logText);
                textWriter.Close();
            }
            else if (File.Exists(logPath))
            {
                using (var textWriter = new StreamWriter(logPath, true))
                {
                    textWriter.WriteLine(logText);
                }
            }
        }

        //Logs the errors produced from the program
        public static void LogErrorActivity(string logText)
        {
            //Gets current directory information to write the log file to.
            DirectoryInfo info = new DirectoryInfo(".");

            string logPath = info + "\\errorFile.txt";//<---- change directory
            if (!File.Exists(logPath))
            {
                var file = File.Create(logPath);
                file.Close();
                TextWriter textWriter = new StreamWriter(logPath);
                textWriter.WriteLine(logText);
                textWriter.Close();
            }
            else if (File.Exists(logPath))
            {
                using (var textWriter = new StreamWriter(logPath, true))
                {
                    textWriter.WriteLine(logText);
                }
            }
        }
        #endregion

        //DONE
        //Search Customers or Applications
        #region Search
        //TEST SEARCH 
        public static DataTable SearchCustomer(string name)
        {
            DataTable results; //DataTable to hold results

            //Set results to SQL string datatable
            results = GetDataTableSQL("select c.customerId, c.active, c.customerName, a.address, a.address2, ci.city, a.postalCode, a.phone, co.country " +
                                        "from customer c " +
                                        "inner join address a " +
                                        "on c.addressId = a.addressId " +
                                        "inner join city ci " +
                                        "on ci.cityId = a.cityId " +
                                        "inner join country co " +
                                        "on co.countryId = ci.countryId " +
                                        $"where c.customerName like '%{name}%'");

            return results; //True
        }

        public static DataTable SearchAppointment(string name)
        {
            DataTable results; //DataTable to hold results

            //Set results to SQL string datatable
            results = GetDataTableSQL($"select * from appointment where title like '%{name}%'");

            return results; //True
        }
        #endregion
    }
}
