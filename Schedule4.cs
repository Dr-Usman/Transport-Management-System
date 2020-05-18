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
    public partial class Schedule4 : Form
    {
        char radButton;

        public Schedule4(string ar1)
        {
            InitializeComponent();
            label54.Text = ar1;
        }

        private void Schedule4_Load(object sender, EventArgs e)
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
                    WindowsFormsApplication5.SeatForm sf = new WindowsFormsApplication5.SeatForm(label51.Text, label54.Text, "MA",label29.Text);
                    sf.Show();
                    break;
                case 'B':
                    this.Hide();
                    WindowsFormsApplication5.SeatForm sf1 = new WindowsFormsApplication5.SeatForm(label51.Text, label54.Text, "MB", label29.Text);
                    sf1.Show();
                    break;
                case 'C':
                    this.Hide();
                    WindowsFormsApplication5.SeatForm sf2 = new WindowsFormsApplication5.SeatForm(label51.Text, label54.Text, "MC", label29.Text);
                    sf2.Show();
                    break;
                case 'D':
                    this.Hide();
                    WindowsFormsApplication5.SeatForm sf3 = new WindowsFormsApplication5.SeatForm(label51.Text, label54.Text, "MD", label29.Text);
                    sf3.Show();
                    break;
                case 'E':
                    this.Hide();
                    WindowsFormsApplication5.SeatForm sf4 = new WindowsFormsApplication5.SeatForm(label51.Text, label54.Text, "ME", label29.Text);
                    sf4.Show();
                    break;
                case 'F':
                    this.Hide();
                    WindowsFormsApplication5.SeatForm sf5 = new WindowsFormsApplication5.SeatForm(label51.Text, label54.Text, "MF", label29.Text);
                    sf5.Show();
                    break;
                case 'G':
                    this.Hide();
                    WindowsFormsApplication5.SeatForm sf6 = new WindowsFormsApplication5.SeatForm(label51.Text, label54.Text, "MG", label29.Text);
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
