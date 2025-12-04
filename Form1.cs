using System;
using System.Windows.Forms;
using System.Drawing;
using ScottPlot;
using ScottPlot.WinForms;
using NCalc;
using ScottPlot.DataSources;
using Color = ScottPlot.Color;

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

            var crosshair = plot.Plot.Add.Crosshair(0, 0);
            crosshair.LineColor = new Color(System.Drawing.Color.Black);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var expr = new Expression(functionTextBox.Text);
                plot.Plot.Clear();
                plot.Plot.Add.Crosshair(0, 0);
                
                // aggiunge la funzione usando NCalc
                var addedFunction = plot.Plot.Add.Function(x =>
                {
                    expr.Parameters["x"] = x;
                    return Convert.ToDouble(expr.Evaluate());
                });
                plot.Plot.Axes.SetLimits(-5, 5, -5, 5);
                // force pixels to have a 1:1 scale ratio
                plot.Plot.Axes.SquareUnits();

                
                plot.Plot.Axes.SetLimits(-10, 10, -10, 10);
                addedFunction.LineWidth = 2;
                addedFunction.LineColor = new Color(System.Drawing.Color.Red);
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