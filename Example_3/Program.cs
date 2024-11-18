using System;

namespace GoodPractices
{
    class Program

    {
        static void Main(string[] args)

        {
            //Declaring variables 
            string name = "Louis Tully";
            int age = 31;
            double income = 5000.00;

            if (age >= 18)
            {
                Console.WriteLine($"{name}is not a minor. ");
            }
        }
    }
}
