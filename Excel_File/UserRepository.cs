using ClosedXML.Excel;
using Final_Prj.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


public class UserRepository
{
    private const string ExcelFilePath = "Users.xlsx";
    private const string WorksheetName = "Users";

    // Serialize danh sách User thành JSON byte array
    private static byte[] SerializeListUsers(List<User> users)
    {
        return JsonSerializer.SerializeToUtf8Bytes(users);
    }

    // Serialize một User thành JSON byte array
    private static byte[] SerializeUser(User user)
    {
        List<User> tempList = new List<User> { user };
        return JsonSerializer.SerializeToUtf8Bytes(tempList);
    }

    // Deserialize JSON byte array thành danh sách User
    private static List<User> DeserializeUsers(byte[] data)
    {
        if (data == null || data.Length == 0)
        {
            return new List<User>(); // Trả về danh sách rỗng nếu dữ liệu đầu vào không hợp lệ
        }

        List<User> tasks = JsonSerializer.Deserialize<List<User>>(data);

        if (tasks == null)
        {
            return new List<User>(); // Trả về danh sách rỗng nếu quá trình giải tuần tự hóa thất bại
        }

        return tasks;
    }

    // Ghi danh sách User vào Excel (Thêm mới, không ghi đè)
    public String SaveToExcel(List<User> user)
    {
        if (user == null || user.Count == 0)
        {
            return "Not found";
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

            byte[] serializedData = SerializeListUsers(user);
            worksheet.Cell(lastRow + 1, 1).Value = Convert.ToBase64String(serializedData);
            workbook.SaveAs(ExcelFilePath);
            return "Save success";
        }
        catch (Exception ex)
        {
            throw new IOException($"Lỗi khi lưu danh sách task dùng vào Excel: {ex.Message}", ex);
        }
    }


    // Ghi một User vào Excel
    public String SaveToExcel(User newUser)
    {
        if (newUser == null) throw new ArgumentNullException(nameof(newUser));
        List<User> tempList = GetAllUsers();
        foreach (User user in tempList)
        {
            if (user.Username == newUser.Username)
            {
               return "Username already exists";
            }
        }
        XLWorkbook workbook = LoadOrCreateWorkbook();
        var worksheet = GetOrCreateWorksheet(workbook);

        try
        {
            int lastRow = worksheet.LastRowUsed()?.RowNumber() ?? 0;
            byte[] serializedData = SerializeUser(newUser);
            worksheet.Cell(lastRow + 1, 1).Value = Convert.ToBase64String(serializedData);
            workbook.SaveAs(ExcelFilePath);
            return "Save success";
        }
        catch (Exception ex)
        {
            throw new IOException($"Lỗi khi lưu người dùng vào Excel: {ex.Message}", ex);
        }
    }
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
    // Đọc danh sách User từ Excel
    public List<User> GetAllUsers()
    {
        if (!File.Exists(ExcelFilePath)) return new List<User>();

        XLWorkbook workbook = null;
        try
        {
            workbook = new XLWorkbook(ExcelFilePath);
            IXLWorksheet worksheet = workbook.Worksheet("Users");
            List<User> allUsers = new List<User>();

            foreach (IXLRow row in worksheet.RowsUsed())
            {
                //if (row.RowNumber() == 1) continue; // Bỏ qua dòng tiêu đề
                string base64Data = row.Cell(1).GetString();
                if (base64Data != "")
                {
                    byte[] serializedData = Convert.FromBase64String(base64Data);
                    List<User> deserializedUsers = DeserializeUsers(serializedData);
                    for (int i = 0; i < deserializedUsers.Count; i++)
                        allUsers.Add(deserializedUsers[i]);
                }
            }
            return allUsers;
        }
        finally
        {
            if (workbook != null) workbook.Dispose();  //đóng file
        }
    }

    // Xóa một User theo Id
    public String DeleteUser(int id)
    {
        List<User> users = GetAllUsers();
        List<User> newList = new List<User>();

        // Duyệt qua danh sách users và thêm các user không có ID khớp vào newList
        for (int i = 0; i < users.Count; i++)
        {
            if (users[i].Id != id)
            {
                newList.Add(users[i]);
            }
        }

        // Ghi lại danh sách đã lọc vào Excel
        if( RewriteExcel(newList))
                return "Delete success";
        else
            return "Delete fail";
    }

