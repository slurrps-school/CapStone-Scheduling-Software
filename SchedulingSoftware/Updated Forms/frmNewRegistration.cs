using MaterialSkin.Controls;
using SchedulingSoftware.Class;
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
    public partial class frmNewRegistration : MaterialForm
    {
        private frmNewLogin login;
        private string password = "";

        public frmNewRegistration()
        {
            InitializeComponent();
        }

        private void frmNewRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            //hide this form
            this.Hide();
            //Create new formLoging form
            login = new frmNewLogin();
            //Show the login form
            login.Show();
        }

        //Exit the application
        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Check that the fields are all filled out
            if (txtUserName.Text == "" || txtPassword.Text == "" || txtConfirmPass.Text == "" || txtCreatedBy.Text == "")
            {
                //Error message
                MessageBox.Show("Please fill out all fields!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Verify that the user doesn't already exists
                if (dataProcedures.VerifyUser(txtUserName.Text))
                {
                    //Error message
                    MessageBox.Show("This UserName already exists!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    password = passwordEncryption.HashedPassword(txtPassword.Text);
                    //Check if the user was created
                    if (dataProcedures.CreateUser(txtUserName.Text.ToLower(), password, txtCreatedBy.Text))
                    {
                        //Show success message
                        MessageBox.Show("Registration Successful!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Clear the textboxes
                        txtUserName.Clear();
                        txtPassword.Clear();
                        txtConfirmPass.Clear();
                        txtCreatedBy.Clear();
                        //Hide the form
                        this.Hide();
                        //Create new login form
                        login = new frmNewLogin();
                        //Show the form
                        login.Show();
                    }
                    else
                    {
                        //Error on creation
                        MessageBox.Show("Creation error please try again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
