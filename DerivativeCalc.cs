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
                /*
                 expression.Parameters["x"] = ("h + " + xValue);
                string functionResult = Convert.ToString(expression.Evaluate());
                string expressionText = expression.ParsedExpression.ToString();
                
                Console.WriteLine(expressionText);
                Console.WriteLine(functionResult);
                */
                string expressionText = expression.ParsedExpression.ToString();
                Console.WriteLine(expressionText);
                return 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\nerrore derivata");
                return 0;
            }
            

        }
    }
}