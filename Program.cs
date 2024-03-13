using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("0 - Exit");
            
            Console.WriteLine("-----------------");
            Console.WriteLine("Select an option: ");
            
            short opt = short.Parse(Console.ReadLine());
            switch (opt)
            {
                case 1: Sum(); break;
                case 2: Sub(); break;
                case 3: Div(); break;
                case 4: Mul(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Sum()
        {
            Console.Clear();
            
            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine("The result of the sum is " + resultado);
            Console.ReadKey();
            Menu();
        }

        static void Sub()
        {
            Console.Clear();
            
            Console.WriteLine("First value: ");
            double v1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Second value: ");
            double v2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            double resultado = v1 - v2;
            Console.WriteLine("The result of the subtraction is " + resultado);
            Console.ReadKey();
            Menu();
        }

        static void Div()
        {
            Console.Clear();
            
            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine("The result of the division is " + resultado);
            Console.ReadKey();
            Menu();
        }

        static void Mul()
        {
            Console.Clear();
            
            Console.WriteLine("First value: ");
            int v1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Second value: ");
            int v2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            int resultado = v1 * v2;
            Console.WriteLine("The result of the multiplication is " + resultado);
            Console.ReadKey();
            Menu();
        }
    }
}

