using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication5
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf=new LoginForm();
            lf.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Faisalabad")
            {
                this.Hide();
                Daewoo.Schedule fs = new Daewoo.Schedule(dateTimePicker1.Text);
                fs.Show();
                
            }
            else if (comboBox2.Text == "Islamabad")
            {
                this.Hide();
                Daewoo.Schedule2 isl = new Daewoo.Schedule2(dateTimePicker1.Text);
                isl.Show();

            }
            else if (comboBox2.Text == "Karachi")
            {
                this.Hide();
                Daewoo.Schedule3 kch = new Daewoo.Schedule3(dateTimePicker1.Text);
                kch.Show();

            }
            else if (comboBox2.Text == "Multan")
            {
                this.Hide();
                Daewoo.Schedule4 mul = new Daewoo.Schedule4(dateTimePicker1.Text);
                mul.Show();
            }
            else if (comboBox2.Text == "Peshawar")
            {
                this.Hide();
                Daewoo.Schedule5 psh = new Daewoo.Schedule5(dateTimePicker1.Text);
                psh.Show();
            }

            else
                MessageBox.Show("Please Select Valid City!");

        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            string f = bunifuMetroTextbox1.Text.ToString() + ".txt";
            if (File.Exists(f))
            {
                StreamReader obj = File.OpenText(f);

                MessageBox.Show("Bus ID:\t " + obj.ReadLine() + "\nName:\t" + obj.ReadLine()
                    + "\nMobile#\t" + obj.ReadLine() + "\nCNIC#\t" + obj.ReadLine() + "\nGender\t" + obj.ReadLine());
                obj.Close();

            }
            else
                MessageBox.Show("No Reord Found!");
            
        }
    }
}
