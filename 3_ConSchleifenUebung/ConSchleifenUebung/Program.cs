/*-------------------------------------------------------------------------------------------------
* Name: Marten Othman
*
* Funktion: Schleifen Übung
*-------------------------------------------------------------------------------------------------
* Parameter: keine
*-------------------------------------------------------------------------------------------------
* 18.09.2023 erste Version
* -------------------------------------------------------------------------------------------------
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConSchleifenUebung {
    internal class Program {
        static void Main ( string [] args ) {
            A13( );
        }
        static void A4 () {
            int zeile, spalte;
            for (zeile = 20; zeile >= 1; zeile = zeile - 1) {
                for (spalte = 1; spalte <= zeile; spalte = spalte + 1) {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey( );
        }
        static void A5 () {
            Console.WriteLine("\nSchreibe wie groß n sein soll:");
            int inputN = Convert.ToInt32(Console.ReadLine( ));
            Console.WriteLine( );
            int Fakultaet = 1;
            for (int i = 1; i <= inputN; i++) {
                Fakultaet *= i;
            }
            Console.WriteLine("\n{0}! = {1}", inputN, Fakultaet);
            Console.ReadKey( );
        }

        static void A6 () {
            Console.WriteLine("\nGeben Sie die Basis ein: ");
            int inputBasis = Convert.ToInt32(Console.ReadLine( ));
            Console.WriteLine("\nGeben Sie die Exponente ein: ");
            int inputExpo = Convert.ToInt32(Console.ReadLine( ));
            int result = 1;
            for (int i = 2; i <= inputExpo; i++) {
                result = inputBasis * inputBasis;
            }
            Console.WriteLine("\nErgebnis: " + result);
            Console.ReadKey( );
        }
        static void A9a () {
            int numRows = 4;
            int numCols = 6;
            int currentValue = 1;

            for (int i = 0; i < numRows * numCols; i++) {
                Console.Write(currentValue + " ");
                currentValue++;

                if (currentValue % numCols == 1) {
                    Console.WriteLine( ); // Zeilenumbruch nach jeder Zeile
                }
            }
            Console.ReadKey( );
        }
        static void A9b () {
            int numRows = 4;
            int numCols = 6;
            int currentValue = 1;

            for (int i = 0; i < numRows; i++) {
                for (int j = 0; j < numCols; j++) {
                    Console.Write(currentValue + " ");
                    currentValue++;
                }
                Console.WriteLine( ); // Zum Zeilenumbruch nach jeder Zeile
            }
            Console.ReadKey( );
        }
        static void A13 () {
        
        }
    }
}
