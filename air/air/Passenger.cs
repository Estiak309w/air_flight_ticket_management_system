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
    public partial class Passenger : Form
    {
        public Passenger(string name,string password,string sp,string email,string sex,string age)
        {
            InitializeComponent();
            textBox1.Text = name;
            textBox2.Text = password;
            textBox5.Text = sp;
            textBox6.Text = email;
           string gender=sex;
           string boyosh= age;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Fill up all the fields");
                return;
            }

            try
            {
                connection cn = new connection();
                cn.thisConnection.Open();

                OracleCommand cmnd;
                OracleCommand cmnd2;

                string query;
                
                query = "insert into passenger_record (name,departure,arrival,catagory,masterid,email) values(   '" + textBox1.Text.ToString() + "',  " + " '"+ textBox7.Text.ToString() +"',"+" '" + textBox3.Text.ToString() + "'," + " '" +comboBox1.Text.ToString() + "', " + " '" + textBox5.Text.ToString() + "', " + "   '" + textBox6.Text.ToString() + "'   )";

                cmnd = new OracleCommand(query, cn.thisConnection);

                cmnd.ExecuteNonQuery();

                MessageBox.Show("added in database");

                cmnd.Dispose();

                //ariplane
               

                cn.thisConnection.Close();

                cn.thisConnection.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }



        }
    }
}
