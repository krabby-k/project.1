using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample1
{
    public partial class Form1 : Form
    {
        List<Users> acc;
        public Form1()
        {
            InitializeComponent();
        }
        private Users findAccount(string user)
        {
            for (int x = 0; x <acc.Count; x++)
            {
                if (acc[x].Username.ToLower() == user.ToLower())
                {
                    return acc[x];
                }
            }
            return null;
        }
        private void addAccount(string fn, string ln,
            string eml, string p, string cp, string user, Boolean admin)
        {
            Users u;
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

            acc.Add(u);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            acc = new List<Users>();
            addAccount("Josee", "chaves", "Osechaves@sol.com", "Jocha15", "Jocha15", "Jchav", true);
            addAccount("Admin", "Admin", "Admin@sol.com", "password", "password", "Admin", true);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Users user;
            string uname = txtUsername.Text;
            string passwd = txtPassword.Text;
            user = findAccount(uname);
            if (user == null)
            {
                MessageBox.Show("Account doesn't seem to exist!");
                return;
            }
            if (user.checkPassword(passwd))
            {
                MessageBox.Show("Access Granted");
            }
            else
            {
                MessageBox.Show("Access Denied!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            acc = new List<Users>();
        }
    }
}
