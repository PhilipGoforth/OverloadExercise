using System;

namespace OverloadExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(1, 2);
            Add(1.2, 3.4);
            Add(3, 4, true);
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
            if(isTrue)
            {
                string answer = (sum == 1) ? $"{sum} dollar" : $"{sum} dollars";
                Console.WriteLine(answer);
            } 
        }
    }
}
