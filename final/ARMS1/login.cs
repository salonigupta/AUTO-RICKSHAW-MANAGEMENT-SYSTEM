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
    public partial class login : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;

        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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


            com.Connection = con;
            com.CommandText = "select pword from account where uname='" + uname.Text + "' ";

            string pwd = Convert.ToString(com.ExecuteScalar());

            bool result = pwd.Equals(pword.Text, StringComparison.Ordinal);

            if (result)
            {
                Form1 c = new Form1();
                c.Show();
                Hide();
            }
            else
            {
                uname.Text = "";
                pword.Text = "";
                MessageBox.Show("INVALID CREDENTIALS");
            }        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homepage c = new homepage();
            c.Show();
            Hide();
        
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void pword_TextChanged(object sender, EventArgs e)
        {

        }

       

    }
}
