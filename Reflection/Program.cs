using System;
using System.Reflection;

namespace IT6._2 {
    
    public class StringAttribute: Attribute {}
    class Student {
        public Student(string name, int age) {
            Name = name;
            Age = age;
        }

        [String]
        public string Name { get; set; } = "";

        public int Age { get; set; } = 0;

        public void Print() {
            Console.WriteLine("Имя студента: " + Name + ", возраст студента: " + Age);
        }
    }
    
    class Program {
        static void Main(string[] args) {
            Type student = Type.GetType("IT6._2.Student");

            Console.WriteLine("Конструкторы:");

            foreach(var constructor in student.GetConstructors()) {
                Console.WriteLine(constructor.Name);
            }

            Console.WriteLine("\nПоля:");

            foreach (var constructor in student.GetFields(/*BindingFlags.NonPublic | BindingFlags.Instance*/)) {
                Console.WriteLine(constructor.Name);
            }

            Console.WriteLine("\nМетоды");

            foreach (var constructor in student.GetMethods()) {
                Console.WriteLine(constructor.Name);
            }

            Console.WriteLine("\nСвойства");

            foreach (var constructor in student.GetProperties()) {
                Console.WriteLine(constructor.Name);
            }

            Console.WriteLine("\nЧлены класса с атрибутом String: ");

            foreach (var member in student.GetMembers()) {
                foreach (var attribute in member.GetCustomAttributes()) {
                    if (attribute is StringAttribute) {
                        Console.WriteLine(member.Name);
                    }
                }
            }

            Console.WriteLine("\n");

            MethodInfo method = student.GetMethod("Print", new Type[] {});

            Student student_class = new Student ( "Ivan", 25 ); 
            method.Invoke(student_class, new Object[] { });
        }
    }
}
