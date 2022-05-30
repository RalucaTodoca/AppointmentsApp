using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentImg
{
    public partial class Appointments : Form
    {
        public static string fullName;
        public static string departure;
        public static string destination;
        public static string tripDates;
        public static string passportNo;
        public static DateTime passExpiry;
        public static string estimateWeight;

        public Appointments()
        {
            InitializeComponent();
        }

        private void makingVisible()
        {
            lblDocNo.Visible = true;
            lblDocIssueDate.Visible = true;
            lblDocExpiryDate.Visible = true;

            txtDocNo.Visible = true;
            dtpDocIssueDate.Visible = true;
            dtpDocExpiryDate.Visible = true;
        }

        private void rbPassport_CheckedChanged(object sender, EventArgs e)
        {
            makingVisible();

            lblDocNo.Text = "Nr pasaport";
            lblDocIssueDate.Text = "Data emitere pasaport";
            lblDocExpiryDate.Text = "Data expirare pasaport";
        }

        private void rbIdentity_CheckedChanged(object sender, EventArgs e)
        {
            makingVisible();

            lblDocNo.Text = "Nr CI";
            lblDocIssueDate.Text = "Data emitere CI";
            lblDocExpiryDate.Text = "Data expirare CI";
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (txtDeparture.Text == "" | txtDestination.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtDocNo.Text == "")
            {
                MessageBox.Show("Enter Appropriate Values", "Missing Values");
            }
            else
            {
                fullName = txtFirstName.Text + " " + txtLastName.Text;
                departure = txtDeparture.Text;
                destination = txtDestination.Text;
                passportNo = txtDocNo.Text;

                string startDate = Convert.ToString(monthCalendar1.SelectionStart);
                string endDate = Convert.ToString(monthCalendar1.SelectionEnd);
                tripDates = startDate + " To " + endDate;

                passExpiry = dtpDocExpiryDate.Value;
                estimateWeight = numericUpDownBaggage.Value.ToString();

                YourAppointments bForm = new YourAppointments();
                bForm.Show();
                Hide();
            }
        }
    }


 }


