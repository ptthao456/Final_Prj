using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Prj.Models
{
    [Serializable]
    public class User
    {
        
        public int Id { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public User( int Id , string username, string password)
        {

            this.Id = Id;
            Username = username;
            Password = password;
            

        }
        public User()
        {
        }
       

        public override string ToString()
        {
            return $"IdUser: {Id}, Username: {Username}, Password: {Password}";
        }

    }

}
