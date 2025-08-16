using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office2010.Excel;
using Final_Prj.Controllers;
using Final_Prj.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Final_Prj.Decoration_View
{
    public partial class StudyTask_Form : Form
    {
        string username;
        UserController userController;
        //TaskWorkController taskWorkController;
        TaskStudyController taskStudyController;
        public StudyTask_Form(string username)
        {
            InitializeComponent();
            this.username = username;
            userController = new UserController();
            //taskWorkController = new TaskWorkController();
            taskStudyController = new TaskStudyController();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudyTask_Form_Load(object sender, EventArgs e)
        {
            User user = userController.GetUserByUsername(username);


            List<StudyTask> tasks = taskStudyController.GetTaskById(user.Id);
            tasks.Sort();
            //BindingList<int> workList = new BindingList<int>();
            DataTable dataTable = new DataTable("Study Task");
            //public WorkTask(int userid, int id, string taskName, string description, DateTime dueDate, string status, string priority, string taskType): 
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Task Name");
            dataTable.Columns.Add("Description");
            dataTable.Columns.Add("Deadline");
            dataTable.Columns.Add("Status");
            dataTable.Columns.Add("Priority");
            dataTable.Columns.Add("Subject");


            foreach (StudyTask task in tasks)
            {
                Button btn = new Button();


                dataTable.Rows.Add(task.Id, task.TaskName, task.Description,
                    task.DueDate, task.Status, task.Priority, task.Subject);


                // Đăng ký sự kiện khi bấm vào Button trong DataGridView

            }

            dataGridViewStudyTask.DataSource = dataTable;
            // Thêm cột Button Edit vào DataGridView
            DataGridViewButtonColumn btnColumnEdit = new DataGridViewButtonColumn();
            btnColumnEdit.HeaderText = "Edit";
            btnColumnEdit.Text = "Edit";
            btnColumnEdit.UseColumnTextForButtonValue = true; // Hiển thị văn bản trên button
            dataGridViewStudyTask.Columns.Add(btnColumnEdit);
            // Thêm cột "Delete" Button vào DataGridView
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "Delete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            dataGridViewStudyTask.Columns.Add(btnDelete);




            // đăng kí sự kiện
            dataGridViewStudyTask.CellClick += dataGridViewStudyTask_CellClick;
        }

        private void dataGridViewStudyTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            else if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 7)
                {
                    // Lấy tên công việc khi nhấn nút Edit
                    string taskName = dataGridViewStudyTask.Rows[e.RowIndex].Cells["Task Name"].Value.ToString();
                    int ID = Convert.ToInt32(dataGridViewStudyTask.Rows[e.RowIndex].Cells["ID"].Value);
                    string Description = dataGridViewStudyTask.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                    string Deadline = dataGridViewStudyTask.Rows[e.RowIndex].Cells["Deadline"].Value.ToString();
                    string Status = dataGridViewStudyTask.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                    string Priority = dataGridViewStudyTask.Rows[e.RowIndex].Cells["Priority"].Value.ToString();
                    string Subject = dataGridViewStudyTask.Rows[e.RowIndex].Cells["Subject"].Value.ToString();
                    StudyTask studyTask = new StudyTask();
                    studyTask.TaskName = taskName;
                    studyTask.Id = ID;
                    studyTask.Description = Description;
                    studyTask.Status = Status;
                    studyTask.Priority = Priority;
                    studyTask.Subject = Subject;
                    bool rs = taskStudyController.UpdateTask(studyTask);

                    if (rs)
                    {
                        MessageBox.Show("Task has been updated successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (e.ColumnIndex == 8)
                {
                    // Xác nhận xóa hàng
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa công việc này?", "Xác nhận", MessageBoxButtons.YesNo);
                    int id = Convert.ToInt32(dataGridViewStudyTask.Rows[e.RowIndex].Cells["ID"].Value);
                    bool tmp = taskStudyController.DeleteTask(id);
                    if (result == DialogResult.Yes)
                    {
                        // Lấy tên ID công việc khi nhấn nút Delete

                        tmp = taskStudyController.DeleteTask(id);
                        if (tmp)
                            MessageBox.Show("Xoá thành công!");
                        else
                            MessageBox.Show("Xoá không thành công!");
                    }
                }

            }
        }
    }
}

