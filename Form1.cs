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

            graph.Plot.Add.Crosshair(0, 0);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var expr = new Expression(functionTextBox.Text);
                graph.Plot.Clear();
                graph.Plot.Add.Crosshair(0, 0);
                
                // aggiunge la funzione usando NCalc
                graph.Plot.Add.Function(x =>
                {
                    expr.Parameters["x"] = x;
                    return Convert.ToDouble(expr.Evaluate());
                });
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
            string help = "prova";
            MessageBox.Show(help);
        }
    }
}