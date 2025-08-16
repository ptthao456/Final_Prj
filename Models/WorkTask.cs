using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Prj.Models
{
    [Serializable]
    public class WorkTask : TaskEntity , IComparable<WorkTask>
    {
        

      
        public int Id { get;  set; }
        public string TaskType { get; set; }  //Loại công việc
        public WorkTask(int userid, int id, string taskName, string description, DateTime dueDate, string status, string priority, string taskType): 
            base(userid, taskName, description, dueDate, status, priority)
        {
            this.TaskType = taskType;
            this.Id = id;
        }
        public WorkTask() : base()
        {
        }
        //So sánh 2 task theo deadline
        public int CompareTo(WorkTask other)
        {
            if (other == null)
                return 1;
            return this.DueDate.CompareTo(other.DueDate);
        }
        public override string ToString()
        {
            return $"Id: {IdUser}, TaskName: {TaskName}, Description: {Description}, DueDate: {DueDate}, Status: {Status}, Priority: {Priority}, TaskType: {TaskType}";
        }
    }

}
