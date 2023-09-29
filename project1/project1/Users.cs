using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    //Пока что используется как класс для передачи информации с формы 2, на форму 1
    public class Users
    {
        string user = "";
        public string get_user()
        {
            return user;
        }
        public void set_user(string u)
        {
            user = u;
        }
    }
}
