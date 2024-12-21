using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // affichage 
            Console.Write("Veuillez saisir votre hauteur de sapin: ");
            int saisie = int.Parse(Console.ReadLine());

            // Obtenir la largeur de la console
            int largeurConsole = Console.WindowWidth;

            // Partie supérieure du sapin
            for (int n = 1; n <= saisie; n++)
            {
                // Largeur de la ligne actuelle (nombre d'étoiles) = (n * 2 - 1)
                int largeurSapin = n * 2 - 1;

                // Calculer l'offset pour centrer la ligne
                int offset = (largeurConsole - largeurSapin) / 2;

                // Positionner le curseur à l'offset calculé
                Console.SetCursorPosition(offset, Console.CursorTop);

                // Dessiner la ligne d'étoiles avec l'espacement adéquat
                for (int j = 1; j <= largeurSapin; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Partie du tronc
            int largeurTronc = 3;  // Largeur du tronc (fixe à 3)
            int centre = (largeurConsole - largeurTronc) / 2;  // Calculer l'offset pour le tronc

            // Dessiner le tronc, centré
            for (int n = 0; n < 3; n++)  // Hauteur du tronc (3 lignes)
            {
                // Positionner le curseur au bon endroit pour le tronc
                Console.SetCursorPosition(centre, Console.CursorTop);
                Console.WriteLine("|||");
            }






        }
    }
}
