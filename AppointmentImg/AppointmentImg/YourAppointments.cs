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
    public partial class YourAppointments : Form
    {
        public YourAppointments()
        {
            InitializeComponent();
        }


        private void BookingSummary_Load(object sender, EventArgs e)
        {
            lblFullName.Text = Appointments.fullName;
            lblDepart.Text = Appointments.departure;
            lblDest.Text = Appointments.destination;
            lblTrip.Text = Appointments.tripDates;
            lblPassNo.Text = Appointments.passportNo;
            lblPassExpiryDate.Text = Appointments.passExpiry.ToString();
            lblEstimate.Text = Appointments.estimateWeight;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            Appointments obj = new Appointments();
            obj.Show();
        }
    }
}
