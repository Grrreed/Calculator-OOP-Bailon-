using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using System.Windows.Forms;

namespace Calculator_oop__Bailon_1
{
    public partial class Calculator : Form
    {
        string operation = "";
        Boolean isoperationpressed = false;
        string num1 = "";

        public Calculator()
        {
            InitializeComponent();
        }
        private void Calculator_Load(object sender, EventArgs e)
        {
        }
        private void Txtnumberdisplay_TextChanged(object sender, EventArgs e)
        {
        }
        private void Btn0_Click(object sender, EventArgs e)
        {
            if (isoperationpressed)
            {
                num1 = Txtnumberdisplay.Text;
                Txtnumberdisplay.Text = "";
            }
            Txtnumberdisplay.Text += "0";
            isoperationpressed = false;
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (isoperationpressed)
            {
                num1 = Txtnumberdisplay.Text;
                Txtnumberdisplay.Text = "";
            }
            Txtnumberdisplay.Text += "1";
            isoperationpressed = false;
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            if (isoperationpressed)
            {
                num1 = Txtnumberdisplay.Text;
                Txtnumberdisplay.Text = "";
            }
            Txtnumberdisplay.Text += "2";
            isoperationpressed = false;
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            if (isoperationpressed)
            {
                num1 = Txtnumberdisplay.Text;
                Txtnumberdisplay.Text = "";
            }
            Txtnumberdisplay.Text += "3";
            isoperationpressed = false;
        }
        private void Btn4_Click(object sender, EventArgs e)
        {
            if (isoperationpressed)
            {
                num1 = Txtnumberdisplay.Text;
                Txtnumberdisplay.Text = "";
            }
            Txtnumberdisplay.Text += "4";
            isoperationpressed = false;
        }
        private void Btn5_Click(object sender, EventArgs e)
        {
            if (isoperationpressed)
            {
                num1 = Txtnumberdisplay.Text;
                Txtnumberdisplay.Text = "";
            }
            Txtnumberdisplay.Text += "5";
            isoperationpressed = false;
        }
        private void Btn6_Click(object sender, EventArgs e)
        {
            if (isoperationpressed)
            {
                num1 = Txtnumberdisplay.Text;
                Txtnumberdisplay.Text = "";
            }
            Txtnumberdisplay.Text += "6";
            isoperationpressed = false;
        }
        private void Btn7_Click(object sender, EventArgs e)
        {
            if (isoperationpressed)
            {
                num1 = Txtnumberdisplay.Text;
                Txtnumberdisplay.Text = "";
            }
            Txtnumberdisplay.Text += "7";
            isoperationpressed = false;
        }
        private void Btn8_Click(object sender, EventArgs e)
        {
            if (isoperationpressed)
            {
                num1 = Txtnumberdisplay.Text;
                Txtnumberdisplay.Text = "";
            }
            Txtnumberdisplay.Text += "8";
            isoperationpressed = false;
        }
        private void Btn9_Click(object sender, EventArgs e)
        {
            if (isoperationpressed)
            {
                num1 = Txtnumberdisplay.Text;
                Txtnumberdisplay.Text = "";
            }
            Txtnumberdisplay.Text += "9";
            isoperationpressed = false;
        }
        private void Btnplus_Click(object sender, EventArgs e)
        {
            operation = "+";
            isoperationpressed = true;
        }
        private void Btnminus_Click_1(object sender, EventArgs e)
        {
            operation = "-";
            isoperationpressed = true;
        }
        private void Btndmul_Click(object sender, EventArgs e)
        {
            operation = "*";
            isoperationpressed = true;
        }
        private void Btndiv_Click(object sender, EventArgs e)
        {
            operation = "/";
            isoperationpressed = true;
        }
        private void Btnequ_Click(object sender, EventArgs e)
        {
            if (operation.Equals("+"))
            {
                Txtnumberdisplay.Text = (float.Parse(num1) + float.Parse(Txtnumberdisplay.Text)).ToString();
            }
            if (operation.Equals("-"))
            {
                Txtnumberdisplay.Text = (float.Parse(num1) - float.Parse(Txtnumberdisplay.Text)).ToString();
            }
            if (operation.Equals("*"))
            {
                Txtnumberdisplay.Text = (float.Parse(num1) * float.Parse(Txtnumberdisplay.Text)).ToString();
            }
            if (operation.Equals("/"))
            {
                Txtnumberdisplay.Text = (float.Parse(num1) / float.Parse(Txtnumberdisplay.Text)).ToString();
            }
        }
        private void Btnclear_Click(object sender, EventArgs e)
        {
            Txtnumberdisplay.Clear();
            num1 = "0";
        }
        private void Btnneg_Click(object sender, EventArgs e)
        {
            if (Txtnumberdisplay.Text.Contains("-"))
            {
                Txtnumberdisplay.Text = Txtnumberdisplay.Text.Remove(0, 1);
            }
            else Txtnumberdisplay.Text = Txtnumberdisplay.Text;
        }
        private void Btnback_Click(object sender, EventArgs e)
        {
            if (Txtnumberdisplay.Text.Length > 0)
            {
                Txtnumberdisplay.Text = Txtnumberdisplay.Text.Remove(Txtnumberdisplay.Text.Length - 1, 1);
            }
            if (Txtnumberdisplay.Text== "")
            {
                Txtnumberdisplay.Text = "0";
            }
        }
        private void Btndot_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (num.Text == ".") 
            {
                if (!Txtnumberdisplay.Text.Contains("."))
                    Txtnumberdisplay.Text = Txtnumberdisplay.Text + num.Text;
            }
            else
            {
                Txtnumberdisplay.Text = Txtnumberdisplay.Text + num.Text;
            }
        }
        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            double sq = double.Parse(Txtnumberdisplay.Text);
            sq = Math.Sqrt(sq);
            Txtnumberdisplay.Text = System.Convert.ToString(sq);
        }
        private void Btnsquared_Click(object sender, EventArgs e)
        {
            double squared;
            squared = Convert.ToDouble(Txtnumberdisplay.Text) * Convert.ToDouble(Txtnumberdisplay.Text);
            Txtnumberdisplay.Text = System.Convert.ToString(squared);
        }
        private void Btndenom_Click(object sender, EventArgs e)
        {
            double denom;
            denom = Convert.ToDouble(1.0) /  Convert.ToDouble(Txtnumberdisplay.Text);
            Txtnumberdisplay.Text = System.Convert.ToString(denom);
        }
        private void Btnperce_Click(object sender, EventArgs e)
        {
            double percent;
            percent = Convert.ToDouble(Txtnumberdisplay.Text) / Convert.ToDouble(100);
            Txtnumberdisplay.Text = System.Convert.ToString(percent);
        }
    }
}