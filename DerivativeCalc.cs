using NCalc;
using System;
using System.Windows.Forms;
using AngouriMath;
using AngouriMath.Extensions;


namespace FunctionCalculator
{
    public class DerivativeCalc 
    {
        public string CalculateDerivative(String expression, double xValue, string originalString)
        {
            try
            {
                //calcola Y
                Entity a = originalString.ToEntity();
                var newExpr = a.Substitute("x", xValue);
                var y = newExpr.EvalNumerical();
                                
                //preparazione equazione per limite
                expression = expression.Replace("x", "(h +" + xValue + ")");
                expression = expression.Insert(0, "(");
                expression = expression.Insert(23, "-y)/ h");
                string ystring= y.ToString();
                expression = expression.Replace("y", ystring);
                //expression = String.Concat(expression, "-"+y+")/ h");

                Entity f =expression.ToEntity();

                // calcolo il limite per h → 0
                Entity m = f.Limit("h", 0);
                


                Entity equation = "Y=m*(X-Xp)+Yp".ToEntity();
                
                var finalEquation = equation.Substitute("Xp", xValue).Substitute("Yp", y).Substitute("m",m);
                string finalequationstring=finalEquation.ToString();
                return finalequationstring;
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