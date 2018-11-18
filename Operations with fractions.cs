using System;

namespace ConsoleApp90 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter fractions in the following form: a/b");
            while (true) {
                try {
                    int numeratorResult = 0, denominatorResult = 0;
                    Console.WriteLine("First fraction:");
                    string firstFraction = Console.ReadLine();
                    int numerator1 = Convert.ToInt32(firstFraction.Substring(0, firstFraction.IndexOf('/')));
                    int denominator1 = Convert.ToInt32(firstFraction.Substring(firstFraction.IndexOf('/') + 1, firstFraction.Length - Convert.ToString(numerator1).Length - 1));
                    Console.WriteLine("Second fraction:");
                    string secondFraction = Console.ReadLine();
                    int numerator2 = Convert.ToInt32(secondFraction.Substring(0, secondFraction.IndexOf('/')));
                    int denominator2 = Convert.ToInt32(secondFraction.Substring(secondFraction.IndexOf('/') + 1, secondFraction.Length - Convert.ToString(numerator2).Length - 1));
                    if (denominator1 == 0 || denominator2 == 0) {
                        Console.WriteLine("You cannot divide by zero.");
                        continue;
                    }
                    Console.WriteLine("Choose operation ( [+] [-] [*] [/] ):");
                    string operand = Console.ReadLine();
                    switch (operand) {
                        case "+": addition(); break;
                        case "-": subtraction(); break;
                        case "*": multiplication(); break;
                        case "/": division(); break;
                    }
                    void multiplication() {
                        numeratorResult = numerator1 * numerator2;
                        denominatorResult = denominator1 * denominator2;
                    }
                    void division() {
                        numeratorResult = numerator1 * denominator2;
                        denominatorResult = denominator1 * numerator2;
                    }
                    void addition() {
                        numeratorResult = numerator1 * denominator2 + denominator1 * numerator2;
                        denominatorResult = denominator1 * denominator2;
                    }
                    void subtraction() {
                        numeratorResult = numerator1 * denominator2 - denominator1 * numerator2;
                        denominatorResult = denominator1 * denominator2;
                    }
                    int vetsiPrvek = (numeratorResult > denominatorResult) ? numeratorResult : denominatorResult;
                    for (int i = vetsiPrvek - 1; i > 1; i--) {
                        if (numeratorResult % i == 0 && denominatorResult % i == 0) {
                            numeratorResult /= i;
                            denominatorResult /= i;
                        }
                    }
                    if (denominatorResult == 1)
                        Console.WriteLine("(" + numerator1 + "/" + denominator1 + ")" + operand + "(" + numerator2 + "/" + denominator2 + ")" + "=" + numeratorResult);
                    else
                        Console.WriteLine("(" + numerator1 + "/" + denominator1 + ")" + operand + "(" + numerator2 + "/" + denominator2 + ")" + "=" + numeratorResult + "/" + denominatorResult);
                }
                catch (Exception) {
                    Console.WriteLine("Error.");
                    continue;
                }
            }
        }
    }
}
