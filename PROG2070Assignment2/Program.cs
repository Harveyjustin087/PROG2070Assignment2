/*
 * PROG 2070
 * By: Justin Harvey
 * Assignment 2
 * Program.cs
 * Professor: Rob Bowyer
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;
            int sideOne = 0;
            int sideTwo = 0;
            int sideThree = 0;
            while (selection != 2)
            {
                try
                {
                    Console.WriteLine("Hello Welcome!");
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("1. Enter Triangle Dimensions\n" +
                        "2. Exit \n");
                    Console.WriteLine("---------------------------------------------");
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error at: {ex.Message}");
                }
                if (selection == 1)
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Please enter the value for side 1");
                    try
                    {
                       sideOne = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error at: {ex.Message}");
                    }
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Please enter the value for side 2");
                    try
                    {
                        sideTwo = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error at: {ex.Message}");
                    }
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Please enter the value for side 3");
                    try
                    {
                        sideThree = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error at: {ex.Message}");
                    }
                    Console.WriteLine($"Your selections are \n Side 1: {sideOne}\n Side 2: {sideTwo}\n Side 3: {sideThree}");
                    Console.WriteLine(TriangleSolver.Analyze(sideOne, sideTwo, sideThree));
                }
            }
        }
    }
}
