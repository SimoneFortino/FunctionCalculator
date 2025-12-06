using NCalc;
using System;
using System.Windows.Forms;
using AngouriMath;
using AngouriMath.Extensions;


namespace FunctionCalculator
{
    public class DerivativeCalc 
    {
        public Expression CalculateDerivative(String expression, double xValue)
        {
            try
            {
                String equationF = "(x - k)*m + p";
                Console.WriteLine("arriva:\t" + expression);
                Entity f =expression.ToEntity();
                Console.WriteLine("convertito a entity:\t" + f.ToString());

                // calcolo il limite per h → 0
                // Entity limit = f.Limit("h", 0);
                // Console.WriteLine(f.Limit("h", 0));

                double m = Convert.ToDouble(f.Limit("h", 0));
                

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