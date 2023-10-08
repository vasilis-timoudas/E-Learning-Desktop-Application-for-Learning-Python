using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning
{
    class Student
    {
        private String fullname;
        private String am;

        // Αυτά τα 2 για login
        private String email;
        private String password;

        public Student(String fullname, String am, String email, String password)
        {
            this.fullname = fullname;
            this.am = am;
            this.email = email;
            this.password = password;
        }
        public String getFullName()
        {
            return fullname;
        }

        public String getAm()
        {
            return am;
        }

        public String getEmail()
        {
            return email;
        }

        public String getPassword()
        {
            return password;
        }

    }
}
