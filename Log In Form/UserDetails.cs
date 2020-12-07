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
    public partial class UserDetails : Form
    {
        public UserDetails()
        {
            InitializeComponent();
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string firstName= textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string month = comboBoxMonth.Text;
            string day = comboBoxDay.Text;
            string year = comboBoxYear.Text;
            string gender = comboBoxGender.Text;
            string address = textBoxAddress.Text;
            string city = textBoxCity.Text;
            string state = comboBoxState.Text;
            string zip = textBoxZip.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string remail = textBoxReEmail.Text;
            string pass = textBoxPassword.Text;
            string repass = textBoxRePassword.Text;
            string sQues = comboBoxQues.Text;
            string sAns = textBoxAns.Text;

            string output = string.Format("Name: {0}" + " {1}" +"\nDate Of Birth:{2}"+"{3},"+"{4}" + "\nGender: {5}"+"\nAddress: {6}" + "\nCity: {7}"+" State: {8}"
                + "\nZip: {9}"+" Phone: {10}"+"\nEmail: {11}"+"\nPassword: {12}"+"\nSecurity Question: {13}"+"\nAnswer: {14}",
                firstName, lastName, month, day, year, gender,address,city,state,zip,phone,email,pass,sQues,sAns);
            rtOutput.Text = output;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
