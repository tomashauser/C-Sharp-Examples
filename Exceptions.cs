using System;

namespace MultipleExceptions {
    class Program {
        enum TrafficLights { Green, Red, Yellow };
        static void Main(string[] args) {
            int x, y;
            try {
                x = Convert.ToInt32(Console.Read());
                y = Convert.ToInt32(Console.Read());
                Console.WriteLine(x / y);
            }
            catch (DivideByZeroException e) {
                Console.WriteLine("Cannot divide by 0");
            }
            catch (Exception e) {
                Console.WriteLine("An error occurred");
            }
            // Code is from sololearn.com.
        }
    }
}
