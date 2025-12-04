using System;
using System.Windows.Forms;
using NCalc;


namespace FunctionCalculator
{
    public class Calculator
    {
        public object ParseFunction(String functionString, double parameterValue)
        {
            try
            {
                Expression expression = new Expression(functionString);
                expression.Parameters["x"] = parameterValue;
                return expression.Evaluate();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            
        }
    }
}