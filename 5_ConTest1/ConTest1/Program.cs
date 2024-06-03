using System;
using System.ComponentModel.Design;

namespace ConTest1 {


    internal class Program {
        static void Main ( string [] args ) {
            Console.Clear();
            Console.Write("\nBitte geben Sie den Radius ein: ");
            int inputRadius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nA –> Flächeninhalt" +
                                "\nU -> Umfang" +
                                "\n\nBitte wählen Sie (A, U): ");
            string inputChoise = Console.ReadLine();
            switch ( inputChoise ) {
                case "A":
                      Console.Clear();
                      double areaCir = Math.PI * (inputRadius * inputRadius);
                      Console.WriteLine("\nFlächinhalt beträgt: " +  areaCir);
                Console.ReadKey();
                Main(null);
                break;
                case "U":
                      Console.Clear( );
                      double scopeCir = 2 * Math.PI * inputRadius;
                      Console.WriteLine("\nUmfang beträgt: " + scopeCir);
                Console.ReadKey( );
                Main(null);
                break;
            }
        }
    }
}
