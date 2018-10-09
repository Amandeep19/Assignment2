using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2;
using NUnit.Framework;

namespace Assignment_Tests
{
    [TestFixture]
    class TriangleSolverTests
    {
        [Test]
        public void Analyze_inputSides0_expectedNotATriangle()
        {
            int s1 = 0;
            int s2 = 0;
            int s3 = 0;
            string output = TriangleSolver.Analyze(s1, s2, s3);
            Assert.AreEqual("This is not a Triangle", output);
        }

        [Test]
        public void Analyze_input2SidesEqualToThird_expectedNotATriangle()
        {
            int s1 = 2;
            int s2 = 3;
            int s3 = 5;
            string result = TriangleSolver.Analyze(s1, s2, s3);
            Assert.AreEqual("This is not a Triangle", result);
        }
        [Test]
        public void Analyze_inputSides1_expectedNotATriangle()
        {
            int s1 = 1;
            int s2 = 1;
            int s3 = 1;
            string output = TriangleSolver.Analyze(s1, s2, s3);
            Assert.AreEqual("This is Equilateral Triangle", output);
        }

        
        [Test]
        public void Analyze_inputSidesFromingEquilateralTriangle_expectedEqulateralTriangle()
        {
            int s1 = 3;
            int s2 = 3;
            int s3 = 3;
            string output = TriangleSolver.Analyze(s1, s2, s3);
            Assert.AreEqual("This is Equilateral Triangle", output);
        }

        [Test]
        public void Analyze_inputSidesFromingScaleneTriangle_expectedScaleneTriangle()
        {
            int s1 = 4;
            int s2 = 3;
            int s3 = 5;
            string output = TriangleSolver.Analyze(s1, s2, s3);
            Assert.AreEqual("This is Scalene Triangle", output);
        }
        [Test]
        public void Analyze_inputSidesFromingIsoscelesTriangle_expectedIsoscelesTriangle()
        {
            int s1 = 2;
            int s2 = 2;
            int s3 = 3;
            string output = TriangleSolver.Analyze(s1, s2, s3);
            Assert.AreEqual("This is Isosceles Triangle", output);
        }
        [Test]
        public void Analyze_inputSidesNegative_expectedNotATriangle()
        {
            int s1 = -8;
            int s2 = -6;
            int s3 = -2;
            string output = TriangleSolver.Analyze(s1, s2, s3);
            Assert.AreEqual("This is not a Triangle", output);
        }


        [Test]
        public void Analyze_inputSecondSide100_expectedNotATriangle()
        {
            int s1 = 1;
            int s2 = 100;
            int s3 = 3;
            string output = TriangleSolver.Analyze(s1, s2, s3);
            Assert.AreEqual("This is not a Triangle", output);
        }

    }
}
