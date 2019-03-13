using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest
{
    public partial class Form1 : Form
    {       
        public Form1()
        {
            InitializeComponent();
            labelNumberOne.Text = "";
            labelNumberTwo.Text = "";
            labelOperation.Text = "";
        }

        private void EnterNumber(object sender, EventArgs e)
        {
            if (labelResult.Text.Length != 0)
                labelResult.Text = "";

            if (labelNumberOne.Text.Length == 0 || labelOperation.Text.Length == 0)
            {                
                labelNumberOne.Text += ((Button)sender).Text;
                if (labelNumberOne.Text[0] == '0')
                    labelNumberOne.Text = ((Button)sender).Text;
            }
            else
            {               
                labelNumberTwo.Text += ((Button)sender).Text;
                if (labelNumberTwo.Text[0] == '0')
                    labelNumberTwo.Text = ((Button)sender).Text;
            }
        }

        private void EnterOperation(object sender, EventArgs e)
        {
            if (labelNumberOne.Text.Length != 0 && labelNumberTwo.Text.Length == 0)
                labelOperation.Text = ((Button)sender).Text;
        }

        private void ClearField(object sender, EventArgs e)
        {
            labelNumberOne.Text = "";
            labelNumberTwo.Text = "";
            labelOperation.Text = "";
            labelResult.Text = "";
        }

        private void EqualField(object sender, EventArgs e)
        {
            if (labelNumberOne.Text.Length == 0 || labelNumberTwo.Text.Length == 0 || labelOperation.Text.Length == 0)
                return;

            double numberOne = Convert.ToDouble(labelNumberOne.Text);
            double numberTwo = Convert.ToDouble(labelNumberTwo.Text);
            char operation = Convert.ToChar(labelOperation.Text);

            switch (operation)
            {
                case '+':
                    labelResult.Text = (numberOne + numberTwo).ToString();
                    labelNumberOne.Text = "";
                    labelNumberTwo.Text = "";
                    labelOperation.Text = "";
                    break;
                case '-':
                    labelResult.Text = (numberOne - numberTwo).ToString();
                    labelNumberOne.Text = "";
                    labelNumberTwo.Text = "";
                    labelOperation.Text = "";
                    break;
                case '*':
                    labelResult.Text = (numberOne * numberTwo).ToString();
                    labelNumberOne.Text = "";
                    labelNumberTwo.Text = "";
                    labelOperation.Text = "";
                    break;
                case '/':
                    labelResult.Text = (numberOne / numberTwo).ToString();
                    labelNumberOne.Text = "";
                    labelNumberTwo.Text = "";
                    labelOperation.Text = "";
                    break;
            }
        }
    }
}
