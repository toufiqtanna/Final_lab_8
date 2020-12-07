using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_In_Form
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            string errMgs = "";
            bool hasError = false;

            if(textBoxUser.Text.Equals(""))
            {
                errMgs += "Username Required";
                hasError = true;
            }
            else
            {
                username = textBoxUser.Text;
            }
            if(textBoxPassword.Text.Equals(""))
            {
                errMgs += "\nPassword Required";
                hasError = true;
            }
            else
            {
                password = textBoxPassword.Text;
            }
            if (!hasError)
            {
                if (username.Equals("16-32358-2") && password.Equals("Toufiq"))
                {
                    User u = new User();
                    u.username = username;
                    new DashBoard().Show();
                    SetVisibleCore(false);
                }

                else
                {
                    MessageBox.Show("Invalid User or Password");
                }
            }
            else
            {
                MessageBox.Show(errMgs);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
