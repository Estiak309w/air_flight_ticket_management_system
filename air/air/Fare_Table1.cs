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
    public partial class Fare_Table1 : Form
    {
        public Fare_Table1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text == "")
                {

                }
                else if (textBox1.Text == "")
                {
                    MessageBox.Show("Fill up fields then press ok");
                    return;
                }

                if (textBox1.Text != "")
                {
                    connection CN = new connection();
                    CN.thisConnection.Open();



                    OracleCommand thisCommand = new OracleCommand();

                    thisCommand.Connection = CN.thisConnection;

                    thisCommand.CommandType = CommandType.Text;
                    thisCommand.CommandText = "select * from fare1 where visit_country='" + textBox1.Text + "' ";

                    OracleDataReader thisReader = thisCommand.ExecuteReader();

                    listView1.Items.Clear();

                    while (thisReader.Read())
                    {

                        ListViewItem lsvItem = new ListViewItem();
                        lsvItem.Text = thisReader["visit_country"].ToString();
                        lsvItem.SubItems.Add(thisReader["flight_date"].ToString());
                        lsvItem.SubItems.Add(thisReader["flight_time"].ToString());
                        lsvItem.SubItems.Add(thisReader["oneway_fare"].ToString());
                       

                        listView1.Items.Add(lsvItem);
                    }



                    // thisCommand.Dispose();

                    CN.thisConnection.Close();
                }

            }
            catch (Exception dx)
            {
                MessageBox.Show(dx.ToString());
            }

        }
    }
}
