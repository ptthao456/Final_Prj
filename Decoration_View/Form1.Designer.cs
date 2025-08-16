namespace Final_Prj.Decoration_View
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.txtSDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnScreate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSSubject = new System.Windows.Forms.TextBox();
            this.txtSStatus = new System.Windows.Forms.TextBox();
            this.txtSDescription = new System.Windows.Forms.TextBox();
            this.txtSTaskName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.txtWDue = new System.Windows.Forms.DateTimePicker();
            this.btnWcreate = new System.Windows.Forms.Button();
            this.WorkStudy = new System.Windows.Forms.Label();
            this.txtWtype = new System.Windows.Forms.TextBox();
            this.txtWstatus = new System.Windows.Forms.TextBox();
            this.txtWDes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnViewW = new System.Windows.Forms.Button();
            this.btnViewS = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Location = new System.Drawing.Point(319, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 191);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogout.Location = new System.Drawing.Point(236, 153);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(43, 121);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(67, 13);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Please login!";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(134, 153);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Location = new System.Drawing.Point(236, 153);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.txtLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(124, 80);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(187, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(124, 35);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(187, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Task Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "DueDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Subject";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Priority";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Description";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.trackBar2);
            this.panel2.Controls.Add(this.txtSDueDate);
            this.panel2.Controls.Add(this.btnScreate);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtSSubject);
            this.panel2.Controls.Add(this.txtSStatus);
            this.panel2.Controls.Add(this.txtSDescription);
            this.panel2.Controls.Add(this.txtSTaskName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(503, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 314);
            this.panel2.TabIndex = 3;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(164, 192);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(213, 45);
            this.trackBar2.TabIndex = 7;
            // 
            // txtSDueDate
            // 
            this.txtSDueDate.Location = new System.Drawing.Point(165, 127);
            this.txtSDueDate.Name = "txtSDueDate";
            this.txtSDueDate.ShowCheckBox = true;
            this.txtSDueDate.Size = new System.Drawing.Size(213, 20);
            this.txtSDueDate.TabIndex = 17;
            // 
            // btnScreate
            // 
            this.btnScreate.Enabled = false;
            this.btnScreate.Location = new System.Drawing.Point(410, 63);
            this.btnScreate.Name = "btnScreate";
            this.btnScreate.Size = new System.Drawing.Size(75, 23);
            this.btnScreate.TabIndex = 14;
            this.btnScreate.Text = "Create";
            this.btnScreate.UseVisualStyleBackColor = true;
            this.btnScreate.Click += new System.EventHandler(this.btnScreate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(183, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Task Study";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtSSubject
            // 
            this.txtSSubject.Location = new System.Drawing.Point(164, 242);
            this.txtSSubject.Name = "txtSSubject";
            this.txtSSubject.Size = new System.Drawing.Size(213, 20);
            this.txtSSubject.TabIndex = 11;
            // 
            // txtSStatus
            // 
            this.txtSStatus.Location = new System.Drawing.Point(164, 160);
            this.txtSStatus.Name = "txtSStatus";
            this.txtSStatus.Size = new System.Drawing.Size(214, 20);
            this.txtSStatus.TabIndex = 9;
            // 
            // txtSDescription
            // 
            this.txtSDescription.Location = new System.Drawing.Point(164, 96);
            this.txtSDescription.Multiline = true;
            this.txtSDescription.Name = "txtSDescription";
            this.txtSDescription.Size = new System.Drawing.Size(213, 20);
            this.txtSDescription.TabIndex = 7;
            // 
            // txtSTaskName
            // 
            this.txtSTaskName.Location = new System.Drawing.Point(164, 67);
            this.txtSTaskName.Name = "txtSTaskName";
            this.txtSTaskName.Size = new System.Drawing.Size(213, 20);
            this.txtSTaskName.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Controls.Add(this.txtWDue);
            this.panel3.Controls.Add(this.btnWcreate);
            this.panel3.Controls.Add(this.WorkStudy);
            this.panel3.Controls.Add(this.txtWtype);
            this.panel3.Controls.Add(this.txtWstatus);
            this.panel3.Controls.Add(this.txtWDes);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtWname);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Location = new System.Drawing.Point(9, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(488, 314);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(164, 193);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(213, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // txtWDue
            // 
            this.txtWDue.Location = new System.Drawing.Point(164, 131);
            this.txtWDue.Name = "txtWDue";
            this.txtWDue.ShowCheckBox = true;
            this.txtWDue.Size = new System.Drawing.Size(213, 20);
            this.txtWDue.TabIndex = 17;
            // 
            // btnWcreate
            // 
            this.btnWcreate.Enabled = false;
            this.btnWcreate.Location = new System.Drawing.Point(406, 68);
            this.btnWcreate.Name = "btnWcreate";
            this.btnWcreate.Size = new System.Drawing.Size(75, 23);
            this.btnWcreate.TabIndex = 15;
            this.btnWcreate.Text = "Create";
            this.btnWcreate.UseVisualStyleBackColor = true;
            this.btnWcreate.Click += new System.EventHandler(this.btnWcreate_Click);
            // 
            // WorkStudy
            // 
            this.WorkStudy.AutoSize = true;
            this.WorkStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkStudy.Location = new System.Drawing.Point(195, 16);
            this.WorkStudy.Name = "WorkStudy";
            this.WorkStudy.Size = new System.Drawing.Size(99, 24);
            this.WorkStudy.TabIndex = 12;
            this.WorkStudy.Text = "Work Task";
            this.WorkStudy.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtWtype
            // 
            this.txtWtype.Location = new System.Drawing.Point(164, 244);
            this.txtWtype.Name = "txtWtype";
            this.txtWtype.Size = new System.Drawing.Size(213, 20);
            this.txtWtype.TabIndex = 11;
            // 
            // txtWstatus
            // 
            this.txtWstatus.Location = new System.Drawing.Point(164, 160);
            this.txtWstatus.Name = "txtWstatus";
            this.txtWstatus.Size = new System.Drawing.Size(214, 20);
            this.txtWstatus.TabIndex = 9;
            // 
            // txtWDes
            // 
            this.txtWDes.Location = new System.Drawing.Point(164, 96);
            this.txtWDes.Multiline = true;
            this.txtWDes.Name = "txtWDes";
            this.txtWDes.Size = new System.Drawing.Size(213, 20);
            this.txtWDes.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "TaskType";
            // 
            // txtWname
            // 
            this.txtWname.Location = new System.Drawing.Point(164, 67);
            this.txtWname.Name = "txtWname";
            this.txtWname.Size = new System.Drawing.Size(213, 20);
            this.txtWname.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Priority";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Status";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "DueDate";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Description";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(22, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Task Name";
            // 
            // btnViewW
            // 
            this.btnViewW.AutoSize = true;
            this.btnViewW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewW.Location = new System.Drawing.Point(741, 383);
            this.btnViewW.Name = "btnViewW";
            this.btnViewW.Size = new System.Drawing.Size(107, 28);
            this.btnViewW.TabIndex = 5;
            this.btnViewW.Text = "Work Task Board";
            this.btnViewW.UseVisualStyleBackColor = true;
            this.btnViewW.Visible = false;
            this.btnViewW.Click += new System.EventHandler(this.btnViewW_Click);
            // 
            // btnViewS
            // 
            this.btnViewS.AutoSize = true;
            this.btnViewS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewS.Location = new System.Drawing.Point(740, 434);
            this.btnViewS.Name = "btnViewS";
            this.btnViewS.Size = new System.Drawing.Size(107, 29);
            this.btnViewS.TabIndex = 5;
            this.btnViewS.Text = "Study Task Board";
            this.btnViewS.UseVisualStyleBackColor = true;
            this.btnViewS.Visible = false;
            this.btnViewS.Click += new System.EventHandler(this.btnViewS_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.monthCalendar1.Location = new System.Drawing.Point(18, 378);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(915, 589);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1014, 627);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnViewS);
            this.Controls.Add(this.btnViewW);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhóm 9";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSSubject;
        private System.Windows.Forms.TextBox txtSStatus;
        private System.Windows.Forms.TextBox txtSDescription;
        private System.Windows.Forms.TextBox txtSTaskName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label WorkStudy;
        private System.Windows.Forms.TextBox txtWstatus;
        private System.Windows.Forms.TextBox txtWDes;
        private System.Windows.Forms.TextBox txtWname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnWcreate;
        private System.Windows.Forms.Button btnScreate;
        private System.Windows.Forms.TextBox txtWtype;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txtWDue;
        private System.Windows.Forms.DateTimePicker txtSDueDate;
        private System.Windows.Forms.Button btnViewW;
        private System.Windows.Forms.Button btnViewS;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button btnClose;
    }
}