using System;

namespace Enums {
    class Program {
        public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        static void Main(string[] args) {
            Console.WriteLine((int)Days.Tue + 1);
            // Output: 3
        }
    }
}
