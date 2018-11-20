using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace air
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            admin_login ob = new admin_login();
            ob.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Passenger_login pl = new Passenger_login();
            pl.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

       
               

        }
            






    
        
    }
}
