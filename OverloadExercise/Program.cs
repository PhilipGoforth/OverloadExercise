using System;

namespace OverloadExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;
            Add(1, 2);
            Add(1.2, 3.4);
            Add(3, 4, isTrue);
        }
        static void Add(int num1, int num2)
        {
            var sum = num1 + num2;
            Console.WriteLine(sum); 
        }
        static void Add(double num1, double num2)
        {
            var sum = num1 + num2;
            Console.WriteLine(sum);
        }
        static void Add(int num1, int num2, bool isTrue)
        {
            var sum = num1 + num2;
            do
            {
               if(sum == 1)
                {
                    Console.WriteLine($"{sum} dollar");
                    break;
                }
                else
                {
                    Console.WriteLine($"{sum} dollars");
                    break;
                }
            } while (isTrue);
            
        }
    }
}
