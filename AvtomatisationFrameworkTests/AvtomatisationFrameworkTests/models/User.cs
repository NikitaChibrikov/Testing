using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtomatisationFrameworkTests.models
{
    class User
    {
        private String username;
        private String password;

        public User (String username, String password)
        {
            this.username = username;
            this.password = password;
        }

        public String getUsername()
        {
            return username;
        }

        public String getPassword()
        {
            return password;
        }

        public void setUsername(String username)
        {
            this.username = username;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public String toString()
        {
            return "User{" + "username='" + username + '\'' +
                ", password='" + password + '\'' + '}';
        }
    }
}
