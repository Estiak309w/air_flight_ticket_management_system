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
    public partial class Passenger_login : Form
    {
        public static string sendtext = "";
        public Passenger_login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            passenger_signin ps = new passenger_signin();
            ps.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
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
                thisCommand.CommandText = "SELECT name,password,masterid,email,sex,age from passenger_signin WHERE name='" + textBox1.Text + "' AND password='" + textBox2.Text + "'";
                
                OracleDataReader thisReader = thisCommand.ExecuteReader();

                if (thisReader.Read())
                {
                    string sp = thisReader["masterid"].ToString();
                    string name = textBox1.Text;
                    string password = textBox2.Text;
                    string email = thisReader["email"].ToString();
                    string sex = thisReader["sex"].ToString();
                    string age = thisReader["age"].ToString();
                    
                    Passenger oform = new Passenger(name,password,sp,email,sex,age);
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

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Passenger_login_Load(object sender, EventArgs e)
        {

        }
    }
}
