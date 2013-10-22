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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login c = new login();
            c.Show();
            Hide();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            signup c = new signup();
            c.Show();
            Hide();

        }
        private void homepage_Load(object sender, EventArgs e)
        {

        }

        private void AUTO_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            managerlogin c = new managerlogin();
            c.Show();
            Hide();
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
