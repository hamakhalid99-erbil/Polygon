using System;
using System.Collections.Generic;
using System.Text;




   public class square : polygon
{




    public override double GetArea()
    {
    
          double Area = LengthPerSides * LengthPerSides;




        return Area;

    }

  

    public square(double NumberOfSides03, double LengthPerSides03) : base(NumberOfSides03,LengthPerSides03)
    {



    }


}

