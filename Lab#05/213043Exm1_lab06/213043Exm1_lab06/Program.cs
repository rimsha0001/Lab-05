﻿using System;
namespace Example
{

    class program
    { 
static void Main(string[] args)
    {
        double a = 98, b = 0;
        double result = 0;
        try
        {

            result = SafeDivision(a, b);
            Console.WriteLine($"{a} divided by {b} ={result}");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Attempted divide by zero.");
        }
    }
            static double SafeDivision(double x, double y)
            { 
            if (y == 0)
                    throw new System.DivideByZeroException();
                return x / y;
            }
        }
}
