using System;
using System.Linq;

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
        }
    }
}
