using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcutor
{
    public partial class Form1 : Form
    {

        string first = "";
        string second = "";
        char   function;
        double result = 0.0;
        string userInput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculatorDisplay_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            userInput += "2";
            label1.Text += userInput;
        }

        private void button18_Click(object sender, EventArgs e)
        {
           
            label1.Text = "";
            userInput += "1";
            label1.Text += userInput;
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "4";
            label1.Text += userInput;
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
           
        }

        private void button20_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            label1.Text += "";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            //плюс
            if(function == '+')
            {
                result = firstNum + secondNum;
                label1.Text = result.ToString();
            }
            // минус
            else if(function == '-')
            {
                result = firstNum - secondNum;
                label1.Text = result.ToString();
            }
            //делить
            else if(function == '/')
            {
                if(secondNum == '0')
                {
                    label1.Text += "Ты что дурак, на ноль не делим)))";

                }
               else
                {
                    result = firstNum / secondNum;
                    label1.Text = result.ToString();
                }
                //умнодаем

            }
            else if(function == '*')

                result = firstNum * secondNum;
                label1.Text = result.ToString();
        }

        private void NUM3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "3";
            label1.Text += userInput;
            
        }

        private void NUM5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "5";
            label1.Text += userInput;
        
        }

        private void NUM6_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "6";
            label1.Text += userInput;
       
        }

        private void NUM7_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "7";
            label1.Text += userInput;
          
        }

        private void NUM8_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "8";
            label1.Text += userInput;
         
        }

        private void NUM9_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "9";
            label1.Text += userInput;
           
        }

        private void NUM0_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "0";
            label1.Text += userInput;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += ".";
            label1.Text += userInput;
            
        }
    }
}
