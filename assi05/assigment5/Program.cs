using System;
namespace assigment5
{
    class Program
    {
        static void Main(string[] args)
        {

 
            polygon Square01 = new square(4,5);

            double Area = Square01.GetArea();
            double Perimeter = Square01.GetPerimeter();


            Console.WriteLine("Calculation of the Square:");

            Console.WriteLine("Area of the Square: "+ Area);
      
            Console.WriteLine("Perimeter of the Square "+Perimeter);

          
            polygon hexagon1 = new hexagon(5,7,8);
            double AreaHexagon = hexagon1.GetArea();


            double PerimeterHexagon = hexagon1.GetPerimeter();
            Console.WriteLine("Calculation of the Hexagon:");

            Console.WriteLine("Perimeter of the Hexagon"+ PerimeterHexagon);
            Console.WriteLine("Area of the Hexagon: "+ AreaHexagon);


            Console.ReadKey();

        }
    }
}
