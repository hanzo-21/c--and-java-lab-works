using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_deligates
{
    internal class Program
    {

        //define a method to return sum of two numbers 
        static int calcluateSum(int x , int y)
        {
            return x + y;
        }

        //define deligates
        public delegate int MyDeligates(int num1, int num2);


        static void Main(string[] args)
        {
            // creating instance of deligates by passing method name

            MyDeligates _MyDeligates = new MyDeligates(calcluateSum);

            int result = _MyDeligates(8, 12);

            Console.WriteLine("sum = " + result);
            Console.ReadKey();

        }
    }
}
