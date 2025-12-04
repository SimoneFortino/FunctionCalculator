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
            try
            {
                double parameterValue = Convert.ToDouble(parameterTextBox.Text);
                resultLabel.Text = Convert.ToString(calculator.ParseFunction(functionTextBox.Text, parameterValue));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}