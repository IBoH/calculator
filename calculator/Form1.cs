﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double one = 0;
        double ravno = 0;
        int s = 0;

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            one = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            s = 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch(s)
            {
                case 1:
                    {
                        ravno = one + Convert.ToDouble(textBox1.Text);
                        textBox1.Text = ravno.ToString();
                    }break;
                case 2:
                    {
                        ravno = one - Convert.ToDouble(textBox1.Text);
                        textBox1.Text = ravno.ToString();
                    } break;
            }
             
        }

        private void button14_Click(object sender, EventArgs e)
        {
            one = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            s = 2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
