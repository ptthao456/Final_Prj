using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final_Prj.Models
{
    [Serializable]
    public class StudyTask : TaskEntity, IComparable<StudyTask>
    {

       

       
        public int Id { get; set; }
        public string Subject { get; set; }  //Môn học

        public StudyTask(int userid, int id, string taskName, string description, DateTime dueDate, string status, string priority, string subject)
        : base(userid, taskName, description, dueDate, status, priority)
        {
            // Tăng _currentId lên 1 và gán cho Id của Task mới
            this.Id = id;
            this.Subject = subject;
        }

        public StudyTask() :base()
        {
        }

        //So sánh 2 task theo deadline
        public int CompareTo(StudyTask other)
        {
            if (other == null)
                return 1;
            return this.DueDate.CompareTo(other.DueDate);
        }
        public override string ToString()
        {
            return $"Id: {IdUser}, TaskName: {TaskName}, Description: {Description}, DueDate: {DueDate}, Status: {Status}, Priority: {Priority}, Subject: {Subject}";
        }
    }
}
