/*-------------------------------------------------------------------------------------------------
* Name: Marten Othman
*
* Funktion: Überarbeitung des ersten Programm
*-------------------------------------------------------------------------------------------------
*Parameter: keine
*-------------------------------------------------------------------------------------------------
* 24.09.2023
* -------------------------------------------------------------------------------------------------
*/
using System;

namespace ConErstesProgrammUeberarbeitet {
    internal class Program {
        static void Main ( string [] args ) {
            int input = chooseFromMenu( );
            switch ( input ) {
                case 1:
                     fahrenheitToCelcius( );
                     break;
                case 2: 
                     psToKW( );
                     break;
                case 3: 
                     areaRect();
                     break;
                case 4:
                     volumePyramid( );
                     break;
                case 5: 
                     surfaceCylinder( );
                     break;
            }
        }
        static void fahrenheitToCelcius () { 
            Console.Clear();
            Console.Write("Geben Sie die Grad in Fahrenheit ein: ");
            string input = Console.ReadLine();
            int inputInt = 0;

            try {
                inputInt = Convert.ToInt32(input);
            }
            catch (Exception) {
                Console.WriteLine("\nEingabe ist keine gültige Zahl!");
                backToMenu();
            }
            int result = (inputInt - 32) * 5 / 9;
            Console.WriteLine("\nErgebnis: " +  result + "° Celsius");
            backToMenu( );
        }
        static void psToKW () {
            Console.Clear( );
            Console.Write("Geben Sie die Leistung in PS ein: ");
            String input = Console.ReadLine();
            int inputInt = 0;

            try {
                inputInt = Convert.ToInt32(input);
            }
            catch (Exception) {
                Console.WriteLine("\nEingabe ist keine gültige Zahl!");
                backToMenu( );
            }

            double result = inputInt / 1.36;
            Console.WriteLine("\nErgebnis: " + result + " KW");
        }
        static void areaRect () { 
            Console.Clear();
            Console.Write("Geben Sie die Länge a ein: ");
        }
        static void volumePyramid () { 
        }
        static void surfaceCylinder () { 
        }
        static void backToMenu () {
            Console.WriteLine("\nDrücke eine Taste um zum Menu zurückzugekehren!");
            Console.ReadKey( );
            Console.Clear();
            Main(null);
        }
        static int chooseFromMenu() {
            Console.Write("\nWas möchtest du berechnen?" +
                                "\n1. Fahrenheit in Celcius" +
                                "\n2. PS in KW" +
                                "\n3. Fläche eines Rechteckes" +
                                "\n4. Volumen einer Pyramide" +
                                "\n5. Oberfläche eines Zylinders" +
                                "\n\nDeine Auswahl: ");
            string input = Console.ReadLine();

            try {
                return Convert.ToInt32(input);
            }
            catch (FormatException) {
                Console.WriteLine("\nDas ist keine gültige Zahl");
                backToMenu();
                return -1;
            }

        }
    }
}
