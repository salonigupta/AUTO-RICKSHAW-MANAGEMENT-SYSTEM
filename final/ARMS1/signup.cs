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
    public partial class signup : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
       OleDbDataReader dr;

        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
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


        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text != "" & name.Text != "" & pword.Text != "" & addr.Text != "" & mob.Text != "" & type.Text != "")
            {
                com.Connection = con;
                com.CommandText = "insert into account(name,uname,pword,addr,mob,type) values ('" + name.Text + "','" + uname.Text + "','" + pword.Text + "','" + addr.Text + "','" + mob.Text + "','" + type.Text + "')";
                com.ExecuteNonQuery();
                com.Dispose();
                MessageBox.Show("USER PROFILE CREATED FOR THE USER   "+(name.Text));

                login c = new login();
                c.Show();
                Hide();
        
            }
            else
            {
                MessageBox.Show("PLEASE INSERT ALL DETAILS");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homepage c = new homepage();
            c.Show();
            Hide();
        }

        private void uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
