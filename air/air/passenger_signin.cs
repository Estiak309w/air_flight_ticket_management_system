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
    public partial class passenger_signin : Form
    {
        public passenger_signin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            usernamExistCheck();


            //////////////////////////////
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Fill up all the fields");
                return;
            }

            try
            {
                connection cn = new connection();
                cn.thisConnection.Open();

                OracleCommand cmnd;

                string query;

                query = "insert into passenger_signin (name,age,email,password,masterid,sex) values('" + textBox1.Text.ToString() + "'," + "'" + textBox2.Text.ToString() + "'," + "'" + textBox3.Text.ToString() + "'," + "'"+textBox4.Text.ToString()+"',"+" '"+textBox5.Text.ToString()+"',"+"'"+comboBox1.Text.ToString()+"')";

                cmnd = new OracleCommand(query, cn.thisConnection);

                cmnd.ExecuteNonQuery();

                MessageBox.Show("added in database");

                cmnd.Dispose();

                cn.thisConnection.Close();

                cn.thisConnection.Dispose();

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Fill up all fields");
            }


        }

        private void usernamExistCheck()
        {
            connection sv = new connection();
            sv.thisConnection.Open();

            OracleCommand thisCommand = sv.thisConnection.CreateCommand();

            thisCommand.CommandText = "select name from passenger_signin where username= '" + textBox1.Text + "'";

            thisCommand.Connection = sv.thisConnection;
            thisCommand.CommandType = CommandType.Text;

            try
            {
                OracleDataReader thisReader = thisCommand.ExecuteReader();

                while (thisReader.Read())
                {

                    string sp = thisReader["name"].ToString();


                    try
                    {
                        if (sp != "")
                        {
                            MessageBox.Show("Username Id Already exists try another username then press ok!!!");
                            sv.thisConnection.Close();
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Failure");
                    }
                }
                thisReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Username is not Avaliable");
                return;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Passenger_login pl = new Passenger_login();
            pl.Show();
            this.Hide();
        }
    }
}
