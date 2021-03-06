﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu;

namespace hw4
{
    class HomeWork4 : IHomeWork
    {
        private string[] _names = {"1. DELETE ZERO.",
                                  "2. SORT.",
                                  "3. COMPARE.",
                                  "4. CHANGE COLUMNS.",
                                  "5. GET STATISTICS.",
                                  "6. MODIFY STRING."};

        public void Start(int hw)
        {
            switch (hw)
            {
                case 1:
                    DeleteZero();
                    break;
                case 2:
                    Sort();
                    break;
                case 3:
                    Compare();
                    break;
                case 4:
                    ChangeColumns();
                    break;
                case 5:
                    StringStatistic();
                    break;
                case 6:
                    ModifyString();
                    break;
                default:
                    break;
            }
        }

        private void DeleteZero()
        {
            int[] mas = { 0, 1, 2, 0, 3, 0, 4, 0 };
            foreach (var item in mas)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == 0)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        mas[j - 1] = mas[j];
                    }
                    mas[mas.Length - 1] = -1;
                }
            }
            foreach (var item in mas)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        private void Sort()
        {
            int temp, index;
            int[] mas = { 2, -1, 4, 4, -3, 0, -4, 0 };
            for (int i = 0; i < mas.Length; i++)
            {
                temp = mas[i];
                index = i;
                for (int j = i; j < mas.Length; j++)
                {
                    if (temp > mas[j])
                    {
                        temp = mas[j];
                        index = j;
                    }
                }
                mas[index] = mas[i];
                mas[i] = temp;
            }
            foreach (var item in mas)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.ReadLine();

        }

        private void Compare()
        {
            int[] mas = new int[300];
            int a, count = 0;
            Console.WriteLine("Please enter the number:");
            a = Int16.Parse(Console.ReadLine());
            Random rnd = new Random();

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(-30, 30);
            }
            foreach (var item in mas)
            {
                if (a == item)
                {
                    count++;
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(item + " ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("\r\nThe quantity of such numbers: {0}", count);
            Console.ReadLine();
        }

        private void ChangeColumns()
        {
            int a, b, temp;
            int[,] mas = new int[9, 10];
            Random rnd = new Random();
            Console.WriteLine("Please enter the number of 1st column:");
            a = Int16.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Please enter the number of 2nd column:");
            b = Int16.Parse(Console.ReadLine()) - 1;

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.Next(0, 100);
                    if (mas[i, j] < 10)
                    {
                        Console.Write(" " + mas[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(mas[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                temp = mas[i, a];
                mas[i, a] = mas[i, b];
                mas[i, b] = temp;
            }

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] < 10)
                    {
                        Console.Write(" " + mas[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(mas[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private void StringStatistic()
        {
            Console.WriteLine("Please enter string:");
            string str = Console.ReadLine();
            GetStatistic(str);
        }

        private void GetStatistic(string str)
        {
            int spaces = 0, lower = 0, upper = 0, symbol = 0, digit = 0, punctuation = 0;
            foreach (var item in str)
            {
                if (Char.IsLetter(item))
                {
                    symbol++;
                    if (Char.IsLower(item))
                    {
                        lower++;
                    }
                    else
                    {
                        upper++;
                    }
                }
                if (Char.IsWhiteSpace(item))
                {
                    spaces++;
                }
                else if (Char.IsDigit(item))
                {
                    digit++;
                }
                else if (Char.IsPunctuation(item))
                {
                    punctuation++;
                }
            }
            Console.WriteLine("The length of line: {0} ", str.Length);
            Console.WriteLine("The number letters in line: {0} ", symbol);
            Console.WriteLine("The number lower letters in line: {0} ", lower);
            Console.WriteLine("The number upper letters in line: {0} ", upper);
            Console.WriteLine("The number digits in line: {0} ", digit);
            Console.WriteLine("The number punctuation symbols in line: {0} ", punctuation);
            Console.WriteLine("The number spaces in line: {0} ", spaces);
            Console.ReadLine();
        }

        private void ModifyString()
        {
            string str, symb;
            int index;
            Console.WriteLine("Please enter the string line:");
            str = Console.ReadLine();
            Console.WriteLine("Please enter 1 symbol:");
            symb = Console.ReadLine();
            index = str.Length;

            index = str.LastIndexOf(symb);

            str = str.Remove(index);

            str = str.Replace(symb, symb.ToUpper());
            Console.WriteLine(str);
            Console.ReadLine();
        }

        public string[] GetNames { get { return _names; } }

    }
}
