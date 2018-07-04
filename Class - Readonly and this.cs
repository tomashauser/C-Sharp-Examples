using System;

namespace ConsoleApp70 {
    class Dog {
        public readonly string Name = "Dog";
        public Dog(string Name) {
            this.Name = Name; // We can assign a "string Name" value to the "Name" variable, which is declared outside of constructor.
        }
    }
    class Program {
        static void Main(string[] args) {
            Dog Rex = new Dog("Rex");
            Console.WriteLine(Rex.Name);
            // Output: Rex
        }
    }
}
