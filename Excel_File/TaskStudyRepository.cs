using ClosedXML.Excel;
using Final_Prj.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

public class TaskStudyRepository
{

    protected const string ExcelFilePath = "Study_TaskRepo.xlsx";

    private const string WorksheetName = "Task";

    // Serialize danh sách StudyTask thành JSON byte array
    private static byte[] SerializeListTasks(List<StudyTask> StudyTasks)
    {
        return JsonSerializer.SerializeToUtf8Bytes(StudyTasks);
    }

    // Serialize một StudyTasks thành JSON byte array
    private static byte[] SerializeTask(StudyTask StudyTask)
    {
        List<StudyTask> tempList = new List<StudyTask> { StudyTask };
        return JsonSerializer.SerializeToUtf8Bytes(tempList);
    }

    // Deserialize JSON byte array thành danh sách Task
    private static List<StudyTask> DeserializeTasks(byte[] data)
    {
        if (data == null || data.Length == 0)
        {
            return new List<StudyTask>(); // Trả về danh sách rỗng nếu dữ liệu đầu vào không hợp lệ
        }

        List<StudyTask> tasks = JsonSerializer.Deserialize<List<StudyTask>>(data);

        if (tasks == null)
        {
            return new List<StudyTask>(); // Trả về danh sách rỗng nếu quá trình giải tuần tự hóa thất bại
        }

        return tasks;
    }

    // Ghi danh sách Task vào Excel (Thêm mới, không ghi đè)
    public string SaveToExcel(List<StudyTask> newTasks)
    {
        if (newTasks == null || newTasks.Count == 0)
        {
            return "Not Find";
        }

        XLWorkbook workbook = LoadOrCreateWorkbook();
        IXLWorksheet worksheet = GetOrCreateWorksheet(workbook);

        try
        {
            int lastRow = 0;
            IXLRow lastRowUsed = worksheet.LastRowUsed();
            if (lastRowUsed != null)
            {
                lastRow = lastRowUsed.RowNumber();
            }

            byte[] serializedData = SerializeListTasks(newTasks);
            worksheet.Cell(lastRow + 1, 1).Value = Convert.ToBase64String(serializedData);
            workbook.SaveAs(ExcelFilePath);
            return "Save success";
        }
        catch (Exception ex)
        {
            throw new IOException($"Lỗi khi lưu danh sách task dùng vào Excel: {ex.Message}", ex);
        }
    }

    // Ghi một Task vào Excel
    public string SaveToExcel(StudyTask newTask)
    {
        if (newTask == null)
        {
            throw new ArgumentNullException(nameof(newTask));
        }

        XLWorkbook workbook = LoadOrCreateWorkbook();
        IXLWorksheet worksheet = GetOrCreateWorksheet(workbook);

        try
        {
            int lastRow = 0;
            IXLRow lastRowUsed = worksheet.LastRowUsed();
            if (lastRowUsed != null)
            {
                lastRow = lastRowUsed.RowNumber();
            }

            byte[] serializedData = SerializeTask(newTask);
            worksheet.Cell(lastRow + 1, 1).Value = Convert.ToBase64String(serializedData);
            workbook.SaveAs(ExcelFilePath);
            return "Save success";
        }
        catch (Exception ex)
        {
            throw new IOException($"Lỗi khi lưu người dùng vào Excel: {ex.Message}", ex);
        }
    }

    // Đọc danh sách Task từ Excel
    public List<StudyTask> GetAllTasks()
    {
        if (!File.Exists(ExcelFilePath)) return new List<StudyTask>();

        XLWorkbook workbook = null;
        try
        {
            workbook = new XLWorkbook(ExcelFilePath);
            IXLWorksheet worksheet = workbook.Worksheet("Task");
            List<StudyTask> allTasks = new List<StudyTask>();

            foreach (IXLRow row in worksheet.RowsUsed())
            {
                //if (row.RowNumber() == 1) continue; // Bỏ qua dòng tiêu đề
                string base64Data = row.Cell(1).GetString();
                if (base64Data != "")
                {
                    byte[] serializedData = Convert.FromBase64String(base64Data);
                    List<StudyTask> deserializedTasks = DeserializeTasks(serializedData);
                    for (int i = 0; i < deserializedTasks.Count; i++)
                        allTasks.Add(deserializedTasks[i]);
                }
            }
            return allTasks;
        }
        finally
        {
            if (workbook != null) workbook.Dispose();  //đóng file
        }
    }

