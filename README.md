# Polygon
A console Application in C#

## Polygon Class
a Polygon class which contains two properties: number of sides and length per side. 
It also includes two methods: GetPerimeter and GetArea. 

The GetPerimeter method can be overriden by derived classes. The default calculation is Number of sides * Length per side
The GetArea must be implemented in each derived class. 

a protected constructor which accepts two parameters: number of sides and length per side; assign them to the corresponding properties
a Square class which inherits from Polygon class

a constructor with accepts both derived properties and assigns them to 
Area of square is length per side * length per side

## Hexagon
Hexagon class which inherits from Polygon class.

It includes an Apothem property

Area of Hexagon is Perimeter * Apothem / 2

a protected constructor which accepts three parameters: number of sides, length per side, and apothem;
call the parent constructor to pass the two inherited parameters and assign the apothem to the property
