using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    public class PowerCalculator
    {
        public double CalculatePower(double basee, int exponent)
        {
            
            if (exponent < 0)
            {
                throw new ArgumentException("A kitévő nem lehet negatív");
            }

            double result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= basee;
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Add meg az első számot");
            int basee = int.Parse(Console.ReadLine());

            Console.Write("Add meg a második számot");
            int exponent = int.Parse(Console.ReadLine());
            var calculator = new PowerCalculator();
            double result = calculator.CalculatePower(basee, exponent);

            Console.WriteLine($"{basee} * {exponent} = {result}");

        }
    }
}
