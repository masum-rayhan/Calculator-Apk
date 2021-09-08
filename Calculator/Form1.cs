using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int cnt = 0;
        string s,m;
        char x;
        double result=0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.SteelBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AddButton.BackColor = Color.Silver;
            s += "1";
            textBox1.Text= s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s += "2";
            textBox1.Text = s;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s += "3";
            textBox1.Text = s;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            s += "4";
            textBox1.Text = s;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            s += "5";
            textBox1.Text = s;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            s += "6";
            textBox1.Text = s;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            s += "7";
            textBox1.Text = s;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            s += "8";
            textBox1.Text = s;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            s += "9";
            textBox1.Text = s;
        }


        private void button10_Click(object sender, EventArgs e)
        {
            s += ".";
            textBox1.Text = s;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            s += "0";
            textBox1.Text = s;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text =m+" "+x+ " " + textBox1.Text + " =";
            double b = Double.Parse(textBox1.Text);
            switch (x)
            {
                case '+':
                    result += b;
                    break;
                case '-':
                    result -= b;
                    break;
                case '*':
                    result *= b;
                    break;
                case '/':
                    result /= b;
                    break;
            }
            textBox1.Text =result+"";
            result = 0;
            //s = "";
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
                x = '+';
                label1.Text = s + " +";
                Double a = Double.Parse(textBox1.Text);
                result = a;
                textBox1.Text = "";
                m = s;
                s = "";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            x = '-';
            label1.Text = s + " -";
            Double a = Double.Parse(textBox1.Text);
            result = a;
            textBox1.Text = "";
            m = s;
            s = "";
        }


        private void button15_Click(object sender, EventArgs e)
        {
            x = '*';
            label1.Text = s + " *";
            Double a = Double.Parse(textBox1.Text);
            result = a;
            textBox1.Text = "";
            m = s;
            s = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            m = "";
            textBox1.Text = "";
            s = "";
            label1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            x = '/';
            label1.Text = s + " /";
            Double a = Double.Parse(textBox1.Text);
            result = a;
            textBox1.Text = "";
            m = s;
            s = "";

        }
    }
}
