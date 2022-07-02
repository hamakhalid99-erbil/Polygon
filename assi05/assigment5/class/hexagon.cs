using System;
using System.Collections.Generic;
using System.Text;



   public  class hexagon:polygon
{

    public double Apothem{ get; set; }

 

    public override double GetArea()
    {
    


        double HexagonArea = GetPerimeter() * Apothem / 2;
      

        return HexagonArea;

    }



    public hexagon(Double NumberOfSides02, double LengthPerSides02, double     Aapothem) : base(NumberOfSides02, LengthPerSides02)
    {

        Apothem = Aapothem;


    }

   


}

