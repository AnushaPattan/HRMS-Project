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
    public partial class Home : Form
    {
        public Home()
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
        private void GoFullscreen(bool fullscreen)
        {
            
        }
        private void Home_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
           
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btngo_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=ANUSHA\SQLEXPRESS;Initial Catalog=HRMSSystems;Integrated security=true");
            if (txtSearchemp.Text != "")
            {
               
                string s = "select * from tblEmployeePersonal where EmpID=@EmpID ";
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.CommandType = CommandType.Text;
                // cmd.Parameters.AddWithValue("@status", "SELECT");
                con.Open();
                cmd.Parameters.AddWithValue("@EmpID", txtSearchemp.Text);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Visible = true;


                con.Close();
            }
            else
            {
               // DataTable dt = new DataTable();
                //SqlConnection con = new SqlConnection(@"Data Source=VMD-PC\SQLEXPRESS;Initial Catalog=HRMSSystems;Integrated security=true");
                string s = "select * from tblEmployeePersonal ";
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.CommandType = CommandType.Text;
                // cmd.Parameters.AddWithValue("@status", "SELECT");
                con.Open();
                cmd.Parameters.AddWithValue("@EmpID", txtSearchemp.Text);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Visible = true;


                con.Close();
            }
           
            foreach (Control X in this.Controls)
            {
                if (X is TextBox)
                    X.Text = "";
            }
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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Login a = new Login();
            a.Show();
            this.Hide();
        }

        private void txtSearchemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmpId_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            About_Us d = new About_Us();
            d.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Contact_Us d = new Contact_Us();
            d.Show();
            this.Hide();
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home B = new Home();
            B.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            
            
               DataTable dt = new DataTable();
               SqlConnection con = new SqlConnection(@"Data Source=ANUSHA\SQLEXPRESS;Initial Catalog=HRMSSystems;Integrated security=true");
                string s = "select * from tblEmployeePersonal ";
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@status", "SELECT");
                con.Open();
                cmd.Parameters.AddWithValue("@EmpID", txtSearchemp.Text);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Visible = true;
                con.Close();
            
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=ANUSHA\SQLEXPRESS;Initial Catalog=HRMSSystems;Integrated security=true");
            string s = "select * from tblPayBankDetails ";
            SqlCommand cmd = new SqlCommand(s, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@status", "SELECT");
            con.Open();
            cmd.Parameters.AddWithValue("@EmpID", txtSearchemp.Text);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible=false;
            txtSearchemp.Text = " ";

        }

    }
}
