/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 3ACIF
 *--------------------------------------------------------------
 *				Daniel Binder
 *--------------------------------------------------------------
 * Description:
 * Shuffling three different words
 *--------------------------------------------------------------
*/

using System;

namespace WordShuffle
{
    class Program
    {
        public static void Main()
        {
            string word1,
                word2,
                word3;

            // Eingabe (E)
            Console.Write("Geben Sie das erste Wort ein: ");
            word1 = Console.ReadLine();
            Console.Write("Geben Sie das zweite Wort ein: ");
            word2 = Console.ReadLine();
            Console.Write("Geben Sie das dritte Wort ein: ");
            word3 = Console.ReadLine();

            // Verarbeitung (V)

            // Ausgabe (A)
            Console.WriteLine("");
            Console.WriteLine("Sechs gemischte Wortgruppen:");
            Console.WriteLine("");

            Console.WriteLine("{0, -15} {1, -15} {2, -15}", word1, word2, word3);
            Console.WriteLine("{0, -15} {2, -15} {1, -15}", word1, word2, word3);
            Console.WriteLine("{1, -15} {0, -15} {2, -15}", word1, word2, word3);
            Console.WriteLine("{1, -15} {2, -15} {0, -15}", word1, word2, word3);
            Console.WriteLine("{2, -15} {0, -15} {1, -15}", word1, word2, word3);
            Console.WriteLine("{2, -15} {1, -15} {0, -15}", word1, word2, word3);
        }
    }
}
