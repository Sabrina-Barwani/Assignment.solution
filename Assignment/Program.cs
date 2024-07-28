using System;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Print the First 10 Even Numbers
            Console.WriteLine("First 10 even numbers:");
            for (int a1 = 1; a1 <= 10; a1++)
            {
                Console.WriteLine(a1 * 2);
            }

            //Print the First 15 Fibonacci Numbers

            int n = 15;
            int a2 = 0, b = 1, c;

            Console.WriteLine("First 15 Fibonacci numbers:");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(a2);
                c = a2 + b;
                a2 = b;
                b = c;
            }

            //Print the First 10 Powers of 2
            Console.WriteLine("First 10 powers of 2:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
            // Find the Largest Number in an Array of Integers

            int[] numbers = { 3, 5, 7, 2, 8, 10, 4 };
            int max = numbers[0];

            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine($"The largest number is: {max}");

            //  Print a Pattern of Stars(Square)

            int size = 5; // Size of the square

            Console.WriteLine("Pattern of stars (Square):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            // Check if a Given Number is Prime or Not

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            Console.WriteLine($"{number} is {(isPrime ? "a prime number" : "not a prime number")}");

            //Calculate the Sum of the Digits of a Given Integer

            Console.Write("Enter an integer: ");
            int number1 = int.Parse(Console.ReadLine());
            int sum2 = 0;

            while (number1 != 0)
            {
                sum2 += number1 % 10;
                number1 /= 10;
            }

            Console.WriteLine($"The sum of the digits is: {sum2}");

            //Reverse a String

            Console.Write("Enter a string: ");
            string input4 = Console.ReadLine();
            char[] arr = input4.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr);

            Console.WriteLine($"Reversed string: {reversed}");

            //Count the Number of Vowels in a Given String

           Console.Write("Enter a string: ");
            string input1 = Console.ReadLine();
            int vowelCount = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char c1 in input1.ToLower())
            {
                if (Array.Exists(vowels, v => v == c1))
                {
                    vowelCount++;
                }
            }

            Console.WriteLine($"The number of vowels is: {vowelCount}");

            //Find the Sum of All Even Numbers from 1 to 100


            int sum1 = 0;

            for (int i = 2; i <= 100; i += 2)
            {
                sum1 += i;
            }

            Console.WriteLine($"The sum of all even numbers from 1 to 100 is: {sum1}");





        }
    }
}
