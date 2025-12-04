using System;
using System.Windows.Forms;
using System.Drawing;
using ScottPlot;
using ScottPlot.WinForms;
using NCalc;
using ScottPlot.DataSources;

namespace FunctionCalculator
{
    public partial class Form1 : Form
    {
        
        // readonly FormsPlot formsPlot = new FormsPlot() { Dock = DockStyle.Fill };
        private FormsPlot plot = new FormsPlot() { Dock = DockStyle.Fill };
        
        
        
        public Form1()
        {
            InitializeComponent();
            
            // Add the FormsPlot to the panel
            panel1.Controls.Add(plot);
            
            
            
            
            /*
            var cross = FormsPlot1.Plot.Add.Crosshair(0, 0);
            
            cross.HorizontalLine.Color = new ScottPlot.Color(System.Drawing.Color.Black);
            cross.HorizontalLine.LineWidth = 1;
            
            cross.VerticalLine.Color = new ScottPlot.Color(System.Drawing.Color.Black);
            cross.VerticalLine.LineWidth = 1;
            */
            
            
            
            
            
            
        }
        Calculator calculator = new Calculator();

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double parameterValue = Convert.ToDouble(parameterTextBox.Text);
                resultLabel.Text = Convert.ToString(calculator.ParseFunction(functionTextBox.Text, parameterValue));

                var expr = new Expression(functionTextBox.Text);

                // aggiunge la funzione usando NCalc
                plot.Plot.Add.Function(x =>
                {
                    expr.Parameters["x"] = x;
                    return Convert.ToDouble(expr.Evaluate());
                });
                plot.Plot.Axes.SetLimits(-5, 5, -5, 5);
                plot.Refresh();
                
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