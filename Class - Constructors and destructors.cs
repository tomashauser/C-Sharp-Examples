using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp70 {
    class Dog {
        public Dog() {
            Console.WriteLine("Constructor.");
        }
        ~Dog() {
            Console.WriteLine("Destructor.");
        }
    }
    class Program {
        static void Main(string[] args) {
            Dog Rex = new Dog();
            for (int i = 0; i <= 10; i++) {
                Console.WriteLine(i);
            }
            Console.WriteLine("_____________");
        }
    
