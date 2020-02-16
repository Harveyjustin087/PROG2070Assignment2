/*
 * PROG 2070
 * By: Justin Harvey
 * Assignment 2
 * TriangleSolver.Tests
 * Professor: Rob Bowyer
 */
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assignment2.Tests
{
    [TestFixture]
    //These tests evalute the TriangleSolver class's method Analyze to see if it produces correct results
    // basedo n the given inputes
    public class TriangleSolverTests
    {
        [Test]
        //This test checks that given the correct input for an Equilateral triangle that the correct output string is returned
        //This test should pass.
        public void IsEquilateral()
        {
            //Arrange
            int sideOne = 2;
            int sideTwo = 2;
            int sideThree = 2;
            string equilateralResult = "This is a valid Triangle\nThis Triangle is an equilateral Triangle\n";
            //Act
            string result = TriangleSolver.Analyze(sideOne, sideTwo, sideThree);
            //Assert
            Assert.AreEqual(result, equilateralResult);
        }
        [Test]
        //This test checks that given the correct input for an Isosceles triangle that the correct output string is returned
        //This test should pass
        public void IsIsosceles()
        {
            //Arrange
            int sideOne = 3;
            int sideTwo = 2;
            int sideThree = 3;
            string isosceleslResult = "This is a valid Triangle\nThis Triangle is an Isosceles Triangle\n";
            //Act
            string result = TriangleSolver.Analyze(sideOne, sideTwo, sideThree);
            //Assert
            Assert.AreEqual(result, isosceleslResult);
        }
        [Test]
        //This test checks that given the correct input for a Scalene triangle that the correct output string is returned
        //This test should pass.
        public void IsScalene()
        {
            //Arrange
            int sideOne = 8;
            int sideTwo = 9;
            int sideThree = 7;
            string scaleneResult = "This is a valid Triangle\nThis is a Scalene Triangle\n";
            //Act
            string result = TriangleSolver.Analyze(sideOne, sideTwo, sideThree);
            //Assert
            Assert.AreEqual(result, scaleneResult);
        }
        [Test]
        //This test checks that given the incorrect input for an invalid triangle is given and that it matches the
        //invalid triangle output. This test should pass.
        public void IsInvalid()
        {
            //Arrange
            int sideOne = 43;
            int sideTwo = 2;
            int sideThree = 7;
            string invalidResult = "This is an invalid Triangle\n";
            //Act
            string result = TriangleSolver.Analyze(sideOne, sideTwo, sideThree);
            //Assert
            Assert.AreEqual(result, invalidResult);
        }
        [Test]
        //This test makes sure that all zeroes for the triangle sides are not taken as an Equilateral triangle.
        public void ZeroesAreNotEquilateral()
        {
            //Arrange
            int sideOne = 0;
            int sideTwo = 0;
            int sideThree = 0;
            string equilateralResult = "This is a valid Triangle\nThis Triangle is an equilateral Triangle\n";
            //Act
            string result = TriangleSolver.Analyze(sideOne, sideTwo, sideThree);
            //Assert
            Assert.AreNotEqual(result, equilateralResult);
        }
        [Test]
        //This test makes sure that if two zeroes are given as input for triangle sides it is not counted as and
        //isosceles triangle.
        public void TwoZeroesAreNotIsosceles()
        {
            //Arrange
            int sideOne = 0;
            int sideTwo = 3;
            int sideThree = 0;
            string isosceleslResult = "This is a valid Triangle\nThis Triangle is an Isosceles Triangle\n";
            //Act
            string result = TriangleSolver.Analyze(sideOne, sideTwo, sideThree);
            //Assert
            Assert.AreNotEqual(result, isosceleslResult);
        }
    }
}