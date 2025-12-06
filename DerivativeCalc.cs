using NCalc;
using System;
using System.Windows.Forms;
using AngouriMath;


namespace FunctionCalculator
{
    public class DerivativeCalc 
    {
        public double CalculateDerivative(Expression expression, double xValue)
        {
            try
            {
                
                
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