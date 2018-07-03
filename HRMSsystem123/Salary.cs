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
    public partial class Salary : Form
    {
        public Salary()
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
            if (txtempid.Text == "")
            {
                MessageBox.Show("Please enter all the Mandatory fields");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=ANUSHA\SQLEXPRESS;Initial Catalog=HRMSSystems;Integrated security=true");
                SqlCommand cmd = new SqlCommand("PaySalaryDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@status", "INSERT");
                cmd.Parameters.AddWithValue("@EmpID", txtempid.Text);
                cmd.Parameters.AddWithValue("@Designation", txtdesignation.Text);
                cmd.Parameters.AddWithValue("@Salary", txtsalary.Text);
                cmd.Parameters.AddWithValue("@Payscale", txtpayscale.Text);


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
        }

        private void Salary_Load(object sender, EventArgs e)
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

        private void btnBankDetails_Click(object sender, EventArgs e)
        {
            BankDetails b = new BankDetails();
            b.Show();
            this.Hide();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            Salary s = new Salary();
            s.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report s = new Report();
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Login a = new Login();
            a.Show();
            this.Hide();
        }

        private void txtempid_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQualification_Click(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Training h = new Training ();
            h.Show();
            this.Hide();
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            About_Us h = new About_Us();
            h.Show();
            this.Hide();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contact_Us h = new Contact_Us ();
            h.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtempid.Text == "" || txtdesignation.Text == "" || txtsalary.Text == "" || txtpayscale.Text == "" )
            {
                MessageBox.Show("Please enter all the Mandatory fields");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=ANUSHA\SQLEXPRESS;Initial Catalog=HRMSSystems;Integrated security=true");
                SqlCommand cmd = new SqlCommand("PaySalaryDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@status", "INSERT");
                cmd.Parameters.AddWithValue("@EmpID", txtempid.Text);
                cmd.Parameters.AddWithValue("@Designation", txtdesignation.Text);
                cmd.Parameters.AddWithValue("@Salary", txtsalary.Text);
                cmd.Parameters.AddWithValue("@Payscale", txtpayscale.Text);


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
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void txtempid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Employee ID ");

            }
        }

        private void txtpayscale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Employee pay scale ");

            }
        }

        private void txtsalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Employee salary ");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home B = new Home();
            B.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
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
