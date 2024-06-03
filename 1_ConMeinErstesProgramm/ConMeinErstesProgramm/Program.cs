/*-------------------------------------------------------------------------------------------------
* Name: Marten Othman
*
* Funktion: Rechner von vielen Sachen
*-------------------------------------------------------------------------------------------------
* Parameter: keine
*-------------------------------------------------------------------------------------------------
* 14.08.2023 erste Version
* -------------------------------------------------------------------------------------------------
*/

using System;

namespace ConMeinErstesProgramm {
    class Program {
        static void Main ( string [] args ) {
            Console.Write("\nWas möchtest du berechnen?" + 
                                "\n1. Fahrenheit in Celcius" + 
                                "\n2. PS in KW" +
                                "\n3. Fläche eines Rechteckes" +
                                "\n4. Volumen einer Pyramide" +
                                "\n5. Oberfläche eines Zylinders" +
                                "\n\nDeine Auswahl: ");

            try {
                int input = Convert.ToInt32(Console.ReadLine( ));
                Console.WriteLine( );


                if (input == 1) {
                    Console.Clear( );
                    Console.Write("Geben Sie die Grad in Fahrenheit ein: ");
                    int f = Convert.ToInt32(Console.ReadLine( )); ; //speichert die Temperatur als Fahrenheit
                    int c = (f - 32) * 5 / 9; //speichert die Temperatur als Celcius
                    Console.Write($"{f}° Fahrenheit =  {c}° Celcius.");
                    Console.ReadKey( );
                    Console.Clear( );
                    Main(null);
                }
                else if (input == 2) {
                    Console.Clear( );
                    Console.Write("Geben Sie die Leistung in PS ein: ");
                    int PS = Convert.ToInt32(Console.ReadLine( ));
                    double KW = (PS / 1.36);
                    Console.Write($"{PS} PS sind = {KW} KW.");
                    Console.ReadKey( );
                    Console.Clear( );
                    Main(null);
                }
                else if (input == 3) {
                    Console.Clear( );
                    Console.Write("Geben Sie die Länge a ein: ");
                    int lA = Convert.ToInt32(Console.ReadLine( ));
                    Console.Write("Gebenn Sie die Breite b ein: ");
                    int bB = Convert.ToInt32(Console.ReadLine( ));
                    int A = lA + bB; // Fläche Recheck
                    Console.WriteLine($"Die Fläche beträgt {A}.");
                    Console.ReadKey( );
                    Console.Clear( );
                    Main(null);
                }
                else if (input == 4) {
                    Console.Clear( );
                    Console.Write("Geben Sie die Länge der Grundfläche ein: ");
                    double lG = Convert.ToInt32(Console.ReadLine( ));
                    Console.Write("Geben Sie die Breite der Grundfläche ein: ");
                    double bG = Convert.ToInt32(Console.ReadLine( ));
                    Console.Write("Geben Sie die Höhe der Pyramide ein: ");
                    double hP = Convert.ToInt32(Console.ReadLine( ));
                    double gF = lG * bG; //Grundfläche
                    double vP = (gF * hP) / 3; //Volumen Pyramide
                    Console.WriteLine($"Das Volumen der Pyramide beträgt: {vP}.");
                    Console.ReadKey( );
                    Console.Clear( );
                    Main(null);
                }
                else if (input == 5) {
                    Console.Clear( );
                    Console.Write("Geben Sie den Radius der Grundfläche ein: ");
                    double rG = Convert.ToInt32(Console.ReadLine( ));
                    Console.Write("Geben Sie die Höhe des Zylinders ein: ");
                    double zH = Convert.ToInt32(Console.ReadLine( ));
                    double gF = Math.PI * rG * rG; //Grundfläche
                    double mF = 2 * Math.PI * rG * zH; //Mantelfläche
                    double oZ = 2 * gF + mF; // Oberfläche Zylinder
                    Console.WriteLine($"Die Oberfläche des Zylinders beträgt: {oZ}.");
                    Console.ReadKey( );
                    Console.Clear( );
                    Main(null);
                }
            }
            catch (Exception ex) {
                Console.WriteLine (ex.Message);
                Console.WriteLine("Drücken Sie eine Taste um zu neustarten");
                Console.ReadKey( );
                Console.Clear ();
                Main(null);
                return;
            }
        }
    }
}
