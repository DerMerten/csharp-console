using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConString {
    internal class Program {
        static void Main ( string [] args ) {

            //umgedrehtString( );
            //varName( );
            //dataParameter( );
            urlTopLevel( );




            void umgedrehtString () {
                Console.Clear( );
                Console.Write("\nGeben Sie eine Zeichenfolge ein: ");
                string input = Console.ReadLine( );
                char [] charsInput = input.ToCharArray( );
                Array.Reverse(charsInput);
                string output = new string(charsInput);
                Console.WriteLine("\nUmgedrehter Text: " + output);
                Console.ReadKey( );
            }

            void varName () {
                Console.Clear( );
                Console.Write("\nGeben Sie Ihren Vor- und Nachnamen und trennen Sie dies durch einen Komma: ");
                string input = Console.ReadLine( );
                string [] vollName = input.Split(',');
                if (vollName.Length == 2) {
                    string name = vollName [ 0 ].Trim( );
                    string vorname = vollName [ 1 ].Trim( );

                    string initial = name [ 0 ].ToString( ).ToLower( ) + vorname [ 0 ].ToString( ).ToLower( );

                    Console.WriteLine("\nName: " + name);
                    Console.WriteLine("\nVorname: " + vorname);
                    Console.WriteLine("\nInitialen: " + initial);
                }
                Console.ReadKey( );
            }

            void dataParameter () {
                Console.Clear( );
                Console.Write("\nGeben Sie den Dateiname ein: ");
                string input = Console.ReadLine( );
                Console.WriteLine(input + ".bak");
                Console.ReadKey( );
            }

            void urlTopLevel () {
                Console.Clear( );
                Console.Write("\nGeben Sie eine URL ein: ");
                string eingabe = Console.ReadLine( );

                if (!eingabe.StartsWith("http://%22/") && !eingabe.StartsWith("https://%22%29/")) {
                    eingabe = "http://" + eingabe;
                }
                Uri uri = new Uri(eingabe);

                string topLevelDomain = uri.GetLeftPart(UriPartial.Authority);

                Console.WriteLine("\nTop-Level-Domain: " + topLevelDomain);
                Console.ReadKey( );
            }
        }
    }
}
