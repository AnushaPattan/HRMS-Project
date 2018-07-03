namespace HRMSsystem123
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dependentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emergencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.certificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearchemp = new System.Windows.Forms.TextBox();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.btngo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.Pay = new System.Windows.Forms.LinkLabel();
            this.lblEmployee = new System.Windows.Forms.LinkLabel();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.payToolStripMenuItem,
            this.trainingToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.contactUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalToolStripMenuItem,
            this.dependentToolStripMenuItem,
            this.emergencyToolStripMenuItem,
            this.attendanceToolStripMenuItem});
            this.employeeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.personalToolStripMenuItem.Text = "Personal";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            // 
            // dependentToolStripMenuItem
            // 
            this.dependentToolStripMenuItem.Name = "dependentToolStripMenuItem";
            this.dependentToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.dependentToolStripMenuItem.Text = "Dependent";
            this.dependentToolStripMenuItem.Click += new System.EventHandler(this.dependentToolStripMenuItem_Click);
            // 
            // emergencyToolStripMenuItem
            // 
            this.emergencyToolStripMenuItem.Name = "emergencyToolStripMenuItem";
            this.emergencyToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.emergencyToolStripMenuItem.Text = "Emergency";
            this.emergencyToolStripMenuItem.Click += new System.EventHandler(this.emergencyToolStripMenuItem_Click);
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            this.attendanceToolStripMenuItem.Click += new System.EventHandler(this.attendanceToolStripMenuItem_Click);
            // 
            // payToolStripMenuItem
            // 
            this.payToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bankDetailsToolStripMenuItem,
            this.salaryToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.payToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payToolStripMenuItem.Name = "payToolStripMenuItem";
            this.payToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.payToolStripMenuItem.Text = "Pay";
            // 
            // bankDetailsToolStripMenuItem
            // 
            this.bankDetailsToolStripMenuItem.Name = "bankDetailsToolStripMenuItem";
            this.bankDetailsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.bankDetailsToolStripMenuItem.Text = "Bank Details";
            this.bankDetailsToolStripMenuItem.Click += new System.EventHandler(this.bankDetailsToolStripMenuItem_Click);
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.salaryToolStripMenuItem.Text = "Salary";
            this.salaryToolStripMenuItem.Click += new System.EventHandler(this.salaryToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // trainingToolStripMenuItem
            // 
            this.trainingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainingToolStripMenuItem1,
            this.certificateToolStripMenuItem});
            this.trainingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingToolStripMenuItem.Name = "trainingToolStripMenuItem";
            this.trainingToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.trainingToolStripMenuItem.Text = "Training";
            // 
            // trainingToolStripMenuItem1
            // 
            this.trainingToolStripMenuItem1.Name = "trainingToolStripMenuItem1";
            this.trainingToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.trainingToolStripMenuItem1.Text = "Training";
            this.trainingToolStripMenuItem1.Click += new System.EventHandler(this.trainingToolStripMenuItem1_Click);
            // 
            // certificateToolStripMenuItem
            // 
            this.certificateToolStripMenuItem.Name = "certificateToolStripMenuItem";
            this.certificateToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.certificateToolStripMenuItem.Text = "Certificate";
            this.certificateToolStripMenuItem.Click += new System.EventHandler(this.certificateToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            // 
            // txtSearchemp
            // 
            this.txtSearchemp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSearchemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchemp.Location = new System.Drawing.Point(28, 81);
            this.txtSearchemp.Name = "txtSearchemp";
            this.txtSearchemp.Size = new System.Drawing.Size(338, 22);
            this.txtSearchemp.TabIndex = 79;
            this.txtSearchemp.TextChanged += new System.EventHandler(this.txtSearchemp_TextChanged);
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpId.Location = new System.Drawing.Point(186, 102);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(139, 16);
            this.lblEmpId.TabIndex = 78;
            this.lblEmpId.Text = "Search Employee :";
            this.lblEmpId.Click += new System.EventHandler(this.lblEmpId_Click);
            // 
            // btngo
            // 
            this.btngo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btngo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngo.Location = new System.Drawing.Point(782, 96);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(54, 29);
            this.btngo.TabIndex = 80;
            this.btngo.Text = "GO";
            this.btngo.UseVisualStyleBackColor = false;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1067, 355);
            this.dataGridView1.TabIndex = 81;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(991, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 35);
            this.button1.TabIndex = 95;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lblEmpId);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btngo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(252, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1118, 165);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Index";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RosyBrown;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(896, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 36);
            this.button5.TabIndex = 284;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.txtSearchemp);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(331, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 114);
            this.groupBox3.TabIndex = 107;
            this.groupBox3.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(232, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(129, 24);
            this.radioButton2.TabIndex = 97;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bank Details";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(66, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(158, 24);
            this.radioButton1.TabIndex = 96;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Personal Details";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.listBox6);
            this.groupBox2.Controls.Add(this.listBox5);
            this.groupBox2.Controls.Add(this.linkLabel3);
            this.groupBox2.Controls.Add(this.Pay);
            this.groupBox2.Controls.Add(this.lblEmployee);
            this.groupBox2.Controls.Add(this.listBox4);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.listBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 411);
            this.groupBox2.TabIndex = 105;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Module";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(74, 229);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(71, 16);
            this.linkLabel2.TabIndex = 114;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "About Us";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(70, 285);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 16);
            this.linkLabel1.TabIndex = 113;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Contact Us";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // listBox6
            // 
            this.listBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 20;
            this.listBox6.Location = new System.Drawing.Point(31, 215);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(166, 44);
            this.listBox6.TabIndex = 112;
            // 
            // listBox5
            // 
            this.listBox5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 20;
            this.listBox5.Location = new System.Drawing.Point(32, 273);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(166, 44);
            this.listBox5.TabIndex = 111;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(74, 168);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(65, 16);
            this.linkLabel3.TabIndex = 110;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Training";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked_1);
            // 
            // Pay
            // 
            this.Pay.AutoSize = true;
            this.Pay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay.Location = new System.Drawing.Point(88, 110);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(35, 16);
            this.Pay.TabIndex = 109;
            this.Pay.TabStop = true;
            this.Pay.Text = "Pay";
            this.Pay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Pay_LinkClicked_1);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(72, 54);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(78, 16);
            this.lblEmployee.TabIndex = 108;
            this.lblEmployee.TabStop = true;
            this.lblEmployee.Text = "Employee";
            this.lblEmployee.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEmployee_LinkClicked_1);
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 20;
            this.listBox4.Location = new System.Drawing.Point(31, 154);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(167, 44);
            this.listBox4.TabIndex = 107;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(32, 41);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(167, 44);
            this.listBox2.TabIndex = 105;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(31, 97);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(167, 44);
            this.listBox3.TabIndex = 106;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HRMSsystem123.Properties.Resources.images_3;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 184);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 167);
            this.pictureBox2.TabIndex = 106;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HRMSsystem123.Properties.Resources.FinalHRMS;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1370, 159);
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dependentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emergencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem certificateToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearchemp;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel Pay;
        private System.Windows.Forms.LinkLabel lblEmployee;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button5;
    }
}

