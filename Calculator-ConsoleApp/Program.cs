using System;
using System.Collections.Generic;
using System.Linq; 

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Choose what you want to do:");
           Console.WriteLine("1. Add");
           Console.WriteLine("2. Subtract");
           Console.WriteLine("3. Multiply");
           Console.WriteLine("4. Divide");
           Console.WriteLine("5. Exit");
           Console.Write("Select an option: ");
           string choice = Console.ReadLine();

           switch (choice)
           {
            case "1":
                Console.WriteLine("How many numbers do you want to add: ");
                int count = Convert.ToInt32(Console.ReadLine());

                List<int> nums = new List<int>();

                for (int i = 0; i < count; i++)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    nums.Add(num);
                }

                int total = nums.Sum();
                Console.WriteLine($"Sum is {total}");
                break;

            case "2":
                Console.WriteLine("How many numbers do you want to subtract: ");
                int subCount = Convert.ToInt32(Console.ReadLine());

                List<int> subNums = new List<int>();

                for (int i = 0; i < subCount; i++)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    subNums.Add(num);
                }

                int difference = subNums[0];
                for (int i = 1; i < subNums.Count; i++)
                {
                    difference -= subNums[i];
                }
                Console.WriteLine($"Total is {difference}");
                break;

            case "3":
                Console.WriteLine("How many numbers do you want to multiply: ");
                int mulCount = Convert.ToInt32(Console.ReadLine());

                List<int> mulNums = new List<int>();
                for (int i = 0; i < mulCount; i++)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    mulNums.Add(num);
                }

                int mul = mulNums[0];
                for (int i = 1; i < mulNums.Count; i++)
                {
                    mul *= mulNums[i];
                }

                Console.WriteLine($"Total is {mul}");
                break;

            case "4":
                Console.WriteLine("How many numbers do you want to divide: ");
                int divCount = Convert.ToInt32(Console.ReadLine());

                List<int> divNums = new List<int>();
                for (int i = 0; i < divCount; i++)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    divNums.Add(num);
                }

                int div = divNums[0];
                for (int i = 1; i < divNums.Count; i++)
                {
                    div /= divNums[i];
                }

                Console.WriteLine($"Total is {div}");
                break;

            case "5":
                Console.WriteLine("Exiting.....");
                break;



            default:
                Console.WriteLine("Invalid choice.");
                break;
           }
        }
    }
}
