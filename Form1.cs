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
                        return 0;
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
            DialogResult result = MessageBox.Show(
                "Do you need help",       // text
                "Help",                         // title
                MessageBoxButtons.YesNo,                // yes or no button
                MessageBoxIcon.Information,             // icons on the textbox
                MessageBoxDefaultButton.Button1         // type of button
            );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Helper:" + Environment.NewLine + "Supported character:  +  -  /  *  Sin( ) Sqrt( )  " + Environment.NewLine + "Do not use spaces");
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Okidoki👍");
            }
        }
    }
}