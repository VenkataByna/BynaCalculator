﻿using System;
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
        float num, ans;
        int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
                textBox1.Text = textBox1.Text + text[i];
        }

        public void compute()
        {
            switch (count)
            {
                case 1:
                    ans = num + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                default:
                    break;
            }
                

        }

        public void display()
        {
            textBox1.Enabled = false;
            button20.Hide();
            button10.Show();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
        }

        public void enable()
        {
            textBox1.Enabled = true;
            button20.Show();
            button10.Hide();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Dot in Numbers 
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text = textBox1.Text + ".";
                textBox1.ForeColor = Color.Black;
                textBox1.TextAlign = HorizontalAlignment.Right;
            }
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Textbox Number + 9
            textBox1.Text = textBox1.Text + 9;
            textBox1.ForeColor = Color.Black;
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Number 8
            textBox1.Text = textBox1.Text + 8;
            textBox1.ForeColor = Color.Black;
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Number 7
            textBox1.Text = textBox1.Text + 7;
            textBox1.ForeColor = Color.Black;
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Number 5
            textBox1.Text = textBox1.Text + 5;
            textBox1.ForeColor = Color.Black;
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Number 6
            textBox1.Text = textBox1.Text + 6;
            textBox1.ForeColor = Color.Black;
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Number 4
            textBox1.Text = textBox1.Text + 4;
            textBox1.ForeColor = Color.Black;
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Number 1
            textBox1.Text = textBox1.Text + 1;
            textBox1.ForeColor = Color.Black;
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Number 2
            textBox1.Text = textBox1.Text + 2;
            textBox1.ForeColor = Color.Black;
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Number 3
            textBox1.Text = textBox1.Text + 3;
            textBox1.ForeColor = Color.Black;
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Number 0
            textBox1.Text = textBox1.Text + 0;
            textBox1.ForeColor = Color.Black;
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            display();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            enable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
            label1.Text = num.ToString() + "-";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            compute();
            label1.Text = "";
        }
    }
}
