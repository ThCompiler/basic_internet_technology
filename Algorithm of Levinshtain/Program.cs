using System;
using CompareString;

namespace IT5 {
    class Program {
        static void Main(string[] args) {
            string s1 = "H";
            string s2 = "Helol";
            long a = MyEqualerString.LevenshteinDistance(s1, s2);
            Console.WriteLine("Hello World!");
        }
    }
}
