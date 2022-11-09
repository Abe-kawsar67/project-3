using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operatorName = " ";
        bool operator_clicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void clickButton(object sender, EventArgs e)
        {
            Button buttonValue = (Button)sender;

            if ((displayResult.Text == "0") || (operator_clicked))
            {
                displayResult.Clear();
                
            }

            if (buttonValue.Text == ".")
            {
                if (!displayResult.Text.Contains("."))
                {
                    displayResult.Text = displayResult.Text + buttonValue.Text;

                }


            }
            else
                displayResult.Text = displayResult.Text + buttonValue.Text;
                operator_clicked = false;
            
        }

        private void clickedOperator(object sender, EventArgs e)
        {
            result = Double.Parse(displayResult.Text);
            Button buttonValue = (Button)sender;
            operatorName = buttonValue.Text;
            operator_clicked = true;
           

           
        }

        private void button20_Click(object sender, EventArgs e)
        {
            switch (operatorName)
            {
                case "+":
                    displayResult.Text = (result + Double.Parse(displayResult.Text)).ToString();
                    break;
                case "-":
                    displayResult.Text = (result - Double.Parse(displayResult.Text)).ToString();
                    break;
                case "*":
                    displayResult.Text = (result * Double.Parse(displayResult.Text)).ToString();
                    break;
                case "/":
                    displayResult.Text = (result / Double.Parse(displayResult.Text)).ToString();
                    break;
                    default:
                    break;

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            displayResult.Clear();
            result=0;
            displayResult.Text = "0";
        }

        private void displayResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
