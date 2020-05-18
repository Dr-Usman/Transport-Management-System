using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daewoo
{
    public partial class Schedule5 : Form
    {
        char radButton;

        public Schedule5(string ar1)
        {
            InitializeComponent();
            label54.Text = ar1;
        }

        private void Schedule5_Load(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            radButton = 'A';
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radButton = 'B';
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radButton = 'C';
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radButton = 'D';
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radButton = 'E';
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radButton = 'F';
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            radButton = 'G';
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            switch (radButton)
            {
                case 'A':
                    this.Hide();
                    WindowsFormsApplication5.SeatForm sf = new WindowsFormsApplication5.SeatForm(label51.Text, label54.Text, "PA",label25.Text);
                    sf.Show();
                    break;
                case 'B':
                    this.Hide();
                    WindowsFormsApplication5.SeatForm sf1 = new WindowsFormsApplication5.SeatForm(label51.Text, label54.Text, "PB", label25.Text);
                    sf1.Show();
                    break;
                case 'C':
                    this.Hide();
                    WindowsFormsApplication5.SeatForm sf2 = new WindowsFormsApplication5.SeatForm(label51.Text, label54.Text, "PC", label25.Text);
                    sf2.Show();
                    break;
                case 'D':
                    this.Hide();
                    WindowsFormsApplication5.SeatForm sf3 = new WindowsFormsApplication5.SeatForm(label51.Text, label54.Text, "PD", label25.Text);
                    sf3.Show();
                    break;
                case 'E':
                    this.Hide();
                    WindowsFormsApplication5.SeatForm sf4 = new WindowsFormsApplication5.SeatForm(label51.Text, label54.Text, "PE", label25.Text);
                    sf4.Show();
                    break;
                case 'F':
                    this.Hide();
                    WindowsFormsApplication5.SeatForm sf5 = new WindowsFormsApplication5.SeatForm(label51.Text, label54.Text, "PF", label25.Text);
                    sf5.Show();
                    break;
                case 'G':
                    this.Hide();
                    WindowsFormsApplication5.SeatForm sf6 = new WindowsFormsApplication5.SeatForm(label51.Text, label54.Text, "PG", label25.Text);
                    sf6.Show();
                    break;

            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            WindowsFormsApplication5.WelcomeForm wf = new WindowsFormsApplication5.WelcomeForm();
            wf.Show();
        }
    }
}
