using NCalc;
using System;
using System.Windows.Forms;


namespace FunctionCalculator
{
    public class DerivativeCalc 
    {
        public double CalculateDerivative(Expression expression, double xValue)
        {
            try
            {
                expression.Parameters["x"] = xValue;
                double functionResult = Convert.ToDouble(expression.Evaluate());
                Console.WriteLine(functionResult);
                expression.Parameters["x"] = ("h + " + xValue);
                string expressionText = expression.ParsedExpression.ToString();
                Console.WriteLine(expressionText);
                return 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
            

        }
    }
}