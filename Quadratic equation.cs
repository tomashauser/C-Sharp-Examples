using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp91 {
    class Program {
        static void Main(string[] args) {
            while (true) {
                try {
                    Console.WriteLine("Zadejte koeficienty kvadratické rovnice ax^2 + bx + c oddělené čárkou ve formě => a,b,c");
                    Console.WriteLine("Enter coefficients of a quadratic equation ax^2 + bx + c = 0 separated by comma => a,b,c");
                    string input = Console.ReadLine();
                    double a, b, c, root1, root2, rootRealPart, rootImaginaryPart;
                    a = Convert.ToDouble(input.Substring(0, input.IndexOf(',')));
                    input = input.Substring(input.IndexOf(',') + 1, input.Length - Convert.ToString(a).Length - 1);
                    b = Convert.ToDouble(input.Substring(0, input.IndexOf(',')));
                    c = Convert.ToDouble(input.Substring(input.IndexOf(',') + 1, input.Length - Convert.ToString(b).Length - 1));
                    double discriminant = b * b - 4 * a * c;
                    if (discriminant >= 0) {
                        root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                        root2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                        Console.WriteLine("x1 = " + root1 + ", x2 = " + root2);
                    }
                    else {
                        rootRealPart = (-b) / (2 * a);
                        rootImaginaryPart = (Math.Sqrt(Math.Abs(discriminant)) / (2 * a));
                        Console.WriteLine("x1 = " + rootRealPart + " + " + rootImaginaryPart + "i, x2 = " + rootRealPart + " - " + rootImaginaryPart + "i");
                    }
                }
                catch (Exception) {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}
