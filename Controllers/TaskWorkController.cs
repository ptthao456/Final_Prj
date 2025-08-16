using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Bibliography;
using Final_Prj.Models;


namespace Final_Prj.Controllers
{
    class TaskWorkController
    {
        public TaskWorkRepository taskWorkRepository;

        public TaskWorkController()
        {
            taskWorkRepository = new TaskWorkRepository();
        }

        public string AddTask(WorkTask task)
        {

            return taskWorkRepository.SaveToExcel(task);
        }

        public List<WorkTask> GetAllTasks()
        {
            return taskWorkRepository.GetAllTasks();
        }

        public List<WorkTask> GetTaskById(int id)
        {
            return taskWorkRepository.FindTaskByUserId(id);
        }

        public bool DeleteTask(int id)
        {
            return taskWorkRepository.DeleteTask(id);
        }
        public List<WorkTask> SortTask()
        {
            return taskWorkRepository.SortTask();
        }
        public int GetNextId()
        {
            return taskWorkRepository.GetMaxId() +1;
        }
        public bool UpdateTask(WorkTask task)
        {
            return taskWorkRepository.UpdateTask(task);
        }
    }
}
