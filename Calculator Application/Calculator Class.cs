using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Application
{
    public delegate T Formula<T>(T arg1, T arg2);
    internal class CalculatorClass
    {
        public Formula<String> info;

        public double GetSum(double n1, double n2)
        {
            return (n1 + n2);
        }
        public double GetDifference(double n1, double n2)
        {
            return (n1 - n2);
        }
        public double GetProduct(double n1, double n2)
        {
            return (n1 * n2);
        }
        public double GetQuotien(double n1, double n2)
        {
            return (n1 / n2);
        }

        public event Formula<double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the delegate " + value);
            }
            remove
            {
                Console.WriteLine("Removed the delegate " + value);
            }
        }
    }
}
