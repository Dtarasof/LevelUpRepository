﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            int command = 0;
            do
            {
                Console.WriteLine("1. PARITY CHECK.");
                Console.WriteLine("2. NUMBERS.");
                Console.WriteLine("3. INCH CONVERTER.");
                Console.WriteLine("4. DRAW LINE.");
                Console.WriteLine("5. SUM EVENS.");
                Console.WriteLine("6. FACTORIAL");
                Console.WriteLine("7. FIGURES.");
                Console.WriteLine("8. EXIT");
                command = Int16.Parse(Console.ReadLine());
                Console.Clear();
                switch (command)
                {
                    case 1:
                        Even();
                        break;
                    case 2:
                        Numbers_v2();
                        break;
                    case 3:
                        InchConvert();
                        break;
                    case 4:
                        MakeLine();
                        break;
                    case 5:
                        SumOdds();
                        break;
                    case 6:
                        Factorial();
                        break;
                    case 7:
                        Figures.ShowFigures();
                        break;
                    default:
                        command = 8;
                        break;
                }
                Console.Clear();
            } while (command != 8);
        }

        public static void Even()
        {
            int A;
            Console.WriteLine("PARITY CHECK.");
            Console.WriteLine("Please enter the number:");
            A = Int16.Parse(Console.ReadLine());
            if (A % 2 == 0)
            {
                Console.WriteLine("Even.");
            }
            else
            {
                Console.WriteLine("Odd.");
            }
            Console.ReadLine();
        }

        public static void Numbers()
        {
            int sum = 0, count = 0;
            double a = 0;
            string numbers = "";
            Console.WriteLine("NUMBERS.");
            Console.WriteLine("Please enter the number a < 100:");
            try
            {
                a = Double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error.");
                return;
            }
            numbers = a.ToString().Replace(",", "");
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Int32.Parse(numbers[i].ToString());
                count++;
            }
            Console.WriteLine("Sum: {0}  Number of digits: {1}", sum, count);
            Console.ReadLine();
        }

        public static void Numbers_v2()
        {
            int sum = 0, unit = 0, count = 0;
            double natural = 0;
            string number = "";
            Console.WriteLine("NUMBERS.");
            Console.WriteLine("Please enter the number a < 100:");
            try
            {
                number = Console.ReadLine();
                natural = Double.Parse(number);
                count = number.Replace(",", "").Length;
            }
            catch
            {
                Console.WriteLine("Error.");
                return;
            }
            unit = (int)(natural * Math.Pow(10, count - ((int)natural).ToString().Length));
            while (unit != 0)
            {
                sum += (unit % 10);
                unit = unit / 10;
            }
            Console.WriteLine("Sum: {0}  Number of digits: {1}", sum, count);
            Console.ReadLine();
        }

        public static void InchConvert()
        {
            double result = 0;
            int operation = 0;
            do
            {
                Console.WriteLine("INCH CONVERTER.");
                Console.WriteLine("1. Inch -> Centimeter.\n2. Centimeter -> Inch.\n3. Exit.");
                operation = Int32.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Please enter number of inches:");
                        result = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("{0} inches = {1} centimeters", result, result * 2.54);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Please enter number of centimeters:");
                        result = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("{0} centimeters = {1} inches", result, (result / 2.54).ToString("#.##"));
                        Console.ReadLine();
                        break;
                }
                Console.Clear();
            } while (operation != 3);
            Console.ReadLine();
        }

        public static void MakeLine()
        {
            string symbol = "";
            int _length = 0, direction = 0;
            Console.WriteLine("DRAW LINE.");
            Console.WriteLine("Please enter the length of line:");
            _length = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the symbol of line:");
            symbol = Console.ReadLine();
            Console.WriteLine("Please enter the direction of line (0 = horisontal, 1 = vertical):");
            direction = Int32.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < _length; i++)
            {
                if (direction == 1)
                {
                    Console.WriteLine(symbol);
                }
                else
                {
                    Console.Write(symbol);
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        public static void SumOdds()
        {
            int A = 0, B = 0, result = 0, i = 0;
            Console.WriteLine("SUM EVENS.");
            Console.WriteLine("Please enter the first number of range:");
            A = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the last number of range:");
            B = Int16.Parse(Console.ReadLine());
            i = A;
            while (i <= B)
            {
                if (i % 2 != 0)
                {
                    result += i;
                }
                i++;
            }
            Console.Clear();
            Console.WriteLine("The sum of odds in range from {0} to {1} = {2}", A, B, result);
            Console.ReadLine();
        }

        public static void Factorial()
        {
            int num = 0, factorial = 1;
            Console.WriteLine("Factorial.");
            num = Int16.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Factorial = {0}", factorial);
            Console.ReadLine();
        }
    }
}

