using System;
using System.Windows.Forms;

namespace FunctionCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }
        Calculator calculator = new Calculator();

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int prova = 5;
            int prova2 = 5;
            double parameterValue = Convert.ToDouble(parameterTextBox.Text);
            resultLabel.Text = Convert.ToString(calculator.ParseFunction(functionTextBox.Text, parameterValue));
        }
    }
}