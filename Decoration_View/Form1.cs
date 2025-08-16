using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Final_Prj.Controllers;
using Final_Prj.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_Prj.Decoration_View
{
    public partial class Form1 : Form
    {
        UserController userController;
        TaskWorkController taskWorkController;
        TaskStudyController taskStudyController;
        public Form1()
        {
            InitializeComponent();
            userController = new UserController();
            taskWorkController = new TaskWorkController();
            taskStudyController = new TaskStudyController();
        }


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //btnRegister.Click += new EventHandler(btnRegister_Click);
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            User user = new User(userController.GetNextId(), username, password);
            String result = userController.AddUser(user);
            MessageBox.Show(result);
            Console.WriteLine(userController.AddUser(user));
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            User user = new User(userController.GetNextId(), username, password);
            bool result = userController.Login(user);
            if (result)
            {
                MessageBox.Show("Login success","Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblLogin.Text = "Login success";
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                btnLogout.Visible = true;
                btnLogin.Visible = false;
                btnScreate.Enabled = true;
              
               
                btnWcreate.Enabled = true;
                
              
                btnViewW.Visible = true;
                btnViewS.Visible = true;

            }
            else
            {
                MessageBox.Show("Login failed","Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            btnLogout.Visible = false;
            btnLogin.Visible = true;
            btnViewW.Visible=false;
            btnViewS.Visible=false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnWcreate_Click(object sender, EventArgs e)
        {
            User user = userController.GetUserByUsername(txtUsername.Text);
            String value = trackBar1.Value.ToString();
            WorkTask workTask = new WorkTask(user.Id, taskWorkController.GetNextId(), txtWname.Text,
                txtWDes.Text, Convert.ToDateTime(txtWDue.Text),
                txtWstatus.Text, value, txtWtype.Text);
            String result = taskWorkController.AddTask(workTask);
            MessageBox.Show(result, result, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnScreate_Click(object sender, EventArgs e)
        {
            User user = userController.GetUserByUsername(txtUsername.Text);
            String value = trackBar2.Value.ToString();
            StudyTask studyTask = new StudyTask(user.Id, taskStudyController.GetNextId(), 
                txtSTaskName.Text , txtSDescription.Text, 
                Convert.ToDateTime(txtSDueDate.Text), 
                txtSStatus.Text, value, txtSSubject.Text);
            String result = taskStudyController.AddTask(studyTask);
            MessageBox.Show(result);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnViewW_Click(object sender, EventArgs e)
        {
            Form form = new WorkTask_Form(txtUsername.Text);
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnViewS_Click(object sender, EventArgs e)
        {
            Form form = new StudyTask_Form(txtUsername.Text);
            form.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           
        }
    }
}
