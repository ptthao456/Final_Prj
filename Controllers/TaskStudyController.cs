using System;
using System.Collections.Generic;
using Final_Prj.Models;


namespace Final_Prj.Controllers
{
    class TaskStudyController 
    {
        public TaskStudyRepository taskStudyRepository;
        public TaskStudyController() :base()
        {
            taskStudyRepository = new TaskStudyRepository();
        }
        public string AddTask(StudyTask task)
        {
            
            return taskStudyRepository.SaveToExcel(task);
        }

        public  List<StudyTask> GetAllTasks()
        {
            return taskStudyRepository.GetAllTasks();
        }

        public  List<StudyTask> GetTaskById(int id)
        {
            return taskStudyRepository.FindTaskByUserId(id);
        }
       
        

        public bool UpdateTask(StudyTask task)
        {
            return taskStudyRepository.UpdateTask(task);
        }
        public List<StudyTask> SortTask()
        {
            return taskStudyRepository.SortTask();
        }
        public int GetNextId()
        {
            return taskStudyRepository.GetMaxId() +1;
        }
        // xoá task
        public bool DeleteTask(int id)
        {
            
            return taskStudyRepository.DeleteTask(id);
        }
    }
}
