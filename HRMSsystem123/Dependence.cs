using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HRMSsystem123
{
    public partial class Dependence : Form
    {
        public Dependence()
        {
            InitializeComponent();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal h = new Personal();
            h.Show();
            this.Hide();
        }

        private void dependentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dependence d = new Dependence();
            d.Show();
            this.Hide();
        }

        private void emergencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emergency E = new Emergency();
            E.Show();
            this.Hide();
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendance A = new Attendance();
            A.Show();
            this.Hide();
        }

        private void bankDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankDetails B = new BankDetails();
            B.Show();
            this.Hide();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary s = new Salary();
            s.Show();
            this.Hide();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.Show();
            this.Hide();
        }

        private void trainingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Training t = new Training();
            t.Show();
            this.Hide();
        }

        private void certificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Certificate c = new Certificate();
            c.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Dependence_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            Personal h = new Personal();
            h.Show();
            this.Hide();
        }

        private void btnDependent_Click(object sender, EventArgs e)
        {
            Dependence d = new Dependence();
            d.Show();
            this.Hide();
        }

        private void btnEmergency_Click(object sender, EventArgs e)
        {
            Emergency E = new Emergency();
            E.Show();
            this.Hide();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Attendance A = new Attendance();
            A.Show();
            this.Hide();
        }

        private void lblEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Personal h = new Personal();
            h.Show();
            this.Hide();
        }

        private void Pay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BankDetails B = new BankDetails();
            B.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Training B = new Training();
            B.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Login a = new Login();
            a.Show();
            this.Hide();
        }

        private void txtfather_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfather_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtEmpid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Employee Id ");

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployee_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Personal h = new Personal();
            h.Show();
            this.Hide();
        }

        private void Pay_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BankDetails B = new BankDetails();
            B.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Training B = new Training();
            B.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            About_Us B = new About_Us();
            B.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Contact_Us B = new Contact_Us();
            B.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ANUSHA\SQLEXPRESS;Initial Catalog=HRMSSystems;Integrated security=true");
            SqlCommand cmd = new SqlCommand("Empdependent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@status", "INSERT");
            cmd.Parameters.AddWithValue("@EmpID", txtEmpid.Text);
            cmd.Parameters.AddWithValue("@FatherName", txtfather.Text);
            cmd.Parameters.AddWithValue("@FcontactNo", txtfconno.Text);
            cmd.Parameters.AddWithValue("@MotherName", txtmother.Text);
            cmd.Parameters.AddWithValue("@McontactNo", txtmconno.Text);
            cmd.Parameters.AddWithValue("@partnerName", txtpartname.Text);
            cmd.Parameters.AddWithValue("@PartnerNo", txtpartnum.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Details Saved successfully.....!!!");
            foreach (Control X in this.Controls)
            {
                if (X is TextBox)
                    X.Text = "";
            }
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void txtEmpid_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Employee Id ");

            }
        }

        private void txtfather_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Name ");

            }
        }

        private void txtmother_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Name ");

            }
        }

        private void txtpartname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Name ");

            }
        }

        private void txtfconno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Contact No. ");

            }
        }

        private void txtmconno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Contact No. ");

            }
        }

        private void txtpartnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Contact No. ");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home B = new Home();
            B.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
