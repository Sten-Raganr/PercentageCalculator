using System;

namespace PercentageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximum;
            int userscore;
            double result;
            Console.WriteLine("What is your maximum score?");
            maximum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is your score?");
            userscore = Int32.Parse(Console.ReadLine());
            result = (userscore * 100 / maximum );
            Console.WriteLine($"You scored {result}%.");
            if (result >= 90)
                Console.WriteLine("You get 5.");
            else if (result >= 80)
                Console.WriteLine("You get 4.");
            else if (result >= 61)
                Console.WriteLine("You get 3.");
            else Console.WriteLine("You get 2.");





        }
    }
}
