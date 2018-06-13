using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53 {
    class Program {
        static void Main(string[] args) {
            while (true) {
                Console.WriteLine("Enter a number:");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter nth dergee of a numeral system:");
                int n = Convert.ToInt32(Console.ReadLine());
                string Output = "|";
                while (x > 0) {
                    Output += x % n + "|";
                    x /= n;
                }
                Console.WriteLine(Output.Reverse().ToArray());
            }
        }
    }
}
