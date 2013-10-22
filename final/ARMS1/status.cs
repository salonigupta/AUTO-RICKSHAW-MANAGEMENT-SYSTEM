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
    public partial class status : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
       // OleDbDataReader dr;

        public status()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            homepage c = new homepage();
            c.Show();
            Hide();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 c = new Form1();
            c.Show();
            Hide();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1227;PASSWORD=User154;Data Source=nitt";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                    MessageBox.Show("CONNECTION SET");
                    
                    com.Connection = con;
                    com.CommandText = "select status from booking where bno='" + bno.Text + "' ";
                    string status = Convert.ToString(com.ExecuteScalar());
                    MessageBox.Show("YOUR BOOKING STATUS IS : " + (status));
                }
            }
            catch
            {
                MessageBox.Show("CONNECTION FAILED");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void status_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
