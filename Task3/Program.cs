using System;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            Figure figure = new Square(5);
            figure.ShowInfo();

            double figureArea = figure.Area();

            Figure figure1 = new Circle(5);
            figure1.ShowInfo();

            double figure1Area = figure1.Area();

            Figure figure2 = new Cube(5);
            figure2.ShowInfo();

            double figure2Area = figure2.Area();
            double figure2Volume = figure2.Volume();

            Figure figure3 = new Sphere(5);
            figure3.ShowInfo();

            double figure3Area = figure3.Area();
            double figure3Volume = figure3.Volume();

            VolumeComparer volume = new();
            AreaComparer area = new();

            Console.WriteLine((area.CompareFigureArea(figure1Area, figure2Area)).ToString());
            Console.WriteLine((volume.CompareFigureVolume(figure2Volume, figure3Volume)).ToString());
        }
    }
    abstract class Figure
    {
        public abstract double Area();
        public abstract double Volume();
        public abstract double Perimeter();
        public abstract string ShapeName();

        public void ShowInfo()
        {
            Console.WriteLine(
                $"Nazwa figury: {ShapeName()}\n" + $"Powierzchnia: {Area()}\n" + $"Objętość: {Volume()}\n" + $"obwód figury: {Perimeter()}");
            Console.WriteLine();
        }
    }

    class Square : Figure
    {
        double side;

        public Square(double squareSide)
        {
            Side = squareSide;
        }

        public double Side
        {
            get { return side; }
            set { side = value < 0 ? -value : value; }
        }

        public override double Area()
        {
            return (side * side);
        }

        public override double Perimeter()
        {
            return (side * 4);
        }

        public override double Volume()
        {
            return 0;
        }

        public override string ShapeName()
        {
            return "Kwadrat";
        }
    }

    class Circle : Figure
    {
        double radius;

        public Circle(double circleRadius)
        {
            radius = circleRadius;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value < 0 ? -value : value; }
        }

        
        public override double Area()
        {
            return (Math.PI * radius * 2);
        }

        public override double Perimeter()
        {
            return (Math.PI * radius * radius);
        }

        public override double Volume()
        {
            return 0;
        }

        public override string ShapeName()
        {
            return "koło";
        }
    }

    class Cube : Figure
    {
        double edgeLength;

        public Cube(double EdgeLength)
        {
            edgeLength = EdgeLength;
        }

        public double EdgeLength
        {
            get { return edgeLength; }
            set { edgeLength = value < 0 ? -value : value; }
        }


        public override double Area()
        {
            return (6 * EdgeLength * EdgeLength);
        }

        public override double Perimeter()
        {
            return (12 * EdgeLength);
        }

        public override double Volume()
        {
            return (EdgeLength * EdgeLength * EdgeLength);
        }

        public override string ShapeName()
        {
            return "sześcian";
        }
    }

    class Sphere : Figure
    {
        double radius;

        public Sphere(double circleRadius)
        {
            radius = circleRadius;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value < 0 ? -value : value; }
        }


        public override double Area()
        {
            return (4 * Math.PI * (radius * radius));
        }

        public override double Perimeter()
        {
            return 2 * radius;
        }

        public override double Volume()
        {
            return (4 * Math.PI * (radius * radius * radius) / 3);
        }

        public override string ShapeName()
        {
            return "Kula";
        }
    }

    class AreaComparer
    {
        public string CompareFigureArea(double a, double b)
        {
            if (a > b)
                return "-1";
            if (b > a)
                return "1";
            else
                return "0";
        }
    }

    class VolumeComparer
    {
        public string CompareFigureVolume(double a, double b)
        {
            if (a > b)
                return "-1";
            if (b > a)
                return "1";
            else
                return "0";
        }

    }
}
