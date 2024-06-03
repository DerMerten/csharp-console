/*-------------------------------------------------------------------------------------------------
* Name: Marten Othman
*
* Funktion: BMI-Rechner
*-------------------------------------------------------------------------------------------------
*Parameter: keine
*-------------------------------------------------------------------------------------------------
* 04.09.2023
* -------------------------------------------------------------------------------------------------
*/
using System;

namespace ConBMI_Rechner {
    internal class Program {
        static void Main ( string [] args ) {
            Console.WriteLine("\nBitte geben Sie Ihr Gewicht in Kilogramm ein: ");
            double weight = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("\nBitte geben Sie Ihre Größe in Metern ein: ");
            double height = Convert.ToDouble( Console.ReadLine());

            double bmi = weight / (height * height);

            if (bmi < 18) {
                Console.WriteLine("\nSie sind zu leicht. Ihr BMI beträgt: " + bmi);
            }
            else if (bmi > 25) {
                Console.WriteLine("\nSie sind zu schwer. Ihr BMI beträgt: " + bmi);
            } else {
                Console.WriteLine("\nSie sind normal. Ihr BMI beträgt: " + bmi);
            }
            Console.WriteLine("Ende und Tschüss");
            Console.ReadKey( );
            Console.Clear();
            Main(null);
        }
    }
}
