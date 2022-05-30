using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppointmentImg

{
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e) //Schedule button
        {
            Schedule schedule= new Schedule();
            schedule.Show();

        }

        private void button1_Click(object sender, EventArgs e) //Appointments button
        {
            Appointments appointments = new Appointments();
            appointments.Show();

        }

        
    }
}



