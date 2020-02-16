/*
 * PROG 2070
 * By: Justin Harvey
 * Assignment 2
 * TriangleSolver.cs
 * Professor: Rob Bowyer
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assignment2
{
    /// <summary>
    /// This class contains the Analyze method for testing triangles based on the size of their three sides
    /// </summary>
    public static class TriangleSolver
    {
        /// <summary>
        /// This method takes three int parameters as sides of a triangle and determines if they form a triangle,
        /// and if they do what kind of triangle: Equilateral, Isosceles or Scalene
        /// </summary>
        /// <param name="sideOne"></param>
        /// <param name="sideTwo"></param>
        /// <param name="sideThree"></param>
        /// <returns></returns>
        public static string Analyze(int sideOne, int sideTwo, int sideThree)
        {
            string result = "";
            if ((sideOne + sideTwo) > sideThree)
            {
                if ((sideOne + sideThree) > sideTwo)
                {
                    if ((sideTwo + sideThree) > sideOne)
                    {
                        result = "This is a valid Triangle\n";
                        if (sideOne == sideTwo && sideTwo == sideThree)
                        {
                            result += "This Triangle is an equilateral Triangle\n";
                        }
                        else if (sideOne == sideTwo || sideOne == sideThree || sideTwo == sideThree)
                        {
                            result += "This Triangle is an Isosceles Triangle\n";
                        }
                        else
                        {
                            result += "This is a Scalene Triangle\n";
                        }
                    }
                    else
                    {
                        result = "This is an invalid Triangle\n";
                    }
                }
                else
                {
                    result = "This is an invalid Triangle\n";
                }
            }
            else
            {
                result = "This is an invalid Triangle\n";
            }

            return result;
        }
    }
}
