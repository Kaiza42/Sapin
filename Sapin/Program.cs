using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ma variable random
            Random bouleDeNoel = new Random();
            // affichage 
            Console.Write("Veuillez saisir votre hauteur de votre sapin entre 1 a 30 : ");
            // saisie utilisateur convertie en type int, dans le contexte du sapin combien d'etage feras le sapin
            int saisie = int.Parse(Console.ReadLine());
            // Largeur de la console
            int consoleLargeur = Console.WindowWidth;
            // Hauteur de la console
            int consoleHauteur = Console.WindowHeight;
            //Les deux variable Vont me servirr pour que les flocon ne les touche pas 
            int largeurTronc = saisie / 3;
            int hauteurTronc = saisie / 3;
            //La fonction du sapin
            void Sapin()
                // test
            {
                // ce console clear sert a effacer le texte de saisie utilisateur 
                Console.Clear();
                // c'est un peu de la triche juste pour repousser le sapin un peu plus 
                Console.WriteLine("\n\n\n");
                //Les étage du sapin 
                for (int etage = 0; etage <= saisie; etage++)
                {
                    // calcul le nombre d'étoile par étage 
                    int largeurSapin = etage * 2 - 1;
                    // fait un calcul qui permet de centrer le sapin 
                    Console.SetCursorPosition((consoleLargeur - largeurSapin) / 2, Console.CursorTop);

                    // fait l'affichage des "feuille"
                    for (int feuille = 1; feuille <= largeurSapin; feuille++)
                    {
                        // ajout des boule de noel 1 chance sur 4 pour que sa soit une boule de noel
                        if (bouleDeNoel.Next(1, 100) < 25)
                        {
                            // condition pour la couleur des boule (souvent une histoire de boule...) 1 chance sur 2 pour la couleur 
                            if (bouleDeNoel.Next(1, 100) < 50)
                            {
                                //boule rouge
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            else
                            {
                                //boule vert 
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            //Affichage des boule
                            Console.Write("O");
                            // je reset la couleur Pour ne pas coloré mes feuille 
                            Console.ResetColor();
                        }
                        // Si il ne fait partie des heuruese elue comme boule de noel alors ce sont "feuille"
                        else
                        {
                            // affichage des "feuille"
                            Console.Write("*");
                        }
                    }
                    //saute une ligne a la fin du nombre de feuille voulue pour chaque étage.
                    Console.WriteLine();
                }
            }
            //la fonction du tronc
            void Tronc()
            {
                // j'ai mis sa car quand je toucher a saisie sa modifier le sapin pour eviter sa je la stock ailleurs 
                int saisieTronc = saisie;
                //Permet que un sapin de 30 etage ne se retrouve pas avec un tronc de 3 etage fixe
                saisieTronc /= 4;
                // fait le calcul pour centrer le sapin le -1 permet qu'il rentre dans le dernier etage du sapin
                // ce calcul ma beaucoup frustrer car je n'arriver pas a avancer car je ne le trouver pas
                Console.SetCursorPosition((consoleLargeur - 3) / 2, Console.CursorTop );
                // affiche le tronc centré
                for (int n = 0; n < saisieTronc; n++)
                {
                    // j'avais du mal a comprendre sa .. en gros si j'enleve celui ci le premier tronc seras centrer mais pas les suivant 
                    Console.SetCursorPosition((consoleLargeur - 3) / 2, Console.CursorTop);
                    //affichage du tronc
                    Console.WriteLine("|||");
                }
            }
            // fonction flocon
            void Flocon()
            {
                //Boucle qui fait aparaitre le nombre de flocon max a lecran
                for (int flocon = 0; flocon < 50; flocon++)
                {
                    // Permet que les flocon aparaisse sur une largeur aléatoire
                    int largeur = bouleDeNoel.Next(0, consoleLargeur);
                    // Permet que les flocon aparaisse sur une hauteur aléatoire
                    int hauteur = bouleDeNoel.Next(0, consoleHauteur);
                    // Applique l'affichage random des flocon 
                    Console.SetCursorPosition(largeur, hauteur);
                    // Afficher le flocon
                    Console.Write("*");
                }
            }
            // condition que 30 seras la hauteur max du sapin 
            if (saisie > 30)
            {
                //message d'erreure
                Console.WriteLine("Le sapin doit faire entre 1 a 30 de hauteur Merci de recomencer ");
            }
            // condition pas inférieur a 1
            else if (saisie < 1)
            {
                // message d'erreure 
                Console.WriteLine("Le sapin doit faire entre 1 a 30 de hauteur Merci de recomencer ");
            }
            //En gros si la saisie n'est pas filtrer Bah fait aparatre le sapin
            else
            {
                // Boucle infinie Pour faire aparaitre de nouveau et rafrachir le sapin
                while (true)
                {
                    // affichage de mes fonction
                    Sapin();
                    Tronc();
                    Flocon();
                    // delai de rafraichissement ralentie
                    Thread.Sleep(400);
                }

            }
        }
    }
}
