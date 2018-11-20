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
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Fill up all the fields for Login");
                return;
            }

            try
            {
                connection CN = new connection();
                CN.thisConnection.Open();
                OracleCommand thisCommand = new OracleCommand();
                thisCommand.Connection = CN.thisConnection;
                thisCommand.CommandText = "SELECT * FROM admin WHERE username='" + textBox1.Text + "' AND password='" + textBox2.Text + "'";
                OracleDataReader thisReader = thisCommand.ExecuteReader();

                if (thisReader.Read())
                {
                    Admin_Option oform = new Admin_Option();
                    oform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("username or password incorrect");
                }
                CN.thisConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void admin_login_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
