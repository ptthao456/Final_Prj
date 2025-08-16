using System;

using System.Drawing;

using System.Windows.Forms;
using Final_Prj.Controllers;
using Final_Prj.Decoration_View;
using Final_Prj.Models;



namespace Final_Prj
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////// Ok
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            ///////////////////////////////////////////////
            //UserController userControl = new UserController();
            
            //User user = new User(userControl.GetNextId(),"admin", "admin");
            //User user1 = new User(userControl.GetNextId(),"admin1", "admin1");
            
            //userControl.AddUser(user);
            //userControl.AddUser(user1);
            //Console.WriteLine("-----");
            //Console.WriteLine(userControl.GetNextId());
            ////Console.WriteLine(userControl.GetUserById(1).ToString());
            
        }
    }
}
