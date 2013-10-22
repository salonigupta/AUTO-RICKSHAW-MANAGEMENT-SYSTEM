using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ARMS1
{
    public partial class checkbooking : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        Int64 count0;

        public checkbooking()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            com.CommandText = "update booking set status='Booked' where bno='" + count0 + "' ";

            com.ExecuteNonQuery();
            // com.Dispose();
            MessageBox.Show("THE BOOKING REQUEST HAS BEEN ACCEPTED");      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homepage c = new homepage();
            c.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            managerlogin c = new managerlogin();
            c.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            com.Connection = con;

            com.CommandText = "select * from booking where status='Unprocessed' ";

            dr = com.ExecuteReader();
            dr.Read();
            //while (dr.Read())
            //{
            //MessageBox.Show("u r in");
            count0 = Convert.ToInt32(dr[0].ToString());
            string count2 = Convert.ToString(dr.GetString(1));
            string count3 = Convert.ToString(dr.GetString(1));
            string count4 = Convert.ToString(dr.GetString(4));
            string count5 = Convert.ToString(dr.GetString(5));
            string count6 = Convert.ToString(dr.GetString(6));
            string count7 = Convert.ToString(dr.GetString(1));

            MessageBox.Show("\nBooking No: " + (count0) + "\nName: " + (count2) + "\nType: " + (count3) + "\nMobile: " + (count4) + "\nSource: " + (count5) + "\nDestination: " + (count6) + "\nTime: " + (count7));
            //}
            dr.Close();
        }

        private void checkbooking_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1227;PASSWORD=User154;Data Source=nitt";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                    MessageBox.Show("CONNECTION SET");
                }
            }
            catch
            {
                MessageBox.Show("CONNECTION FAILED");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            com.CommandText = "update booking set status='Discarded' where bno='" + count0 + "' ";

            com.ExecuteNonQuery();
            // com.Dispose();
            MessageBox.Show("THE BOOKING REQUEST HAS BEEN DISCARDED");    
        }
    }
}
