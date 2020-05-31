using AvtomatisationFrameworkTests.models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtomatisationFrameworkTests.Service
{
    class UserCreator
    {
        public static String user_name = "nikita.chibrikov.99@gmail.com";
        public static String user_password = "12345678";

        public static User withCredentialsFromProperty()
        {
            return new User(user_name, user_password);
        }

        public static User withEmptyUserName() { return new User(username: "", user_password); }

        public static User withEmptyPassword() { return new User(user_name, password: ""); }
    }
}
