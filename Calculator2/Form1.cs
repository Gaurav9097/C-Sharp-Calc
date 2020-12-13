using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBox1.Text = "";
        }

        //string pandingOperation = "=";
        //double op1, op2;
        string num1,num2,oprators,res;
        bool k = false;

        public void oprandsListner(string oprands)
        {
            TextBox1.Text += oprands;
        }

        public void opratorListner(string oprator)
        {
            oprators = oprator;
            label.Text += TextBox1.Text;
            TextBox1.Text = "";

        }

        private void Button0_Click(object sender, EventArgs e)
        {
            oprandsListner("0");
            /*if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/" || k == true)
            {
                TextBox1.Text = "";
                k = false;
            }
            TextBox1.Text += "0";*/
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            oprandsListner("1");
            /*if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/" || k == true)
            {
                TextBox1.Text="";
                k = false;
            }
            TextBox1.Text += "1";*/
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            oprandsListner("2");
            /* if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/" || k == true)
             {
                 TextBox1.Text = "";
                 k = false;
             }
             TextBox1.Text += "2";*/
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            oprandsListner("3");
            /*if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/" || k == true)
            {
                TextBox1.Text = "";
                k = false;
            }
            TextBox1.Text += "3";*/
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            oprandsListner("4");
            /*if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/" || k == true)
            {
                TextBox1.Text = "";
                k = false;
            }
            TextBox1.Text += "4";*/
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            oprandsListner("5");
            /*if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/" || k == true)
            {
                TextBox1.Text = "";
                k = false;
            }
            TextBox1.Text += "5";*/
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            oprandsListner("6");
            /*if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/" || k == true)
            {
                TextBox1.Text = "";
                k = false;
            }
            TextBox1.Text += "6";*/
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            oprandsListner("7");
            /*if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/" || k == true)
            {
                TextBox1.Text = "";
                k = false;
            }
            TextBox1.Text += "7";*/
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            oprandsListner("8");
            /*if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/" || k == true)
            {
                TextBox1.Text = "";
                k = false;
            }
            TextBox1.Text += "8";*/
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            oprandsListner("9");
            /*if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/" || k == true)
            {
                TextBox1.Text = "";
                k = false;
            }
            TextBox1.Text += "9";*/
        }

        private void Button00_Click(object sender, EventArgs e)
        {
            oprandsListner("00");
            /*if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/" || k == true)
            {
                TextBox1.Text = "";
                k = false;
            }
            TextBox1.Text += "00";*/
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            oprandsListner(".");
            /*if (TextBox1.Text == "+" || TextBox1.Text == "-" || TextBox1.Text == "*" || TextBox1.Text == "/" || k == true)
            {
                TextBox1.Text = "";
                k = false;
            }
            TextBox1.Text += ".";*/
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            opratorListner("+");
            /*op = "+";
            num1 = TextBox1.Text;
            TextBox1.Text = "+";*/
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            /*op = "-";
            num1 = TextBox1.Text;
            TextBox1.Text = "-";*/
        }

        private void ButtonMulti_Click(object sender, EventArgs e)
        {
            /*op = "*";
            num1 = TextBox1.Text;
            TextBox1.Text = "*";*/
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            /*op = "/";
            num1 = TextBox1.Text;
            TextBox1.Text = "/";*/
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            /*double s=0;
            switch (op)
            {
                case "+": s = double.Parse(num1) + double.Parse(TextBox1.Text);
                          TextBox1.Text = s.ToString();
                          break;

                case "-": s = double.Parse(num1) - double.Parse(TextBox1.Text);
                          TextBox1.Text = s.ToString();
                          break;

                case "*": s = double.Parse(num1) * double.Parse(TextBox1.Text);
                          TextBox1.Text = s.ToString();
                          break;

                case "/": s = double.Parse(num1) / double.Parse(TextBox1.Text);
                          TextBox1.Text = s.ToString();
                          break;
            }
            k = true;*/
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
