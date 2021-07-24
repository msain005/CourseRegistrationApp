namespace CoursemoApp
{
    partial class Form1
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
            this.cmdEnroll = new System.Windows.Forms.Button();
            this.txtclassSize = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.cmdCourses = new System.Windows.Forms.Button();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.cmdStudents = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdDrop = new System.Windows.Forms.Button();
            this.lstRegistration = new System.Windows.Forms.ListBox();
            this.lstWaitlist = new System.Windows.Forms.ListBox();
            this.lststudentReg = new System.Windows.Forms.ListBox();
            this.lststudentWait = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimeInMS = new System.Windows.Forms.TextBox();
            this.cmdSwap = new System.Windows.Forms.Button();
            this.swpList2 = new System.Windows.Forms.ComboBox();
            this.swpList1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdEnroll
            // 
            this.cmdEnroll.Location = new System.Drawing.Point(657, 246);
            this.cmdEnroll.Name = "cmdEnroll";
            this.cmdEnroll.Size = new System.Drawing.Size(112, 55);
            this.cmdEnroll.TabIndex = 32;
            this.cmdEnroll.Text = "Enroll";
            this.cmdEnroll.UseVisualStyleBackColor = true;
            this.cmdEnroll.Click += new System.EventHandler(this.cmdEnroll_Click);
            // 
            // txtclassSize
            // 
            this.txtclassSize.Location = new System.Drawing.Point(472, 339);
            this.txtclassSize.Name = "txtclassSize";
            this.txtclassSize.Size = new System.Drawing.Size(127, 26);
            this.txtclassSize.TabIndex = 31;
            this.txtclassSize.Text = "Class Size";
            this.txtclassSize.TextChanged += new System.EventHandler(this.txtclassSize_TextChanged);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(472, 307);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(127, 26);
            this.txtTime.TabIndex = 30;
            this.txtTime.Text = "Time";
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(472, 275);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(127, 26);
            this.txtDay.TabIndex = 29;
            this.txtDay.Text = "Day";
            this.txtDay.TextChanged += new System.EventHandler(this.txtDay_TextChanged);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(341, 339);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(125, 26);
            this.txtType.TabIndex = 28;
            this.txtType.Text = "Type";
            this.txtType.TextChanged += new System.EventHandler(this.txtType_TextChanged);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(341, 307);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(125, 26);
            this.txtYear.TabIndex = 27;
            this.txtYear.Text = "Year";
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(341, 275);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(125, 26);
            this.txtSemester.TabIndex = 26;
            this.txtSemester.Text = "Semester";
            this.txtSemester.TextChanged += new System.EventHandler(this.txtSemester_TextChanged);
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 20;
            this.lstCourses.Location = new System.Drawing.Point(341, 85);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(258, 184);
            this.lstCourses.TabIndex = 25;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            // 
            // cmdCourses
            // 
            this.cmdCourses.Location = new System.Drawing.Point(657, 164);
            this.cmdCourses.Name = "cmdCourses";
            this.cmdCourses.Size = new System.Drawing.Size(112, 56);
            this.cmdCourses.TabIndex = 24;
            this.cmdCourses.Text = "Courses";
            this.cmdCourses.UseVisualStyleBackColor = true;
            this.cmdCourses.Click += new System.EventHandler(this.cmdCourses_Click);
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 20;
            this.lstStudents.Location = new System.Drawing.Point(31, 85);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(258, 184);
            this.lstStudents.TabIndex = 23;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
            // 
            // cmdStudents
            // 
            this.cmdStudents.Location = new System.Drawing.Point(657, 85);
            this.cmdStudents.Name = "cmdStudents";
            this.cmdStudents.Size = new System.Drawing.Size(112, 56);
            this.cmdStudents.TabIndex = 22;
            this.cmdStudents.Text = "Students";
            this.cmdStudents.UseVisualStyleBackColor = true;
            this.cmdStudents.Click += new System.EventHandler(this.cmdStudents_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1133, 33);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetDatabaseToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // resetDatabaseToolStripMenuItem
            // 
            this.resetDatabaseToolStripMenuItem.Name = "resetDatabaseToolStripMenuItem";
            this.resetDatabaseToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.resetDatabaseToolStripMenuItem.Text = "Reset database";
            this.resetDatabaseToolStripMenuItem.Click += new System.EventHandler(this.resetDatabaseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(212, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cmdDrop
            // 
            this.cmdDrop.Location = new System.Drawing.Point(657, 325);
            this.cmdDrop.Name = "cmdDrop";
            this.cmdDrop.Size = new System.Drawing.Size(112, 55);
            this.cmdDrop.TabIndex = 34;
            this.cmdDrop.Text = "Drop";
            this.cmdDrop.UseVisualStyleBackColor = true;
            this.cmdDrop.Click += new System.EventHandler(this.cmdDrop_Click);
            // 
            // lstRegistration
            // 
            this.lstRegistration.FormattingEnabled = true;
            this.lstRegistration.ItemHeight = 20;
            this.lstRegistration.Location = new System.Drawing.Point(341, 371);
            this.lstRegistration.Name = "lstRegistration";
            this.lstRegistration.Size = new System.Drawing.Size(125, 84);
            this.lstRegistration.TabIndex = 35;
            this.lstRegistration.SelectedIndexChanged += new System.EventHandler(this.lstRegistration_SelectedIndexChanged);
            // 
            // lstWaitlist
            // 
            this.lstWaitlist.FormattingEnabled = true;
            this.lstWaitlist.ItemHeight = 20;
            this.lstWaitlist.Location = new System.Drawing.Point(472, 371);
            this.lstWaitlist.Name = "lstWaitlist";
            this.lstWaitlist.Size = new System.Drawing.Size(127, 84);
            this.lstWaitlist.TabIndex = 36;
            // 
            // lststudentReg
            // 
            this.lststudentReg.FormattingEnabled = true;
            this.lststudentReg.ItemHeight = 20;
            this.lststudentReg.Location = new System.Drawing.Point(31, 275);
            this.lststudentReg.Name = "lststudentReg";
            this.lststudentReg.Size = new System.Drawing.Size(125, 84);
            this.lststudentReg.TabIndex = 37;
            // 
            // lststudentWait
            // 
            this.lststudentWait.FormattingEnabled = true;
            this.lststudentWait.ItemHeight = 20;
            this.lststudentWait.Location = new System.Drawing.Point(162, 275);
            this.lststudentWait.Name = "lststudentWait";
            this.lststudentWait.Size = new System.Drawing.Size(127, 84);
            this.lststudentWait.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(653, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Delay";
            // 
            // txtTimeInMS
            // 
            this.txtTimeInMS.Location = new System.Drawing.Point(657, 429);
            this.txtTimeInMS.Name = "txtTimeInMS";
            this.txtTimeInMS.Size = new System.Drawing.Size(100, 26);
            this.txtTimeInMS.TabIndex = 39;
            // 
            // cmdSwap
            // 
            this.cmdSwap.Location = new System.Drawing.Point(820, 85);
            this.cmdSwap.Name = "cmdSwap";
            this.cmdSwap.Size = new System.Drawing.Size(112, 56);
            this.cmdSwap.TabIndex = 41;
            this.cmdSwap.Text = "Swap";
            this.cmdSwap.UseVisualStyleBackColor = true;
            this.cmdSwap.Click += new System.EventHandler(this.cmdSwap_Click);
            // 
            // swpList2
            // 
            this.swpList2.FormattingEnabled = true;
            this.swpList2.Location = new System.Drawing.Point(820, 227);
            this.swpList2.Name = "swpList2";
            this.swpList2.Size = new System.Drawing.Size(192, 28);
            this.swpList2.TabIndex = 42;
            this.swpList2.SelectedIndexChanged += new System.EventHandler(this.swpList2_SelectedIndexChanged);
            // 
            // swpList1
            // 
            this.swpList1.FormattingEnabled = true;
            this.swpList1.Location = new System.Drawing.Point(820, 164);
            this.swpList1.Name = "swpList1";
            this.swpList1.Size = new System.Drawing.Size(301, 28);
            this.swpList1.TabIndex = 43;
            this.swpList1.SelectedIndexChanged += new System.EventHandler(this.swpList1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 504);
            this.Controls.Add(this.swpList1);
            this.Controls.Add(this.swpList2);
            this.Controls.Add(this.cmdSwap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimeInMS);
            this.Controls.Add(this.lststudentWait);
            this.Controls.Add(this.lststudentReg);
            this.Controls.Add(this.lstWaitlist);
            this.Controls.Add(this.lstRegistration);
            this.Controls.Add(this.cmdDrop);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cmdEnroll);
            this.Controls.Add(this.txtclassSize);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtSemester);
            this.Controls.Add(this.lstCourses);
            this.Controls.Add(this.cmdCourses);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.cmdStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdEnroll;
        private System.Windows.Forms.TextBox txtclassSize;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Button cmdCourses;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Button cmdStudents;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button cmdDrop;
        private System.Windows.Forms.ListBox lstRegistration;
        private System.Windows.Forms.ListBox lstWaitlist;
        private System.Windows.Forms.ListBox lststudentReg;
        private System.Windows.Forms.ListBox lststudentWait;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimeInMS;
        private System.Windows.Forms.Button cmdSwap;
        private System.Windows.Forms.ComboBox swpList2;
        private System.Windows.Forms.ComboBox swpList1;
    }
}

