using NCalc;
using System;
using System.Windows.Forms;
using AngouriMath;
using AngouriMath.Extensions;


namespace FunctionCalculator
{
    public class DerivativeCalc 
    {
        public double CalculateDerivative(Expression expression, double xValue)
        {
            try
            {
                Console.WriteLine(expression.ToString() + " \t" + xValue);
                    String expr = expression.ParsedExpression.ToString();
                    Console.WriteLine(expr);
                    Entity f =expr.ToEntity();
                    Console.WriteLine(f);

                    // calcolo il limite per h → Xvalue
                    Entity limit = f.Limit("h", 0);
                    Console.WriteLine(f.Limit("h", 0));

                
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