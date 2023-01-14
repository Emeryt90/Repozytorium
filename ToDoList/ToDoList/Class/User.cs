using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Class
{
    public class User
    {
        public Guid Id;

        public string Name;

        public string Login;

        public string Password;

        public User(Guid id, string name, string login, string password)
        {
            Id = id;
            Name = name;
            Login = login;
            Password = password;
        }
    }
}
