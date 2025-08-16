using System;

using Final_Prj.Models;


namespace Final_Prj.Controllers
{
    class UserController
    {
        public UserRepository userRepository;
        public UserController()
        {
            userRepository = new UserRepository();
        }
        public String AddUser(User user)
        {
            return userRepository.SaveToExcel(user);
        }
        public String UpdateUser(User user)
        {
            return userRepository.UpdateUser(user);
        }
        public String DeleteUser(int id)
        {
            return userRepository.DeleteUser(id);
        }
        public bool Login(User user)
        {
            return userRepository.Login(user);
        }
        public User GetUserById(int id)
        {
            return userRepository.GetUserById(id);
        }
        public User GetUserByUsername(string username)
        {
            return userRepository.GetUserByUsername(username);
        }
        public int GetNextId()
        {
            return userRepository.GetMaxId() +1;
        }
    }
}
