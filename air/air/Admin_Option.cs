using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OracleClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace air
{
    public partial class Admin_Option : Form
    {
        public Admin_Option()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fare_Table1 ft = new Fare_Table1();
            ft.Show();
            this.Hide();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            seat_plan sp = new seat_plan();
            sp.Show();
            this.Hide();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            admin_login al = new admin_login();
            al.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Passenger_Info ob = new Passenger_Info();
            ob.Show();
            this.Hide();
        }

        private void Admin_Option_Load(object sender, EventArgs e)
        {

        }
    }
}
