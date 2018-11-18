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
                    Console.WriteLine("Zadejte koeficienty kvadratické rovnice ax^2 + bx + c = 0 oddělené čárkou ve formě => a,b,c");
                    string input = Console.ReadLine();
                    double a, b, c, koren1, koren2, korenRealnaCast, korenImaginarniCast;
                    a = Convert.ToDouble(input.Substring(0, input.IndexOf(',')));
                    input = input.Substring(input.IndexOf(',') + 1, input.Length - Convert.ToString(a).Length - 1);
                    b = Convert.ToDouble(input.Substring(0, input.IndexOf(',')));
                    c = Convert.ToDouble(input.Substring(input.IndexOf(',') + 1, input.Length - Convert.ToString(b).Length - 1));
                    double diskriminant = b * b - 4 * a * c;
                    if (diskriminant >= 0) {
                        koren1 = (-b + Math.Sqrt(diskriminant)) / (2 * a);
                        koren2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                        Console.WriteLine("x1 = " + koren1 + ", x2 = " + koren2);
                    }
                    else {
                        korenRealnaCast = (-b) / (2 * a);
                        korenImaginarniCast = (Math.Sqrt(Math.Abs(diskriminant)) / (2 * a));
                        Console.WriteLine("x1 = " + korenRealnaCast + " + " + korenImaginarniCast + "i, x2 = " + korenRealnaCast + " - " + korenImaginarniCast + "i");
                    }
                }
                catch (Exception) {
                    Console.WriteLine("Nastala chyba.");
                }
            }
        }
    }
}