    // Xóa một Task theo Id
    public bool DeleteTask(int id)
    {
        
        bool result = false;
        List<StudyTask> tasks = GetAllTasks();
        List<StudyTask> newList = new List<StudyTask>();
        foreach (StudyTask task in tasks)
        {
            if (task.Id != id)
            {
                newList.Add(task);
            }
            else
            {
                result = true;// nghĩa là có 1 task trùng id cần xoá
            }
        }

        // Ghi lại danh sách đã lọc vào Excel
        RewriteExcel(newList);
        return result;
    }

    // Cập nhật Task
    public bool UpdateTask(StudyTask updateTask)
    {
        // Kiểm tra nếu updateTask là null
        if (updateTask == null)
        {
            return false;
        }
        else
        {
            StudyTask task = FindTaskById(updateTask.Id);
            DeleteTask(updateTask.Id);
            updateTask.IdUser = task.IdUser; 
            SaveToExcel(updateTask);
        }
        return true;
 
    }

    // Tìm task theo Id
    public List<StudyTask> FindTaskByUserId(int id)
    {
        List<StudyTask> tasks = GetAllTasks();

        List<StudyTask> temp = new List<StudyTask>();
        foreach (StudyTask task in tasks)
        {
            if (task.IdUser == id)
            {
                temp.Add(task);
            }
        }
        if(temp.Count > 0)
            return temp;
        else
            return new List<StudyTask>();
    }
    public StudyTask FindTaskById(int id)
    {
        List<StudyTask> tasks = GetAllTasks();

        List<StudyTask> temp = new List<StudyTask>();
        foreach (StudyTask task in tasks)
        {
            if (task.Id == id)
            {
               return task;
            }
        }
        return new StudyTask();
            
    }

    // Tìm Task theo TaskName
    public StudyTask FindTaskByTaskname(string taskname)
    {
        if (string.IsNullOrEmpty(taskname))
        {
            throw new ArgumentException("Taskname không được để trống.", nameof(taskname));
        }

        // Lấy danh sách tất cả các StudyTask
        List<StudyTask> tasks = GetAllTasks();

        // Duyệt qua từng task trong danh sách
        foreach (StudyTask task in tasks)
        {
            // So sánh TaskName của task với taskname được truyền vào
            if (task.TaskName == taskname)
            {
                return task; // Trả về task nếu tìm thấy
            }
        }

        // Nếu không tìm thấy task nào khớp, ném ngoại lệ
        throw new KeyNotFoundException($"Không tìm thấy người dùng với taskname: {taskname}");
    }

  
    
    //  Load hoặc tạo mới workbook
    private XLWorkbook LoadOrCreateWorkbook()
    {
        // Kiểm tra xem tệp Excel có tồn tại hay không
        if (File.Exists(ExcelFilePath))
        {
            // Nếu tệp tồn tại, tải workbook từ đường dẫn ExcelFilePath
            return new XLWorkbook(ExcelFilePath);
        }
        else
        {
            // Nếu tệp không tồn tại, tạo một workbook mới
            return new XLWorkbook();
        }

    }

    // Lấy hoặc tạo worksheet
    private IXLWorksheet GetOrCreateWorksheet(XLWorkbook workbook)
    {
        {
            // Duyệt qua tất cả các worksheet trong workbook
            foreach (IXLWorksheet ws in workbook.Worksheets)
            {
                // Kiểm tra xem tên của worksheet có khớp với WorksheetName không
                if (ws.Name == WorksheetName)
                {
                    // Nếu tìm thấy, trả về worksheet đó
                    return ws;
                }
            }

            // Nếu không tìm thấy worksheet nào có tên WorksheetName, tạo mới một worksheet
            return workbook.Worksheets.Add(WorksheetName);
        }
    }

    //  Ghi đè lại toàn bộ dữ liệu vào Excel
    private bool RewriteExcel(List<StudyTask> tasks)
    {
        XLWorkbook workbook = new XLWorkbook(ExcelFilePath);
        IXLWorksheet xLWorksheet = GetOrCreateWorksheet(workbook);
        xLWorksheet.Clear();
        workbook.Save();

        try
        {
    
            SaveToExcel(tasks);
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return false;
        }
        
    }

    internal List<StudyTask> SortTask()
    {
        List<StudyTask> tasks = GetAllTasks();
        tasks.Sort();
        return tasks;
    }
    public int GetMaxId()
    {
        List<StudyTask> tasks = GetAllTasks();
        int maxId = 0;
        foreach (StudyTask task in tasks)
        {
            if (task.Id > maxId)
            {
                maxId = task.Id;
            }
        }
        return maxId;
    }
    

}