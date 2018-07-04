using System;

namespace ConsoleApp70 {
    class Dog {
        string[] Names = new string[1729]; // Declare an array.
        public string this[int Index] {    // Must memorize.
            get {
                return Names[Index];       // Return name on current Index.
            }
            set {
                Names[Index] = value;      // "value" is a c# word!
            }
        }
    }
    class Program {
        static void Main(string[] args) {
            Dog ListOfDogs = new Dog();
            ListOfDogs[0] = "Rex";         // Now, we are able to work with class via indexes.
            ListOfDogs[1] = "Lassie";
            ListOfDogs[2] = "Jessie";
            Console.WriteLine(ListOfDogs[0]);
            Console.WriteLine(ListOfDogs[1]);
            Console.WriteLine(ListOfDogs[2]);
            /* Output: Rex
             *         Lassie
             *         Jessie
             */
        }
    }
}
