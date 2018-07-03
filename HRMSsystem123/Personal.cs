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
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Training B = new Training();
            B.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            About_Us B = new About_Us();
           /// Training B = new Training();
            B.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Contact_Us B = new Contact_Us();
           // Training B = new Training();
            B.Show();
            this.Hide();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {

            Personal B = new Personal();
            // Training B = new Training();
            B.Show();
            this.Hide();
        }

        private void btnDependent_Click(object sender, EventArgs e)
        {

            Dependence B = new Dependence();
            // Training B = new Training();
            B.Show();
            this.Hide();
        }

        private void btnEmergency_Click(object sender, EventArgs e)
        {

            Emergency B = new Emergency();
            // Training B = new Training();
            B.Show();
            this.Hide();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {

            Attendance B = new Attendance();
            // Training B = new Training();
            B.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {

            Home B = new Home();
            // Training B = new Training();
            B.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtEmpid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtfather_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmother_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpartnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtempid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Employee Id ");

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblEmpId_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Pay_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BankDetails B = new BankDetails();
            B.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtempid.Text == "" || txtname1.Text == "" || txtQualificatio.Text == "" || txtcontact.Text == "" || txtExperience.Text == "")
            {
                MessageBox.Show("Please enter all the Mandatory fields");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=ANUSHA\SQLEXPRESS;Initial Catalog=HRMSSystems;Integrated security=true");
                    string s = "insert into tblEmployeePersonal values(@EmpID,@EmpName,@Qualification,@DOB,@Skills,@Gender,@Address,@ContactNo,@DOJ,@Experience,@MeritalStatus)";
                    SqlCommand cmd = new SqlCommand(s, con);
                    cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.AddWithValue("@status", "INSERT");
                    cmd.Parameters.AddWithValue("@EmpID", txtempid.Text);
                    cmd.Parameters.AddWithValue("@EmpName", txtname1.Text);
                    cmd.Parameters.AddWithValue("@Qualification", txtQualificatio.Text);
                    cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@Skills", txtskills.Text);
                    cmd.Parameters.AddWithValue("@Gender", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", txtcontact.Text);
                    cmd.Parameters.AddWithValue("@DOJ", dateTimePicker2.Value.Date);
                    cmd.Parameters.AddWithValue("@Experience", txtExperience.Text);
                    cmd.Parameters.AddWithValue("@MeritalStatus", " Single");
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
                catch (Exception ex)
                {
                    MessageBox.Show("Exception handled by catch block");
                }
            }
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void lblEmployee_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Personal h = new Personal();
            h.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Training B = new Training();
            B.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            About_Us B = new About_Us();
            B.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Contact_Us B = new Contact_Us();
            B.Show();
            this.Hide();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            BankDetails h = new BankDetails ();
            h.Show();
            this.Hide();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personal h = new Personal ();
            h.Show();
            this.Hide();
        }

        private void txtempid_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtempid_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Employee Id ");

            }
        }

        private void txtname1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQualificatio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQualificatio_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtname1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Employee Name ");

            }
        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Contact No. ");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home B = new Home();
            B.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            txtempid.Text = " ";
            txtname1.Text = " ";
            txtQualificatio.Text = " ";
            //dateTimePicker1.Text = " ";
            txtskills.Text = " ";
            textBox1.Text = " ";
            comboBox1.Text = " ";
            txtaddress.Text = " ";
            txtcontact.Text = " ";
            groupBox2.Text = " ";
            txtExperience.Text = " ";
        }
    }
}
