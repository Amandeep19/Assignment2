   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
    {
        class Program
        {
            public static int Userselection()
            {
                int ans;

                Console.WriteLine("1. Enter Triangle Dimensions");
                Console.WriteLine("2. Exit");
                do
                {
                    Console.Write("\nPlease select from the above option: ");
                } while ((!int.TryParse(Console.ReadLine(), out ans)) || ((ans != 1) && (ans != 2)));
            
                return ans;
            }

            public static int validateSide()
            {
                int side1, side2 , side3;
                string output = "";
                
                do
                {
                    Console.Write("\nPlease enter side 1 in integer: ");
                } while ((!int.TryParse(Console.ReadLine(), out side1)) || (side1 <0));

            do
            {
                Console.Write("\nPlease enter side 2 in integer: ");
            } while ((!int.TryParse(Console.ReadLine(), out side2)) || (side2 < 0));

            do
            {
                Console.Write("\nPlease enter side 3 in integer: ");
            } while ((!int.TryParse(Console.ReadLine(), out side3)) || (side3 < 0));


            output = TriangleSolver.Analyze(side1, side2, side3);
                if (output != "This is not a Triangle")
                {
                    Console.WriteLine("This is a Triangle");
                }
                Console.WriteLine(output);

                return 1;
            }

            static void Main(string[] args)
            {
                int flag = 0;
                int sides = 0;

                do
                {
                    do
                    {
                        flag = Userselection();
                    } while (flag == 0);

                    if (flag == 1)
                    {
                        do
                        {
                        sides = validateSide();
                        } while (sides == 0);
                    }
                    else if (flag == 2)
                    {
                        Environment.Exit(0);
                    }
                    } while (sides == 1);
            }
        }
    }

