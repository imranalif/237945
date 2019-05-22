using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double firstNumber, secondNumber, result;
            firstNumber = Convert.ToInt32(firstTextBox.Text);
            secondNumber = Convert.ToInt32(secondTextBox.Text);
            result = firstNumber + secondNumber;
            resultTextBox.Text = result.ToString();
        }

        private void substractButton_Click(object sender, EventArgs e)
        {
            double firstNumber, secondNumber, result;
            firstNumber = Convert.ToInt32(firstTextBox.Text);
            secondNumber = Convert.ToInt32(secondTextBox.Text);
            result = firstNumber - secondNumber;
            resultTextBox.Text = result.ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            double firstNumber, secondNumber, result;
            firstNumber = Convert.ToInt32(firstTextBox.Text);
            secondNumber = Convert.ToInt32(secondTextBox.Text);
            result = firstNumber * secondNumber;
            resultTextBox.Text = result.ToString();
        }
    }
}
