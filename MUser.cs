using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUp.NewFolder1
{
    internal class MUser
    {
       
            public MUser(string name, string password, string role)
            {
                Username = name;
                Password = password;
                Role = role;
            }
            public MUser()
            {

            }
            public string Username;
            public string Password;
            public string Role;
        
    }
}
