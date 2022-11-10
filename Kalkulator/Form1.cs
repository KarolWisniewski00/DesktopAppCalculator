using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        bool firstNumber = true;
        double number1;
        double number2;
        string sign;
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            NumberBtnClick("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberBtnClick("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberBtnClick("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumberBtnClick("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumberBtnClick("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumberBtnClick("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumberBtnClick("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumberBtnClick("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NumberBtnClick("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumberBtnClick("9");
        }
        private void NumberBtnClick(string number)
        {
            if (firstNumber == false)
            {
                textBox1.Text += number;
            }
            else
            {
                textBox1.Text = number;
                firstNumber = false;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Operation("+");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Operation("-");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Operation("*");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            Operation("/");
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length > 0)
                {
                    number2 = Convert.ToDouble(textBox1.Text);
                    label1.Text = String.Empty;
                    switch (sign)
                    {
                        case "+":
                            textBox1.Text = Convert.ToString(number1 + number2);
                            break;
                        case "-":
                            textBox1.Text = Convert.ToString(number1 - number2);
                            break;
                        case "*":
                            textBox1.Text = Convert.ToString(number1 * number2);
                            break;
                        case "/":
                            if (number2 == 0)
                            {
                                MessageBox.Show("Cannot be devided by 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                textBox1.Text = Convert.ToString(number1 / number2);
                            }
                            break;
                    }
                sign = String.Empty;
                firstNumber = true;
                }
                
            }
            catch
            {
                MessageBox.Show("Incorrect value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = String.Empty;
            }
        }

        private void Operation(string sign)
        {
            try
            {
                if (textBox1.Text.Length > 0)
                {
                    if (textBox1.Text.EndsWith(","))
                    {
                        textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    }
                    number1 = Convert.ToDouble(textBox1.Text);
                    label1.Text = textBox1.Text += sign;
                    this.sign = sign;
                    firstNumber = true;
                    textBox1.Text = String.Empty;
                }
            }
            catch
            {
                MessageBox.Show("Incorrect value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = String.Empty;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = String.Empty;
            sign = String.Empty;
            firstNumber = true;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            firstNumber = true;
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.IndexOf(",") == -1)
                {
                    textBox1.Text += ",";
                    firstNumber = false;
                }
            }
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * -1);
            }
            catch{}
        }
    }
}
