﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Task 2.1 :  ");
            Console.ResetColor();
            Console.Write("Enter number: "); int number = Convert.ToInt32(Console.ReadLine());
            var answer = number.ToString().ToCharArray().Reverse();

            Console.WriteLine($"Your Number: {number}");
            Console.Write("Result: {");
            foreach (var item in answer)
                Console.Write($"{item};  ");
            Console.WriteLine("}");


            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Task 2.2 :  ");
            Console.ResetColor();
           
            Console.WriteLine("Enter array elements: ");
            string[] numbers = Console.ReadLine().Split();

            var positiveCount = numbers.Where(n => int.Parse(n) > 0).Count();
            var negativeSum = numbers.Where(n => (int.Parse(n) < 0)).Sum(n => int.Parse(n));
           
            Console.WriteLine($"[{positiveCount},  {negativeSum}]");
        }
    }
}
