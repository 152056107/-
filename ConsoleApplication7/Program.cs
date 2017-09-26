using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
           
           Console.WriteLine(cal.Jian("woshidashen", "shi"));
            Console.WriteLine(cal.Jia("woshi", "dashe"));
        }
    }
    public class Calculator
    {
        public string Jia(string a, string b)
        {

            return a + b;
        }
        public string Jian(string a, string b)
        {

            return a.Replace(b, "");
        }
        public double Jia(double a, double b)
        {
            return a + b;
        }
        public double Jian(double a, double b)
        {
            return a - b;
        }
        public double Cheng(double a, double b)
        {
            return a * b;

        }
        public double Chu(double a, double b)
        {
            double result = new double();
            try
            {
                if (b == 0)
                    throw new DivideByZeroException();
                else
                    result = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("除数不能为零!");
            }


            return result;
        }
    }
}
