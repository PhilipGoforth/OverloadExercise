using System;

namespace OverloadExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static int Add(int num1, int num2)
        {
            var sum = num1 + num2;
            return sum;
        }
        static double Add(double num1, double num2)
        {
            var sum = num1 + num2;
            return sum;
        }
        static string Add(int num1, int num2, bool isTrue)
        {
            var sum = num1 + num2;
            if (isTrue)
            {
                if(sum == 1)
                {
                    return $"{sum} dollar";
                }
                else
                {
                    return $"{sum} dollars";
                }
            }
            else
            {
                return "no money";
            }

               
        }
    }
}
