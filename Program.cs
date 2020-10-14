using System;

namespace IT2 {
    
    abstract class GeometryShape {
        public abstract double Space(); 
    }

    interface IPrint {
        public void Print();
    }
    class Rectangle : GeometryShape, IPrint {
        public Rectangle(double a_width, double a_height) {
            width = a_width;
            heigth = a_height;
        }

        public override double Space() {
            return width * heigth;
        }

        public void Print() {
            Console.WriteLine("Restangle: " + ToString());
        }

        public override string ToString() {
            return "widht = " + width.ToString() + " height = " 
                + heigth.ToString() + " space = " + Space().ToString();
        }
        public double width {get; set;}
        public double heigth { get; set; }
    }

    class Square : Rectangle {
        public Square(double a) 
            : base(a, a) {}

        public new void Print() {
            Console.WriteLine("Square: " + ToString());
        }

        public override string ToString() {
            return "line = " + width.ToString() + " space = " + Space().ToString();
        }
    }

    class Round : GeometryShape, IPrint {
        public Round(double a_radius) {
            radius = a_radius;
        }

        public override double Space() {
            return Math.PI * radius * radius;
        }

        public void Print() {
            Console.WriteLine("Round: " + ToString());

        }
        public override string ToString()  {
            return "radius = " + radius.ToString() + " space = " + Space().ToString();
        }

        public double radius { get; set; }

    }
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            Rectangle rectangle = new Rectangle(23, 48.0);

            Square square = new Square(95);
            Round round = new Round(2);

            rectangle.Print();
            square.Print();
            round.Print();
        }
    }
}
