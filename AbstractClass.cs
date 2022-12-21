namespace MyNamespace
{
    public abstract class Figure
    {
        public double width, height, radius;
        public const float pi = 3.14f;

        public abstract double GetArea();
    }

    public class Rectangle : Figure
    {
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }

    }

    public class Circle : Figure
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return width * height;
        }
    }

    public class Cone : Figure
    {
        public Cone(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double GetArea()
        {
            return pi * radius * (radius + Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(height, 2)));
        }
    }


    class Test
    {
        static void Main(string[] args)
        {

           Rectangle figures1 = new Rectangle(10, 20);
           Circle figures2 = new Circle(10);
           Cone figures3 = new Cone(10, 20);

            Console.WriteLine("Area of Rectangle: " + figures1.GetArea());
            Console.WriteLine("Area of Circle: " + figures2.GetArea());
            Console.WriteLine("Area of Cone: " + figures3.GetArea());
        }
    }
}