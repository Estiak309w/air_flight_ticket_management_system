using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace air
{
    public partial class Flight_Details : Form
    {
        public Flight_Details(string country,string date,string time,string fare)
        {
            InitializeComponent();
            textBox1.Text = country;
            textBox2.Text = date;
            textBox3.Text = time;
            textBox4.Text = fare;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
