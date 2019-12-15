using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleProj
{
    class CircleProj
    {
        static void Main(string[] args)
        {
            //The intergers for the rectangle
            double height, width;
            GetValues(out height, out width);
            double area = getArea(height, width);
            double perimeter = getPerimeter(height, width);
            DisplayResults(height, width, area, perimeter);
            Console.ReadKey();
        }

        static void GetValues(out double height, out double width)
        {
            //Enters values for height and width
            Console.Write("Enter the height: ");
            height = double.Parse(Console.ReadLine());
            Console.Write("Enter the width: ");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        //Calculates the area by mulitplying height and width
        static double getArea(double height, double width)
        {
            return height * width;
        }

        //Calculates Perimeter by adding the height and width x 2
        static double getPerimeter(double height, double width)
        {
            return (height + width) * 2.0;
        }

        //Displays the Area and Perimeter of the Rectangle
        static void DisplayResults(double height, double width, double area, double perimeter)
        {

            Console.WriteLine("Height: {0:F2}", height);
            Console.WriteLine("Width: {0:F2}", width);
            Console.WriteLine("Area: {0:F2}", area);
            Console.WriteLine("Perimeter: {0:F2}", perimeter);

            Console.ReadKey();
        }
    }
}

