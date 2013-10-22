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
    public partial class booking : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;

        Int32 count;

        public booking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            homepage c = new homepage();
            c.Show();
            Hide();
        
        }

        private void booking_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1227;PASSWORD=User154;Data Source=nitt";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                    com.Connection = con;
                    MessageBox.Show("CONNECTION SET ");
                      //com.Connection = con;
                      com.CommandText = "select max(bno) from booking";
                      count = Convert.ToInt32(com.ExecuteScalar());
                }
            }
            catch
            {
                MessageBox.Show("CONNECTION FAILED");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (uname.Text != "" & name.Text != "" & type.Text != "" & mob.Text != "" & source.Text != "" & destination.Text != "" & time.Text != "")
            {
                count = count + 1;
                status.Text = "Unprocessed";
                com.Connection = con;
                com.CommandText = "insert into booking(bno,uname,name,type,mob,source,destination,time,status) values ('" + count + "','" + uname.Text + "','" + name.Text + "','" + type.Text + "','" + name.Text + "','" + source.Text + "','" + destination.Text + "','" + time.Text + "','" + status.Text + "')";
                com.ExecuteNonQuery();
                com.Dispose();
                MessageBox.Show("YOUR BOOKING FORM HAS BEEN SUBMITTED\n");
                MessageBox.Show("YOUR BOOKING NUMBER IS : " + (count));
            }
            else
            {
                MessageBox.Show("PLEASE INSERT ALL ENTRIES ");
            }


            Form1 c = new Form1();
            c.Show();
            Hide();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 c = new Form1();
            c.Show();
            Hide();
        }

        private void uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void destination_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void type_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
