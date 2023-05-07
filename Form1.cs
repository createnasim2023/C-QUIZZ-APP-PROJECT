using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int q1, q2;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                q1 = 0;
                label4.Text = (q1 + q2).ToString();
            }
            if (radioButton2.Checked)
            {
                WrongAnswer wrongwindow = new WrongAnswer();

                wrongwindow.Show();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                q1 = 2;
                label4.Text = (q1 + q2).ToString();
            }

            if (radioButton1.Checked)
            {
                Answer answindow = new Answer();
            
                answindow.Show();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                q1 = 0;
                label4.Text = (q1 + q2).ToString();
            }
            
            if (radioButton3.Checked)
            {
                WrongAnswer wrongwindow = new WrongAnswer();

                wrongwindow.Show();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                q1 = 0;
                label4.Text = (q1 + q2).ToString();
            }
            
            
            if (radioButton4.Checked)
            {
                WrongAnswer wrongwindow = new WrongAnswer();

                wrongwindow.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked == true)
            {
                q2 = 0;
                label4.Text = (q1 + q2).ToString();
            }
            if (radioButton15.Checked)
            {
                WrongAnswer wrongwindow = new WrongAnswer();

                wrongwindow.Show();
            }

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked == true)
            {
                q2 = 0;
                label4.Text = (q1 + q2).ToString();
            }
            if (radioButton13.Checked)
            {
                WrongAnswer wrongwindow = new WrongAnswer();

                wrongwindow.Show();
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                q2 = 2;
                label4.Text = (q1 + q2).ToString();
            }
            if (radioButton12.Checked)
            {
                Answer answindow = new Answer();

                answindow.Show();
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                q2 = 0;
                label4.Text = (q1 + q2).ToString();
            }
            if (radioButton11.Checked)
            {
                WrongAnswer wrongwindow = new WrongAnswer();

                wrongwindow.Show();
            }

        }
    }
}
