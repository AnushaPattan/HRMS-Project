using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSsystem123
{
    public partial class Training : Form
    {
        public Training()
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
            SqlConnection con = new SqlConnection(@"Data Source=ANUSHA\SQLEXPRESS;Initial Catalog=HRMSSystems;Integrated security=true");
            SqlCommand cmd = new SqlCommand("trainingDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@status","INSERT");
            cmd.Parameters.AddWithValue("@EmpID", txtempid.Text);
            cmd.Parameters.AddWithValue("@CandidateId", txtcandidateid.Text);
            cmd.Parameters.AddWithValue("@Location", txtlocation.Text);
            cmd.Parameters.AddWithValue("@Duration", txtduration.Text);
            cmd.Parameters.AddWithValue("@provider", txtprovider.Text);
           // cmd.Parameters.AddWithValue("@Duration", txtduration.Text);


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Details Saved successfully....!!!");
            foreach (Control X in this.Controls)
            {
                if (X is TextBox)
                    X.Text = "";
            }
        }

        private void Training_Load(object sender, EventArgs e)
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

        private void lblEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Personal h = new Personal();
            h.Show();
            this.Hide();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnBankDetails_Click(object sender, EventArgs e)
        {
            Training B = new Training();
            B.Show();
            this.Hide();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            Certificate c = new Certificate();
            c.Show();
            this.Hide();
        }

        private void Pay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BankDetails B = new BankDetails();
            B.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Login a = new Login();
            a.Show();
            this.Hide();
        }

        private void btnSalary_Click_1(object sender, EventArgs e)
        {
            Certificate B = new Certificate ();
            B.Show();
            this.Hide();
        }

        private void btnBankDetails_Click_1(object sender, EventArgs e)
        {
            Training a = new Training ();
            a.Show();
            this.Hide();
        }

        private void lblEmployee_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Personal a = new Personal();
            a.Show();
            this.Hide();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personal a = new Personal ();
            a.Show();
            this.Hide();
        }

        private void listBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            BankDetails a = new BankDetails ();
            a.Show();
            this.Hide();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            About_Us a = new About_Us();
            a.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtempid.Text == "" || txtcandidateid.Text == "" || txtlocation.Text == "" || txtduration.Text == "" || txtprovider.Text == "")
            {
                MessageBox.Show("Please enter all the Mandatory fields");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=ANUSHA\SQLEXPRESS;Initial Catalog=HRMSSystems;Integrated security=true");
                SqlCommand cmd = new SqlCommand("trainingDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@status", "INSERT");
                cmd.Parameters.AddWithValue("@EmpID", txtempid.Text);
                cmd.Parameters.AddWithValue("@CandidateId", txtcandidateid.Text);
                cmd.Parameters.AddWithValue("@Location", txtlocation.Text);
                cmd.Parameters.AddWithValue("@Duration", txtduration.Text);
                cmd.Parameters.AddWithValue("@provider", txtprovider.Text);
                // cmd.Parameters.AddWithValue("@Duration", txtduration.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Details Saved successfully....!!!");
                foreach (Control X in this.Controls)
                {
                    if (X is TextBox)
                        X.Text = "";
                }
            }
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            Home a = new Home();
            a.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Training a = new Training();
            a.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Contact_Us a = new Contact_Us ();
            a.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            About_Us a = new About_Us();
            a.Show();
            this.Hide();
        }

        private void Pay_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            BankDetails a = new BankDetails();
            a.Show();
            this.Hide();
        }

        private void txtempid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Employee Id ");

            }
        }

        private void txtcandidateid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Candidate Id ");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home B = new Home();
            B.Show();
            this.Hide();
        }
        
    }
}
