using System;
using System.Collections.Generic;
using System.Text;


   public abstract class polygon
{
    public double NumberOfSides;
    public double LengthPerSides;



    public abstract double GetArea();
    
     

 


    public virtual double GetPerimeter()
    {

        double perimeter= NumberOfSides* LengthPerSides; ;
        return perimeter;


    }

    protected  polygon(double NumberOftheSides01, double LengthPerSides01)
    {
        NumberOfSides = NumberOftheSides01;
        LengthPerSides = LengthPerSides01;

        


    }
    





    



}

