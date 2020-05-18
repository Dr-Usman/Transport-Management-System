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
using System.Text.RegularExpressions;

namespace WindowsFormsApplication5
{
    public partial class Detail_Form : Form
    {
        public Detail_Form(string arv, string dat, string bs, string id,string pr)
        {
            InitializeComponent();
            bunifuCustomLabel8.Text = id;
            bunifuCustomLabel9.Text = arv;
           bunifuCustomLabel10.Text = dat;
            bunifuCustomLabel11.Text = bs;
            bunifuCustomLabel12.Text = pr;

        }

        private void Detail_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            string n = "^[a-zA-Z]{1,10} [a-zA-Z]{1,10}$";
            string m = "^(03)[0-9]{9}$";
            string c = "^[0-9]{5}-[0-9]{7,7}-[0-9]{1,1}$";

            if (!Regex.IsMatch(bunifuMetroTextbox1.Text, n))
            {
                MessageBox.Show("Invalid Name. ");
            }
            else
            {
                if (!Regex.IsMatch(bunifuMetroTextbox2.Text, m))
                {
                    MessageBox.Show("Invalid Mobile No. ");
                }
                else
                {
                    if (!Regex.IsMatch(bunifuMetroTextbox3.Text, c))
                    {
                        MessageBox.Show("Invalid CNIC No. ");
                    }
                    else
                    {
                        if (bunifuDropdown1.selectedIndex==-1)
                        {
                            MessageBox.Show("Invalid Gender. ");
                        }
                        else
                        {
                            printPreviewDialog1.Document = printDocument1;
                            printPreviewDialog1.ShowDialog();
                        }
                    }

                }
            }
        }

        private void bunifuMetroTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!char.IsControl(e.KeyChar)&& !char.IsLetter(e.KeyChar)&&!char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }
            */
        }

        private void bunifuMetroTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
            */
        }

        void bunifuMetroTextbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }
            */
            
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            StreamWriter obj = File.CreateText(bunifuCustomLabel8.Text + ".txt");
            obj.WriteLine(bunifuCustomLabel8.Text);
            obj.WriteLine(bunifuMetroTextbox1.Text);
            obj.WriteLine(bunifuMetroTextbox2.Text);
            obj.WriteLine(bunifuMetroTextbox3.Text);
            obj.WriteLine(bunifuDropdown1.selectedValue);
            obj.Close();
            MessageBox.Show("Seat Resrved Succesfully!");
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp1 = Properties.Resources._500_F_181902188_EOCPwIhw6ehf1R6NIR7vOQG3UK96bbWg__2_;
            Image newimage1 = bmp1;
            e.Graphics.DrawImage(newimage1, 25, 20, newimage1.Width, newimage1.Height);

            Bitmap bmp2 = Properties.Resources._32247302_2072543399695085_5337472471396253696_n_1;
            Image newimage2 = bmp2;
            e.Graphics.DrawImage(newimage2, 500, 20, newimage2.Width, newimage2.Height);


            e.Graphics.DrawString("Date: \t" + DateTime.Now, new Font("Ticket De Caisse", 16, FontStyle.Regular), Brushes.Black, new Point(50, 200));
           // e.Graphics.DrawString("Route: \tLahore To Multan", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(50, 200));
            e.Graphics.DrawString("Departure: \tLahore", new Font("Ticket De Caisse", 18, FontStyle.Bold), Brushes.Black, new Point(50, 250));
            e.Graphics.DrawString("Arival: \t"+bunifuCustomLabel9.Text, new Font("Ticket De Caisse", 18, FontStyle.Bold), Brushes.Black, new Point(500, 250));

          
            e.Graphics.DrawString("Seats: \t" + bunifuCustomLabel8.Text, new Font("Ticket De Caisse", 18, FontStyle.Regular), Brushes.Black, new Point(50, 300));

            e.Graphics.DrawString("Price: \t"+bunifuCustomLabel12.Text, new Font("Ticket De Caisse", 18, FontStyle.Regular), Brushes.Black, new Point(500, 300));
            e.Graphics.DrawString("Name: \t" + bunifuMetroTextbox1.Text, new Font(" Ticket De Caisse", 20, FontStyle.Regular), Brushes.Black, new Point(50, 350));
            //e.Graphics.DrawString("Name: \t" + bunifuMetroTextbox1.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(50, 350));
            e.Graphics.DrawString("Mobile#: " + bunifuMetroTextbox2.Text, new Font("Ticket De Caisse", 20, FontStyle.Regular), Brushes.Black, new Point(500, 350));


            e.Graphics.DrawString("CNIC#: \t" + bunifuMetroTextbox3.Text, new Font("Ticket De Caisse", 20, FontStyle.Regular), Brushes.Black, new Point(50, 400));
            e.Graphics.DrawString("Gender: \t" + bunifuDropdown1.selectedValue, new Font("Ticket De Caisse", 18, FontStyle.Regular), Brushes.Black, new Point(500, 400));

            e.Graphics.DrawString("Note: \tThis Ticket is only Valid for 1 Hour!", new Font("Ticket De Caisse", 14, FontStyle.Regular), Brushes.Black, new Point(50, 450));
           e.Graphics.DrawString(bunifuCustomLabel13.Text, new Font("Ticket De Caisse", 14, FontStyle.Regular), Brushes.Black, new Point(25, 475));

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeatForm sf = new SeatForm(bunifuCustomLabel9.Text,bunifuCustomLabel10.Text, bunifuCustomLabel11.Text, bunifuCustomLabel12.Text);
            sf.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for choosing our Service!");
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
           
            WelcomeForm wf = new WelcomeForm();
            wf.Show();
            this.Hide();
        }
    }
}