    // Cập nhật User
    public String UpdateUser(User updatedUser)
    {
        // Kiểm tra nếu updatedUser là null
        if (updatedUser == null)
        {
            throw new ArgumentNullException(nameof(updatedUser));
        }

        // Lấy danh sách tất cả người dùng
        List<User> users = GetAllUsers();

        // Tìm chỉ số của user trong danh sách dựa trên ID
        int index = -1;
        for (int i = 0; i < users.Count; i++)
        {
            if (users[i].Id == updatedUser.Id)
            {
                index = i;
                break; // Thoát vòng lặp khi tìm thấy chỉ số đầu tiên
            }
        }

        // Kiểm tra nếu không tìm thấy user
        if (index == -1)
        {
            throw new KeyNotFoundException($"Không tìm thấy người dùng với ID: {updatedUser.Id}");
        }

        // Cập nhật user tại chỉ số tìm được
        users[index] = updatedUser;

        // Ghi lại danh sách đã cập nhật vào Excel
        if( RewriteExcel(users))
            return "Update success";
        else
            return "Update fail";

    }

    // Tìm User theo Id
    public User FindUserById(int id)
    {
        List<User> users = GetAllUsers();

        User temp = null;
        foreach (User user in users)
        {
            if (user.Id == id)
            {
                temp = user;
                break;
            }
        }

        if (temp == null)
        {
            //throw new KeyNotFoundException($"Không tìm thấy người dùng với ID: {id}");
            return null;
        }
        return temp;
    }

    // Tìm User theo Username
    public User FindUserByUsername(string username)
    {
        if (string.IsNullOrEmpty(username))
        {
            throw new ArgumentException("Username không được để trống.", nameof(username));
        }

        var users = GetAllUsers();

        User foundUser = null;
        foreach (var user in users)
        {
            if (user.Username == username)
            {
                foundUser = user;
                break;
            }
        }

        if (foundUser == null)
        {
            throw new KeyNotFoundException($"Không tìm thấy người dùng với username: {username}");
        }

        return foundUser;
    }



    // Helper: Load hoặc tạo mới workbook
    private IXLWorksheet GetOrCreateWorksheet(XLWorkbook workbook)
    {
        IXLWorksheet foundWorksheet = null;

        foreach (var ws in workbook.Worksheets)
        {
            if (ws.Name == WorksheetName)
            {
                foundWorksheet = ws;
                break;
            }
        }

        if (foundWorksheet == null)
        {
            foundWorksheet = workbook.Worksheets.Add(WorksheetName);
        }

        return foundWorksheet;
    }

    // Helper: Ghi lại toàn bộ dữ liệu vào Excel
    private bool RewriteExcel(List<User> users)
    {
        bool result = false;
        XLWorkbook workbook = new XLWorkbook();
        IXLWorksheet worksheet = workbook.Worksheets.Add(WorksheetName);

        try
        {
            if (users.Count > 0)
            {
                byte[] serializedData = SerializeListUsers(users);
                worksheet.Cell(1, 1).Value = Convert.ToBase64String(serializedData);
            }
            workbook.SaveAs(ExcelFilePath);
            return true;
        }
        catch (Exception ex)
        {
            return false;
            throw new IOException($"Lỗi khi ghi lại dữ liệu vào Excel: {ex.Message}", ex);
        }
    }

    public bool Login(User user)
    {
 
        List<User> users = GetAllUsers();
        foreach (User u in users)
        {
            if (u.Username == user.Username && u.Password == user.Password)
            {
                return true;
            }
        }
        return false;

    }

    public User GetUserById(int id)
    {
        List<User> users = GetAllUsers();
        foreach (User u in users)
        {
            if (u.Id == id)
            {
                return u;
            }
        }
        return new User();
    }
    public int GetMaxId()
    {
        List<User> users = GetAllUsers();
        int maxId = 0;
        foreach (User u in users)
        {
            if (u.Id > maxId)
            {
                maxId = u.Id;
            }
        }
        return maxId;
    }

    public User GetUserByUsername(string username)
    {
        List<User> users = GetAllUsers();
        foreach (User u in users)
        {
            if (u.Username == username)
            {
                return u;
            }
        }
        return new User();
    }
}




