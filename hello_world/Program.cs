using System;

namespace hello_world
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter an integer:\n");
            //int enteredNum = Convert.ToInt32(Console.ReadLine());
            //isValid(enteredNum);

            //Console.WriteLine("\nEnter your first number:");
            //decimal num1 = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("\nEnter your second number:");
            //decimal num2 = Convert.ToDecimal(Console.ReadLine());
            //max(num1, num2);

            //Console.WriteLine("\nEnter width of picture:");
            //int width = Convert.ToInt32(Console.ReadLine())
            //Console.WriteLine("\nEnter height of picture:");
            //int height = Convert.ToInt32(Console.ReadLine())
            //pictureDimensions(width, height);

            Console.WriteLine("\nWhat is the speed limit?");
            decimal limit = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nWhat is the car's speed?");
            decimal speed = Convert.ToDecimal(Console.ReadLine());
            speedLimit(limit, speed);

            //Console.WriteLine("\nHelllllllllo world.");
        }

        public static void isValid(int num)
        {
            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("Valid");
            } else
            {
                Console.WriteLine("Invalid");
            }
        }

        public static void max(decimal num1, decimal num2)
        {
            var maxNum = num1 > num2 ? num1 : num2;
            Console.WriteLine("\nLarger number: {0}", maxNum);
        }

        public static void pictureDimensions(int width, int height)
        {
            if (width == height)
            {
                Console.WriteLine("\nIt's a square.");
            } else if (width > height)
            {
                Console.WriteLine("\nLandscape");
            } else
            {
                Console.WriteLine("\nPortrait");
            }
        }

        public static void speedLimit(decimal limit, decimal speed)
        {
            if (speed <= limit)
            {
                Console.WriteLine("Ok");
            } else
            {
                int points = Decimal.ToInt32((speed - limit) / 5);
                Console.WriteLine("Total demerit points: {0}", points);
                if (points > 12)
                {
                    Console.WriteLine("Liscense suspended");
                }

            }
        }

    }
}
