using MaterialSkin.Controls;
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
    public partial class frmNewLogin : MaterialForm
    {
        private string userError = "";
        private string passwordError = "";

        public frmNewLogin()
        {
            InitializeComponent();

            //Show the correct region language
            ShowCorrectLanguage();

            //Focus on the username box
            txtUserName.Focus();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            //Hide this form
            this.Hide();
            //Create a new registration form
            frmNewRegistration registration = new frmNewRegistration();
            //show the form
            registration.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (dataProcedures.VerifyUser(txtUserName.Text))
            {
                if (dataProcedures.VerifyLogin(txtUserName.Text.ToLower(), txtPassword.Text))
                {
                    //Create a new dateTime to hold current time
                    DateTime dateTime = DateTime.Now;
                    //Log user login to file
                    dataProcedures.logUserActivity("Username: '" + user.userName + "'. UserID: " + user.userId + ". Logged in at " + dateTime);

                    //Hide this form
                    this.Hide();
                    //Create new main form
                    frmNewMain main = new frmNewMain();
                    //Show form
                    main.Show();

                    //Check for upcoming appointments and fill it with the dataprocedure CheckAppReminders
                    //This checks for any appointments within 15 minutes of users time
                    appointments upcomingAppt = dataProcedures.CheckAppReminders();

                    //Check if the list is empty
                    if (upcomingAppt.appointmentID != -1)
                    {
                        //Show a reminder for each appointment in the list
                        //There should only be one realistically
                        ShowReminders(upcomingAppt);
                    }
                }
                else
                {
                    //Password Error login credentials do not match db
                    MessageBox.Show(passwordError);
                }
            }
            else
            {
                //User error User not found
                MessageBox.Show(userError);
            }
        }


        //Exit Application
        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();


        //Lambda to open a new appointment reminder
        Action<appointments> ShowReminders = (appt) => new frmNewReminder(appt).ShowDialog();

        #region Methods
        public void ShowCorrectLanguage()
        {
            //Check region with switch statement
            switch (RegionInfo.CurrentRegion.EnglishName)
            {
                case "United States":
                    ShowInEnglish();
                    break;

                case "Mexico":
                    ShowInSpanish();
                    break;
            }
        }

        //Show form in English
        public void ShowInEnglish()
        {
            lblIntro.Text = "Please login";
            lblUserName.Text = "Username:";
            lblPassword.Text = "Password:";
            btnRegistration.Text = "Register";
            btnLogin.Text = "Login";
            //btnExit.Text = "Exit";
            //this.Text = "Login Screen";
            userError = "User does not exist, please try again!";
            passwordError = "username and password do not match please try again!";
        }

        //Show form in Spanish
        public void ShowInSpanish()
        {
            lblIntro.Text = "Por favor Iniciar sesión";
            lblUserName.Text = "Nombre de usuario:";
            lblPassword.Text = "Contraseña:";
            btnRegistration.Text = "Registrarse";
            btnLogin.Text = "Acceso";
            //btnExit.Text = "Salida";
            //this.Text = "Pantalla de ingreso al sistema";
            userError = "El usuario no existe, inténtelo de nuevo.";
            passwordError = "El nombre de usuario y la contraseña no coinciden. Inténtelo de nuevo.";
        }
        #endregion

        private void frmNewLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
