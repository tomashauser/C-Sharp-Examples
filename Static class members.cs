using System;

namespace ConsoleApp70 {
    class Dog {
        public static int NumberOfDogs = 0; // Static members belong to class, not to the individual objects.
        public Dog() { // When the class is initialized, add +1 to the NumberOfDogs.
            NumberOfDogs++;
        }
    }
    class Program {
        static void Main(string[] args) {
            Dog Rex = new Dog();
            Dog Jessie = new Dog();
            Dog Lassie = new Dog();
            Console.WriteLine(Dog.NumberOfDogs);
            // Output: 3
        }
    }
}
