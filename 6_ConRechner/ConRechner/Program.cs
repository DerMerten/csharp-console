using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConRechner {
    internal class Program {
        static void Main ( string [] args ) {
            string eingabe;
            int result = 0;

            do {
                Console.Clear( );

                Console.WriteLine("\nEinfacher Rechner" +
                                  "\n-----------------" +
                                  "\nBitte geben Sie +, -, *, / und x:" +
                                  "\n(+) für addieren" +
                                  "\n(-) für subtrahieren" +
                                  "\n(*) für multiplizieren" +
                                  "\n(/) für dividieren" +
                                  "\n(x) Programm beenden");

                eingabe = Console.ReadLine( );

                switch (eingabe) {
                    case "+":
                        cacuPlus( );
                        break;
                    case "-":
                        cacuMinus( );
                        break;
                    case "*":
                        cacuMulti( );
                        break;
                    case "/":
                        cacuDivide( );
                        break;
                    case "x":
                        Console.WriteLine("Programm beendet!");
                        break;
                    default:
                        break;
                }
            }
            while (eingabe != "x");

            void cacuPlus () {
                Console.Clear( );
                Console.WriteLine("\nGeben Sie die 1. Zahl die Sie addierren wollen: ");
                int num1 = Convert.ToInt32(Console.ReadLine( ));
                Console.WriteLine("\nGeben Sie die 2. Zahl die Sie addierren wollen: ");
                int num2 = Convert.ToInt32(Console.ReadLine( ));
                result = num1 + num2;
                Console.WriteLine("\nDas Ergebnis ist " + result);
                Console.ReadKey( );
                Main(null);
            }

            void cacuMinus () {
                Console.Clear( );
                Console.WriteLine("\nGeben Sie die 1. Zahl die Sie subtrahieren wollen: ");
                int num1 = Convert.ToInt32(Console.ReadLine( ));
                Console.WriteLine("\nGeben Sie die 2. Zahl die Sie subtrahieren wollen: ");
                int num2 = Convert.ToInt32(Console.ReadLine( ));
                result = num1 - num2;
                Console.WriteLine("\nDas Ergebnis ist " + result);
                Console.ReadKey( );
                Main(null);
            }

            void cacuMulti () {
                Console.Clear( );
                Console.WriteLine("\nGeben Sie die 1. Zahl die Sie multiplizieren wollen: ");
                int num1 = Convert.ToInt32(Console.ReadLine( ));
                Console.WriteLine("\nGeben Sie die 2. Zahl die Sie multiplizieren wollen: ");
                int num2 = Convert.ToInt32(Console.ReadLine( ));
                result = num1 * num2;
                Console.WriteLine("\nDas Ergebnis ist " + result);
                Console.ReadKey( );
                Main(null);
            }

            void cacuDivide () {
                Console.Clear( );
                Console.WriteLine("\nGeben Sie die 1. Zahl die Sie dividieren wollen: ");
                int num1 = Convert.ToInt32(Console.ReadLine( ));
                Console.WriteLine("\nGeben Sie die 2. Zahl die Sie dividieren wollen: ");
                int num2 = Convert.ToInt32(Console.ReadLine( ));
                result = num1 / num2;
                Console.WriteLine("\nDas Ergebnis ist " + result);
                Console.ReadKey( );
                Main(null);
            }


        }
    }
}
