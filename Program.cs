﻿using System;

namespace _01.ExellentGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 5.50)
            {
                Console.WriteLine("Exellent!");
            }
        }
    }
}
