using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ARMS1
{
    public partial class managerlogin : Form
    {
        public managerlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pword.Text == "saloni")
            {
                MessageBox.Show("MANAGER LOGIN SUCCESSFUL");
                checkbooking c = new checkbooking();
                c.Show();
                Hide();
            }
        }

        private void pword_TextChanged(object sender, EventArgs e)
        {

        }

        private void managerlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
