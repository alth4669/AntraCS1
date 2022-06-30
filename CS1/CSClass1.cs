using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    public class CSClass1
    {
        public void GenerateHackerName()
        {
            Console.Write("What is your favorite color: ");
            string FavColor = Console.ReadLine();
            Console.Write("What is your astrology sign: ");
            string astro = Console.ReadLine();
            Console.Write("What is the number of your street address: ");
            string street = Console.ReadLine();
            Console.WriteLine($"Your hacker name is {FavColor}{astro}{street}");
        }

        public void DisplayTypeInfo()
        {
            Console.WriteLine("{0,-20} {1, -10} {2, -35} {3, -50}", "Data Type", "Bytes", "Min Value", "Max Value");
            string[] types = {"sbyte", "byte", "short", "ushort", "int", "uint", "long",
            "ulong", "float", "double", "decimal"};
            int[] bytes = { 1, 1, 2, 2, 4, 4, 8, 8, 4, 8, 16 };
            object[] minValues = {sbyte.MinValue, byte.MinValue, short.MinValue, ushort.MinValue,
            int.MinValue, uint.MinValue, long.MinValue, ulong.MinValue, float.MinValue, double.MinValue, decimal.MinValue};
            object[] maxValues = {sbyte.MaxValue, byte.MaxValue, short.MaxValue, ushort.MaxValue,
            int.MaxValue, uint.MaxValue, long.MaxValue, ulong.MaxValue, float.MaxValue, double.MaxValue, decimal.MaxValue};


            for (int i = 0; i < types.Length; i++)
            {
                Console.WriteLine("{0,-20} {1, -10} {2, -35} {3, -50}", types[i], bytes[i], minValues[i], maxValues[i]);
            }

        }

        public void ConvertCenturies()
        {
            double c;
            Console.Write("Input: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Output: Centuries = {c * 100} Years = {c *= 36524} Days = {c *= 24} Hours = " +
                $"{c *= 60} Minutes = {c *= 60} Seconds = {c *= 1000} Miliseconds = {c *= 1000} Microseconds = {c *= 1000} Nanoseconds");
        }

        public void FizzBuzz()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void BuggyForLoop()
        {
            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void GuessNumber()
        {
            int correctNumber = new Random().Next(3) + 1;
            Console.Write("Guess a number ranging 1-3: ");
            int guess = int.Parse(Console.ReadLine());
            if (guess < 1 || guess > 3)
            {
                Console.WriteLine("Please guess a number ranging from 1-3.");
            }
            else if (guess == correctNumber)
            {
                Console.WriteLine("You guessed correctly!");
            }
            else if (guess < correctNumber)
            {
                Console.WriteLine("Your guess was too low.");
            }
            else if (guess > correctNumber)
            {
                Console.WriteLine("Your guess was too high.");
            }
        }

        public void Pyramid()
        {
            int layers;
            Console.Write("How many layers would you like in your pyramid: ");
            layers = Convert.ToInt32(Console.ReadLine());
            string stars;
            string spaces;
            for (int i = 0; i < layers; i++)
            {
                spaces = new string(' ', layers - i);
                stars = new string('*', i);
                Console.WriteLine(spaces + stars + '*' + stars + spaces);
            }
        }

        public void Birthday()
        {
            int month, day, year;
            Console.WriteLine("Enter birthday information below.");
            Console.Write("Please specify a month in MM format: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Please specify a day in DD format: ");
            day = int.Parse(Console.ReadLine());
            Console.Write("Please specify a year in YYYY format: ");
            year = int.Parse(Console.ReadLine());

            DateTime birthday = new DateTime(year, month, day);
            TimeSpan age = DateTime.Now.Subtract(birthday);

            Console.WriteLine($"Your birthday is {birthday}");
            int DaysOld = (int)Math.Floor(age.TotalDays);

            Console.WriteLine($"This person is {DaysOld} days old.");

            int daysToAnniversary = 10000 - (DaysOld % 10000);

            DateTime nextAnniversary = DateTime.Now.AddDays(daysToAnniversary);

            Console.WriteLine($"Your next 10,000 day anniversary is {nextAnniversary}");
        }

        public void Greeting()
        {
            DateTime now = DateTime.Now;
            if (now.Hour <= 6)
            {
                Console.WriteLine("Good night.");
            }
            if (now.Hour >= 7 && now.Hour <= 12)
            {
                Console.WriteLine("Good morning.");
            }
            if (now.Hour >= 13 && now.Hour <= 18)
            {
                Console.WriteLine("Good afternoon.");
            }
            if (now.Hour >= 19)
            {
                Console.WriteLine("Good evening.");
            }
        }

        public void Print24()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j <= 24; j += i)
                {
                    if (j == 24)
                    {
                        Console.Write($"{j}\n");
                    }
                    else
                    {
                        Console.Write($"{j},");
                    }
                }
            }
        }
    }
}
