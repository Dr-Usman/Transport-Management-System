using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication5
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if (UserName.Text == "User Name")
            {
                UserName.Text = "";
            }
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if (Password.Text=="Password")
            {
                Password.Text = "";
            }
        }

        private void UserName_Leave(object sender, EventArgs e)
        {
            if (UserName.Text=="")
            {
                UserName.Text = "User Name";
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Password";
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string u = "^[a-zA-Z]{1,10}$";
            string p = "^[a-zA-Z0-9]{1,10}$";
            if (!Regex.IsMatch(UserName.Text, u))
            {
                MessageBox.Show(" Invalid Username! ");
            }
            else
            {
                if (!Regex.IsMatch(Password.Text, p))
                {
                    MessageBox.Show(" Invalid Password! ");
                }
                else
                {
                    if ((UserName.Text == "Admin") && (Password.Text == "admin"))
                    {
                        this.Hide();
                        WelcomeForm wf = new WelcomeForm();
                        wf.Show();
                    }
                    else
                        MessageBox.Show("Please Enter Correct Details!");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
