using MaterialSkin.Controls;
using SchedulingSoftware.Class;
using SchedulingSoftware.Data_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingSoftware.Updated_Forms
{
    public partial class frmNewReports : MaterialForm
    {
        public frmNewReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            //Set the aapointment radial to be selected by default
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }

        private void btnApptTypes_Click(object sender, EventArgs e)
        {
            //Data table to hold distinct appointment type by month
            DataTable dt = dataProcedures.GetApptTypesByMonth();
            dgReports.DataSource = dt;
        }

        private void btnSchedules_Click(object sender, EventArgs e)
        {
            //Data table to hold distinct appointment type by month
            DataTable dt = dataProcedures.GetUserSchedules();
            dgReports.DataSource = dt;
        }

        private void btnHours_Click(object sender, EventArgs e)
        {
            //Data table to hold distinct appointment type by month
            DataTable dt = dataProcedures.GetWeeklyHours();
            dgReports.DataSource = dt;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if(dgReports.Rows.Count == 0)
            {
                MessageBox.Show("No rows to export please be sure to choose a report first!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Create new save file dialog
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv"; //Set save file dialog filters
                sfd.FileName = "Output.csv"; //Set save file dialog default file name

                //savefile dialog result is OK?
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //Set the datagridview to copy the header text
                        dgReports.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                        //Select all content
                        dgReports.SelectAll();
                        //Create a data object and set the clipboard content to it.
                        DataObject data = dgReports.GetClipboardContent();

                        //Write all text to the file giving the data object.GetText method formatting it as comma separated.
                        File.WriteAllText(sfd.FileName, data.GetText(TextDataFormat.CommaSeparatedValue), Encoding.UTF8);
                        MessageBox.Show("Data Exported Successfully !!!", "Info");
                    }
                    catch (Exception ex)
                    {
                        //Error when exporting data
                        MessageBox.Show("Error when exporting data:" + ex.Message);
                    }
                }
            }
        }
    }
}
