using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_app_demo
{
    public partial class Form1 : Form
    {
        double first, second, ans;
        string op = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = " ";
            op = "+";

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            {
                if (richTextBox1.Text == "7" && richTextBox1.Text != null)
                {
                    richTextBox1.Text = "7";
                }
                else
                {
                    richTextBox1.Text += "7";
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            {
                if (richTextBox1.Text == "3" && richTextBox1.Text != null)
                {
                    richTextBox1.Text = "3";
                }
                else
                {
                    richTextBox1.Text += "3";
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            {
                if (richTextBox1.Text == "8" && richTextBox1.Text != null)
                {
                    richTextBox1.Text = "8";
                }
                else
                {
                    richTextBox1.Text += "8";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "." && richTextBox1.Text != null)
            {
                richTextBox1.Text = ".";
            }
            else
            {
                richTextBox1.Text += ".";
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text ="0";
            }
            else
            {
                richTextBox1.Text += "0";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            {
                if (richTextBox1.Text == "2" && richTextBox1.Text != null)
                {
                    richTextBox1.Text = "2";
                }
                else
                {
                    richTextBox1.Text += "2";
                }
            }
        }

        private void onee_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(richTextBox1.Text);
            if (op=="+")
            {
                ans = first + second;
                richTextBox1.Text = ans.ToString();
            }

            if (op == "-")
            {
                ans = first - second;
                richTextBox1.Text = ans.ToString();
            }

            if (op == "*")
            {
                ans = first * second;
                richTextBox1.Text = ans.ToString();
            }

            if(op == "%")
            {
                ans = first / 100;
                richTextBox1.Text = ans.ToString();
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            {
                if (richTextBox1.Text == "9" && richTextBox1.Text != null)
                {
                    richTextBox1.Text = "9";
                }
                else
                {
                    richTextBox1.Text += "9";
                }
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            {
                if (richTextBox1.Text == "4" && richTextBox1.Text != null)
                {
                    richTextBox1.Text = "4";
                }
                else
                {
                    richTextBox1.Text += "4";
                }
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            {
                if (richTextBox1.Text == "5" && richTextBox1.Text != null)
                {
                    richTextBox1.Text = "5";
                }
                else
                {
                    richTextBox1.Text += "5";
                }
            }
        }

        private void off_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            first = 0;
            second = 0;
            ans = 0;
        }

        private void percantage_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = " ";
            op = "%";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = " ";
            op = "*";
        }

        private void substraction_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = " ";
            op = "-";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (richTextBox1.Text == "6" && richTextBox1.Text != null)
                {
                    richTextBox1.Text = "6";
                }
                else
                {
                    richTextBox1.Text += "6";
                }
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            {
                if (richTextBox1. Text == "1" && richTextBox1.Text != null)
                {
                    richTextBox1.Text = "1";
                }
                else
                {
                    richTextBox1.Text += "1";
                }
            }
        }
    }
}
