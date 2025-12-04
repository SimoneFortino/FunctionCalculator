using System;
using System.Windows.Forms;
using System.Drawing;
using ScottPlot;
using ScottPlot.WinForms;

namespace FunctionCalculator
{
    public partial class Form1 : Form
    {
        
        readonly FormsPlot FormsPlot1 = new FormsPlot() { Dock = DockStyle.Fill };
        
        public Form1()
        {
            InitializeComponent();
            
            // Add the FormsPlot to the panel
            panel1.Controls.Add(FormsPlot1);

            // Plot data using the control
            double[] data = ScottPlot.Generate.Sin();
            FormsPlot1.Plot.Add.Signal(data);
            var cross = FormsPlot1.Plot.Add.Crosshair(0, 0);
            cross.HorizontalLine.Color = new ScottPlot.Color(System.Drawing.Color.Black);
            cross.VerticalLine.Color = new ScottPlot.Color(System.Drawing.Color.Black);
            FormsPlot1.Refresh();
            
            
            
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