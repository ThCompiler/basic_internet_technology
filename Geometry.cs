using System;

namespace Geometry {
    abstract class GeometryShape : IComparable {
        public abstract double Space();

        public int CompareTo(object? obj) {
            if (obj == null) return 1;

            GeometryShape shape = obj as GeometryShape;

            if (shape != null) {
                return Space().CompareTo(shape.Space());
            }
            throw new ArgumentException("Object is not a GeometryShapee");
        }
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
        public double width { get; set; }
        public double heigth { get; set; }
    }

    class Square : Rectangle {
        public Square(double a)
            : base(a, a) { }

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
        public override string ToString() {
            return "radius = " + radius.ToString() + " space = " + Space().ToString();
        }

        public double radius { get; set; }

    }
}