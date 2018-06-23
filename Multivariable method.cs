using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multivariable_Method {
    class Program {
        static Tuple<string, string> Multivariable_Method(int Input_1, int Input_2) {
            string Output_1 = (Input_1 % 2 == 0) ? "1: Even" : "1: Odd";
            string Output_2 = (Input_2 % 2 == 0) ? "2: Even" : "2: Odd";
            return Tuple.Create(Output_1, Output_2);
        }
        static void Main(string[] args) {
            var Parity = Multivariable_Method(1, 4); // Variable holding multivariable method outputs which can be later taken out as .Item
            Console.WriteLine(Parity.Item1 + " " + Parity.Item2);
        }
    }
}
