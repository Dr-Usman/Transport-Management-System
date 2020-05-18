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
    public partial class Schedule3 : Form
    {
        char radButton;

        public Schedule3(string ar1)
        {
            InitializeComponent();
            label54.Text = ar1;
        }
        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            switch (radButton)
            {
                case 'A':
                    this.Hide();
                    WindowsFormsApplication5.SeatForm sf = new WindowsFormsApplication5.SeatForm(label51.Text, label54.Text, "KA",label28.Text);
                    sf.Show();
                    break;
                case 'B':
                    this.Hide();
                    WindowsFormsApplication5.SeatForm sf1 = new WindowsFormsApplication5.SeatForm(label51.Text, label54.Text, "KB", label28.Text);
                    sf1.Show();
                    break;
                case 'C':
                    this.Hide();
                    WindowsFormsApplication5.SeatForm sf2 = new WindowsFormsApplication5.SeatForm(label51.Text, label54.Text, "KC", label28.Text);
                    sf2.Show();
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
