using NCalc;
using System;
using System.Windows.Forms;
using AngouriMath;
using AngouriMath.Extensions;


namespace FunctionCalculator
{
    public class DerivativeCalc 
    {
        public Expression CalculateDerivative(String expression, double xValue, string originalString)
        {
            try
            {
                //String equationF = "(x - k)*m + p";
                Entity f =expression.ToEntity();

                // calcolo il limite per h → 0
                Entity m = f.Limit("h", 0);
                //calcola Y
                Entity a = originalString.ToEntity();
                var newExpr = a.Substitute("x", xValue);
                var Y = newExpr.EvalNumerical();

                Entity equation = "Y-Yp=m*(X-Xp)".ToEntity();
                
                var finalEquation = equation.Substitute("Xp", xValue).Substitute("Yp", Y).Substitute("m",m);
                
                return null;
            }             
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\nerrore derivata");
                return null;
            }
            

        }
    }
}

/*
 * funzione limite:
 * double Limit(Func<double, double> func, double point)
{
    double h = 1e-6;

    double left  = func(point - h);
    double right = func(point + h);

    return (left + right) / 2;
}

double result = Limit(x => Math.Sin(x) / x, 0);
Console.WriteLine(result);   // ≈ 1

 */