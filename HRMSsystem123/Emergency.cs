﻿using System;
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
    public partial class Emergency : Form
    {
        public Emergency()
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
            SqlCommand cmd = new SqlCommand("EmpEmergency", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@status", "INSERT");
            cmd.Parameters.AddWithValue("@EmpID", txtempid.Text);
            cmd.Parameters.AddWithValue("@FName", txtname1.Text);
            cmd.Parameters.AddWithValue("@ContactNo", txtcontact1.Text);
            cmd.Parameters.AddWithValue("@Relationship", txtrelationship1.Text);
            cmd.Parameters.AddWithValue("@Address", txtaddress1.Text);
            cmd.Parameters.AddWithValue("@SName", "");
            cmd.Parameters.AddWithValue("@FName1", txtname2.Text);
            cmd.Parameters.AddWithValue("@ContactNo1", txtcontact2.Text);
            cmd.Parameters.AddWithValue("@Relationship1", txtrelationship2.Text);
            cmd.Parameters.AddWithValue("@Address1", txtaddress2.Text);
            cmd.Parameters.AddWithValue("@SName1", "");

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

        private void Emergency_Load(object sender, EventArgs e)
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

        private void listBo_SelectedIndexChanged(object sender, EventArgs e)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtname2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaddress1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Login a = new Login();
            a.Show();
            this.Hide();
        }

        private void txtrelationship1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Personal h = new Personal();
            h.Show();
            this.Hide();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Pay_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BankDetails B = new BankDetails();
            B.Show();
            this.Hide();
        }

        private void lblEmployee_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Personal B = new Personal();
            B.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPersonal_Click_1(object sender, EventArgs e)
        {

            Personal d = new Personal();
            d.Show();
            this.Hide();
        }

        private void btnDependent_Click_1(object sender, EventArgs e)
        {

            Dependence d = new Dependence ();
            d.Show();
            this.Hide();
        }

        private void btnEmergency_Click_1(object sender, EventArgs e)
        {

            Emergency d = new Emergency ();
            d.Show();
            this.Hide();
        }

        private void btnAttendance_Click_1(object sender, EventArgs e)
        {

            Attendance d = new Attendance();
            d.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ANUSHA\SQLEXPRESS;Initial Catalog=HRMSSystems;Integrated security=true");
            SqlCommand cmd = new SqlCommand("EmpEmergency", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@status", "INSERT");
            cmd.Parameters.AddWithValue("@EmpID", txtempid.Text);
            cmd.Parameters.AddWithValue("@FName", txtname1.Text);
            cmd.Parameters.AddWithValue("@ContactNo", txtcontact1.Text);
            cmd.Parameters.AddWithValue("@Relationship", txtrelationship1.Text);
            cmd.Parameters.AddWithValue("@Address", txtaddress1.Text);
            cmd.Parameters.AddWithValue("@SName", "");
            cmd.Parameters.AddWithValue("@FName1", txtname2.Text);
            cmd.Parameters.AddWithValue("@ContactNo1", txtcontact2.Text);
            cmd.Parameters.AddWithValue("@Relationship1", txtrelationship2.Text);
            cmd.Parameters.AddWithValue("@Address1", txtaddress2.Text);
            cmd.Parameters.AddWithValue("@SName1", "");

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

        private void txtempid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Employee Id ");

            }
        }

        private void txtname1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtempid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Name ");

            }
        }

        private void txtcontact1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Contact No. ");

            }
        }

        private void txtcontact2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Contact No. ");

            }
        }

        private void txtname2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtname2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) == false)
            {
                MessageBox.Show("Please Enter Valid Name ");

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