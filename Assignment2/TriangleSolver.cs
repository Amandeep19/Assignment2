using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(int side1, int side2, int side3)
        {
            string output = "";
            
                if ((side1 + side2 > side3) && (side2 + side3 > side1) && (side3 + side1 > side2))
                {
                   
                    if (side1 == side2 || side2 == side3 || side3 == side1)
                    {
                        output = "This is Equilateral Triangle";
                    }
                    
                    if (side1 != side2 || side2 != side3 || side3 != side1)
                    {
                        output = "This is Scalene Triangle";
                    }
                   
                    if ((side1 == side2 && side1 != side3) || (side1 == side2 && side1 != side3) && (side2 == side3 && side2 != side1))
                    {
                        output = "This is Isosceles Triangle";
                    }
                }
                else
                {
                    output = "This is not a Triangle";
                }                    
                            
            return output;
        }
    }
}
