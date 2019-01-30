using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program start");
            WhileCount();
            WhileNumber();

        }
        static void WhileCount()
        {
            var counter = 0;
            while (counter < 101)
            {
                Console.WriteLine($"Number {counter}");
                counter = counter +1;
            }
        }
        static void WhileNumber()
        {
            var max = 25;
            var number = 1;
            var increment = 1;
            while (number < max)
            {
                Console.WriteLine($"Other Number is {number}");
                //Console.WriteLine($"The count is {increment}");
                number = number * increment;
                increment++;
            }
        }
    }
}
