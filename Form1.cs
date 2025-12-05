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
        private FormsPlot graph = new FormsPlot() { Dock = DockStyle.Fill };
        
        
        
        public Form1()
        {
            InitializeComponent();
            
            // Add the FormsPlot to the panel
            panel1.Controls.Add(graph);

            var crosshair = graph.Plot.Add.Crosshair(0, 0);
            crosshair.LineColor = Colors.Black;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var expr = new Expression(functionTextBox.Text);
                graph.Plot.Clear();
                var crosshair = graph.Plot.Add.Crosshair(0, 0);
                crosshair.LineColor = Colors.Black;
                
                // aggiunge la funzione usando NCalc
                var function = graph.Plot.Add.Function(x =>
                {
                    try
                    {
                        expr.Parameters["x"] = x;
                        return Convert.ToDouble(expr.Evaluate());
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                        expr = new Expression("0");
                        functionTextBox.Clear();
                        return Convert.ToDouble(expr.Evaluate());
                    }
                    
                });
                
                function.LineColor = Colors.Red;
                function.LineWidth = 2;
                graph.Plot.Axes.SetLimits(-5, 5, -5, 5);
                // force pixels to have a 1:1 scale ratio
                graph.Plot.Axes.SquareUnits();

                // even if you try to "stretch" the axis, it will adjust the axis limits automatically
                graph.Plot.Axes.SetLimits(-10, 10, -10, 10);
                
                graph.Refresh();
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                //MessageBox.Show(help);
            }
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Available functions:" +
                "\n\nAbs(x)\t\tAcos(x)" +
                "\nAsin(x)\t\tAtan(x)" +
                "\nCeiling(x)\t\tCos(x)" +
                "\nExp(x)\t\tFloor(x)" +
                "\nTruncate(x)\tLog(x)" +
                "\nLog10(x)\t\tMax(x, y)" +
                "\nMin(x, y)\t\tPow(x, y)" +
                "\nRound(x)\t\tSign(x)" +
                "\nSin(x)\t\tSqrt(x)" +
                "\nTan(x)\t\tIEEERemainder(x, y)",
                "Helper");
        }
    }
}