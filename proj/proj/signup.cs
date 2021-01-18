using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class signup : Form
    {
        List<Sign_up> accounts;
        public signup()
        {
            InitializeComponent();
        }
        private void addAccount(string fn, string ln, 
            string eml, string p, string cp, string user, Boolean admin)
        {
            Sign_up u;
            admin = false;
            if (admin == true)
            { 
                u = new AdminUser();
            }
            else
            {
                u = new NormalUser();
            }
            u.Fname = fn;
            u.Lname = ln;
            u.Email = eml;
            u.Passwd = p;
            u.Conpass = cp;
            u.Username = user;

            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string fn, ln, eml, p, cp, user;
            Boolean admin;
            admin = false;
            fn = txtFname.Text;
            ln = txtLname.Text;
            eml = txtEmail.Text;
            p = txtPasswd.Text;
            cp = txtConPasswd.Text;
            user = txtUname.Text;
            addAccount(fn, ln, eml, p, cp, user, admin);
        }

        private void signup_Load(object sender, EventArgs e)
        {
            accounts = new List<Sign_up>();
            addAccount("Josee", "chaves", "Osechaves@sol.com", "Jocha15", "Jocha15", "Jchav", true);
            addAccount("Admin", "Admin", "Admin@sol.com", "password", "password", "Admin", true);
        }
    }
}
