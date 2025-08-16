
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using Final_Prj.Controllers;
using Final_Prj.Models;

namespace Final_Prj.Decoration_View
{
    public partial class WorkTask_Form: Form
    {
        UserController userController;
        TaskWorkController taskWorkController;
        //TaskStudyController taskStudyController;
        string Username;
        public WorkTask_Form(string Username)
        {
            InitializeComponent();
            userController = new UserController();
            taskWorkController = new TaskWorkController();
            //taskStudyController = new TaskStudyController();
            this.Username = Username;
            //dataGridViewWorkTask.CellClick += dataGridViewWorkTask_CellContentClick;
        }

        private void dataGridViewWorkTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            //dataGridViewWorkTask.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridViewWorkTask.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridViewWorkTask.ReadOnly = true;
        }

        private void listView_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {
            User user = userController.GetUserByUsername(Username);

            //dataGridViewWorkTask.DataSource = taskWorkController.GetTaskById(user.Id);
            //dataGridViewWorkTask.DataSource = taskWorkController.GetAllTasks();
            //List<WorkTask> tasks = taskWorkController.GetTaskById(user.Id);
            List<WorkTask> tasks = taskWorkController.GetTaskById(user.Id);
            tasks.Sort();
            //BindingList<int> workList = new BindingList<int>();
            DataTable dataTable = new DataTable("Work Task");
            //public WorkTask(int userid, int id, string taskName, string description, DateTime dueDate, string status, string priority, string taskType): 
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Task Name");
            dataTable.Columns.Add("Description");
            dataTable.Columns.Add("Deadline");
            dataTable.Columns.Add("Status");
            dataTable.Columns.Add("Priority");
            dataTable.Columns.Add("Task Type");

            foreach (WorkTask task in tasks)
            {
                dataTable.Rows.Add(task.Id, task.TaskName, task.Description,
                    task.DueDate, task.Status, task.Priority, task.TaskType);
            }



            dataGridViewWorkTask.DataSource = dataTable;
            // Thêm cột Button Edit vào DataGridView
            DataGridViewButtonColumn btnColumnEdit = new DataGridViewButtonColumn();
            btnColumnEdit.HeaderText = "Edit";
            btnColumnEdit.Text = "Edit";
            btnColumnEdit.UseColumnTextForButtonValue = true; // Hiển thị văn bản trên button
            dataGridViewWorkTask.Columns.Add(btnColumnEdit);
            // Thêm cột "Delete" Button vào DataGridView
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "Delete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            dataGridViewWorkTask.Columns.Add(btnDelete);




            // đăng kí sự kiện
            dataGridViewWorkTask.CellClick += dataGridViewWorkTask_CellClick;
        }

        private void dataGridViewWorkTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            else if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 7)
                {
                    string taskName = dataGridViewWorkTask.Rows[e.RowIndex].Cells["Task Name"].Value.ToString();
                    int ID = Convert.ToInt32(dataGridViewWorkTask.Rows[e.RowIndex].Cells["ID"].Value);
                    string Description = dataGridViewWorkTask.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                    string Deadline = dataGridViewWorkTask.Rows[e.RowIndex].Cells["Deadline"].Value.ToString();
                    string Status = dataGridViewWorkTask.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                    string Priority = dataGridViewWorkTask.Rows[e.RowIndex].Cells["Priority"].Value.ToString();
                    string taskType = dataGridViewWorkTask.Rows[e.RowIndex].Cells["Task Type"].Value.ToString();
                    WorkTask workTask = new WorkTask();
                    workTask.TaskName = taskName;
                    workTask.Id = ID;
                    workTask.Description = Description;
                    workTask.Status = Status;
                    workTask.Priority = Priority;
                    workTask.TaskType = taskType;
                    bool rs = taskWorkController.UpdateTask(workTask);

                    if (rs)
                    {
                        MessageBox.Show("Task has been updated successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (e.ColumnIndex == 8)
                {
                    // Xác nhận xóa hàng
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa công việc này?", "Xác nhận", MessageBoxButtons.YesNo);
                    int id = Convert.ToInt32(dataGridViewWorkTask.Rows[e.RowIndex].Cells["ID"].Value);
                    bool tmp = taskWorkController.DeleteTask(id);
                    if (result == DialogResult.Yes)
                    {
                        // Lấy tên ID công việc khi nhấn nút Delete

                        tmp = taskWorkController.DeleteTask(id);
                        if (tmp)
                            MessageBox.Show("Xoá thành công!");
                        else
                            MessageBox.Show("Xoá không thành công!");
                    }
                }

            }
        }

        

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
