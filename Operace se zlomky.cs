using System;

namespace ConsoleApp90 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Zlomky zapisujte ve tvaru: a/b");
            while (true) {
                try {
                    int citatelVysledny = 0, jmenovatelVysledny = 0;
                    Console.WriteLine("První zlomek:");
                    string prvniZlomek = Console.ReadLine();
                    int citatel1 = Convert.ToInt32(prvniZlomek.Substring(0, prvniZlomek.IndexOf('/')));
                    int jmenovatel1 = Convert.ToInt32(prvniZlomek.Substring(prvniZlomek.IndexOf('/') + 1, prvniZlomek.Length - Convert.ToString(citatel1).Length - 1));
                    Console.WriteLine("Druhy zlomek:");
                    string druhyZlomek = Console.ReadLine();
                    int citatel2 = Convert.ToInt32(druhyZlomek.Substring(0, druhyZlomek.IndexOf('/')));
                    int jmenovatel2 = Convert.ToInt32(druhyZlomek.Substring(druhyZlomek.IndexOf('/') + 1, druhyZlomek.Length - Convert.ToString(citatel2).Length - 1));
                    if (jmenovatel1 == 0 || jmenovatel2 == 0) {
                        Console.WriteLine("Nulou dělit nelze.");
                        continue;
                    }
                    Console.WriteLine("Zvolte operaci:");
                    string operand = Console.ReadLine();
                    switch (operand) {
                        case "+": soucet(); break;
                        case "-": rozdil(); break;
                        case "*": soucin(); break;
                        case "/": podil(); break;
                    }
                    void soucin() {
                        citatelVysledny = citatel1 * citatel2;
                        jmenovatelVysledny = jmenovatel1 * jmenovatel2;
                    }
                    void podil() {
                        citatelVysledny = citatel1 * jmenovatel2;
                        jmenovatelVysledny = jmenovatel1 * citatel2;
                    }
                    void soucet() {
                        citatelVysledny = citatel1 * jmenovatel2 + jmenovatel1 * citatel2;
                        jmenovatelVysledny = jmenovatel1 * jmenovatel2;
                    }
                    void rozdil() {
                        citatelVysledny = citatel1 * jmenovatel2 - jmenovatel1 * citatel2;
                        jmenovatelVysledny = jmenovatel1 * jmenovatel2;
                    }
                    int vetsiPrvek = (citatelVysledny > jmenovatelVysledny) ? citatelVysledny : jmenovatelVysledny;
                    for (int i = vetsiPrvek - 1; i > 1; i--) {
                        if (citatelVysledny % i == 0 && jmenovatelVysledny % i == 0) {
                            citatelVysledny /= i;
                            jmenovatelVysledny /= i;
                        }
                    }
                    if (jmenovatelVysledny == 1)
                        Console.WriteLine("(" + citatel1 + "/" + jmenovatel1 + ")" + operand + "(" + citatel2 + "/" + jmenovatel2 + ")" + "=" + citatelVysledny);
                    else
                        Console.WriteLine("(" + citatel1 + "/" + jmenovatel1 + ")" + operand + "(" + citatel2 + "/" + jmenovatel2 + ")" + "=" + citatelVysledny + "/" + jmenovatelVysledny);
                }
                catch (Exception) {
                    Console.WriteLine("Nastala chyba.");
                    continue;
                }
            }
        }
    }
}
