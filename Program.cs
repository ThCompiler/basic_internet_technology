using System;
using System.Collections;
using System.Collections.Generic;
using SimpleStackProject;
using Geometry;
using System.Security.Cryptography.X509Certificates;

namespace IT2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            Rectangle rectangle = new Rectangle(23, 48.0);

            Square square = new Square(95);
            Round round = new Round(2);

            rectangle.Print();
            square.Print();
            round.Print();

            ArrayList arr = new ArrayList { rectangle, square, round };
            arr.Sort();

            Console.WriteLine("\nArray:");

            foreach(var el in arr) {
                Console.WriteLine(el.ToString());
            }

            List<GeometryShape> list = new List<GeometryShape> 
                                            { rectangle, square, round };
            list.Sort();

            Console.WriteLine("\nList:");

            foreach (var el in list) {
                Console.WriteLine(el.ToString());
            }

            SimpleStack<GeometryShape> stack = new SimpleStack<GeometryShape> 
                                                { rectangle, square, round };
            stack.Push(rectangle);
            stack.Push(round);
            stack.Pop();

            Console.WriteLine("\nStack:");

            foreach (var el in stack) {
                Console.WriteLine(el.ToString());
            }

            SparseMatrix.MatrixV3<GeometryShape> matrix 
                = new SparseMatrix.MatrixV3<GeometryShape>(3, 3, 3);

            matrix[0, 0, 0] = rectangle;
            matrix[1, 0, 0] = square;
            matrix[2, 0, 0] = round;

            Console.WriteLine("\nMatrix:");
            Console.WriteLine(matrix.ToString());
        }
    }
}
