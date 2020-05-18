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
    public partial class SeatForm : Form
    {
        public SeatForm(string arv,string date,string bs, string pr)
        {
            InitializeComponent();
            label32.Text = arv;
            label33.Text = date;
            label34.Text = bs;
            label35.Text = pr;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (bunifuDropdown1.selectedIndex != -1)
            {
                string f = label34.Text + "-" + bunifuDropdown1.selectedValue + ".txt";
                if (!File.Exists(f))
                {
                    this.Hide();
                    Detail_Form df = new Detail_Form(label32.Text, label33.Text, label34.Text, label34.Text + "-" + bunifuDropdown1.selectedValue, label35.Text);
                    df.Show();
                }
                else
                    MessageBox.Show("Selected Seat is already Reserved! \nPlease Choose another one.");

            }
            else
                MessageBox.Show("Please Select any Seat!");
        }

        private void SeatForm_Load(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomeForm wf = new WelcomeForm();
            wf.Show();

        }
    }
}
