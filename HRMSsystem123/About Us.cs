using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSsystem123
{
    public partial class About_Us : Form
    {
        public About_Us()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void About_Us_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dependentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void emergencyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home a = new Home();
            a.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
