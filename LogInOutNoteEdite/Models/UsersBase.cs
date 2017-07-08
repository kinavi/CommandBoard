using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogInOutNoteEdite.Models
{
    public class UsersBase
    {
        private User[] listUser = 
        {
            new User("Admin","Admin"),
            new User("test","hot"),
        };

        public string CurName { get; set; }
        public string CurPassword { get; set; }

        public bool CheckForm()
        {
            foreach(User u in listUser)
            {
                if (CurName == u.Login && CurPassword == u.password)
                {
                    CurName = u.Login;
                    return true;
                }
            }
            return false;
        }
    }

    public class User
    {
        public string Login { get; set; }
        public string password { get; set; }
        public User(string log, string pas)
        {
            Login = log;
            password = pas;
        }
    }
}