using System;
/*2. Write a C# program to create an abstract class Shape with abstract methods calculateArea()
 and calculatePerimeter(). 
Create subclasses Circle and Triangle that inherit the Shape class 
and implement the respective methods 
to calculate the area and perimeter of each shape.
*/

namespace InheritanceExamples
{
    public abstract class Shape
    {
        public abstract void calArea();
        public abstract void calPerimeter();
    }

    public class Circle : Shape
    {
        double r;
        double area;
        double perimeter;
        public Circle(double r) 
        {
            this.r = r;
        }
        public override void calArea()
        {
            area = 3.14 * r * r;
        }

        public override void calPerimeter()
        {
            perimeter = 2 * 3.14 * r;
        }

        public override string ToString()
        {
            return $"Area of circle : {area} \nPerimeter of Circle:{perimeter}";
        }
        

    }
    public class Triangle : Shape
    {
        double height,base1,width,area,perimeter;
        public Triangle(double height,double base1,double width)
        {
            this.height = height;
            this.base1 = base1;
            this.width = width;
        }
        public override void calArea()
        {
            area =(base1*height)/2;
        }

        public override void calPerimeter()
        {
            perimeter = height+base1+width;
        }

        public override string ToString()
        {
            return $"Area of Triangle : {area} \nPerimeter of Triangle:{perimeter}";
        }


    }
    public class Rectangle : Shape
    {
        double length;
        double width;
        double area;
        double perimeter;
       public Rectangle(double length,double width)
        {
            this.length = length;
            this.width = width;
        }
        public override void calArea()
        {
            area=length*width;
        }

        public override void calPerimeter()
        {
            perimeter = (length+width) * 2;
        }

        public override string ToString()
        {
            return $"Area of Rectangle : {area} Perimeter of Rectangle:{perimeter}";
        }

    }
}
