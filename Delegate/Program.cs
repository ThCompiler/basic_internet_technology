using System;

namespace IT6._1 {
    class Program {


        public delegate T Operation<T> (T a, T b);

        static public int Sum(int a, int b) {
            return a + b;
        }

        static public int DoOperation(int a, int b, Operation<int> operation) {
            return operation(a, b);
        }

        static public int DoOperationStandart(int a, int b, Func<int, int, int> operation) {
            return operation(a, b);
        } 


        static void Main(string[] args) {
            int a = 1;
            int b = 30;

            Console.WriteLine("Мой делегат: Делегат: " + DoOperation(a, b, Sum).ToString() + "\n" +
                                    "Лямбда: " + DoOperation(a, b, (int a, int b) => a + b).ToString());

            Console.WriteLine("Func: Делегат: " + DoOperationStandart(a, b, Sum).ToString() + "\n" +
                                    "Лямбда: " + DoOperationStandart(a, b, (int a, int b) => a + b).ToString());


        }
    }
}
