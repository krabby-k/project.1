using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample1
{
    class Users
    {
        private string fname;
        private string lname;
        private string email;
        private string passwd;
        private string conpass;
        private string username;



        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }
        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string Passwd
        {
            get
            {
                return passwd;
            }
            set
            {
                passwd = value;
            }
        }
        public string Conpass
        {
            get
            {
                return conpass;
            }
            set
            {
                conpass = value;
            }
        }
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public Boolean checkPassword(string pass)
        {
            if (pass.ToLower().Equals(passwd.ToLower()))
            {
                return true;
            }
            return false;
        }
    }
    class NormalUser : Users
    {

    }
    class AdminUser : Users
    {
        private int failedLogins;
        private Boolean locked;
        public int FailedLogins
        {
            get
            {
                return failedLogins;
            }
            set
            {
                failedLogins = value;
            }
        }
        public bool Locked
        {
            get
            {
                return locked;
            }
            set
            {
                locked = value;
            }
        }
    }
}
