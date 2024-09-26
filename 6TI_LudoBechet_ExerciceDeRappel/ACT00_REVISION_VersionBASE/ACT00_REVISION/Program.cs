using System;

namespace ACT00_REVISION
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration des variables.... COMPLETER AVEC CE QUI MANQUE

            string rep;

            double c1 = 0;
            double c2 = 0;
            double c3 = 0;
            bool ok = false;
            string infos;

            MethodesDuProjet methodes = new MethodesDuProjet();

            Console.WriteLine("Testez les polygones !");
            //On recommence tant que désiré
            do
            {
                c1 = lireDouble(1);
                c2 = lireDouble(2);
                c3 = lireDouble(3);

                // ordonner les côtés => APPEL ORDONNECOTES
                methodes.OrdonneCotes(ref c1, ref c2, ref c3);
                // série de test (voir consignes)
                ok = methodes.Triangle(c1, c2, c3);

                if (ok)
                {
                    // préparation et affichage du résultat du test 'triangle' avec la procédure 'Affiche'
                    methodes.Affiche(ok, "c'est un triangle", out infos);
                    Console.WriteLine(infos);

                    // vérification équilatéral
                    ok = methodes.Equi(c1, c2, c3);

                    if (ok)
                    {
                        // préparation et affichage du résultat du test 'equilateral' avec la procédure 'Affiche'
                        methodes.Affiche(ok, "c'est un triangle equilateral", out infos);
                        Console.WriteLine(infos);


                    }
                    else
                    {

                        methodes.Affiche(ok, "ce n'est pas un triangle equilateral", out infos);
                        Console.WriteLine(infos);
                        // vérification triangle rectangle
                        ok = methodes.TriangleRectangle(c1, c2, c3);
                        if (ok)
                        {
                            // préparation et affichage du résultat positif du test 'rectangle' avec la procédure 'Affiche'
                            methodes.Affiche(ok, "le triangle est rectangle", out infos);
                            Console.WriteLine(infos);
                        }
                        else
                        {
                            // préparation et affichage du résultat négatif du test 'rectangle' avec la procédure 'Affiche'
                            methodes.Affiche(ok, "le triangle n'est pas rectangle", out infos);
                            Console.WriteLine(infos);

                            methodes.Isocele(c1, c2, c3, out ok);

                            if (ok)
                            {
                                methodes.Affiche(ok, "Le triangle est Isocèle", out infos);
                                Console.WriteLine(infos);
                            }
                            else
                            {
                                methodes.Affiche(ok, "Le triangle n'est pas Isocèle", out infos);
                                Console.WriteLine(infos);
                            }
                        }

                        
                    }
                }
                else // si ce n'est pas un triangle
                {
                    // préparation et affichage du résultat négataif du test 'triangle' avec la procédure 'Affiche'
                    methodes.Affiche(false, "triangle", out infos);
                    Console.WriteLine(infos);
                }
                // reprise ?
                Console.WriteLine("Voulez-vous tester un autre polygône ? (Tapez espace)");
                rep = Console.ReadLine();
            } while (rep == " ");
        }
        //Récupération d'une donnée fournie par l'utilisateur en 'double' : on suppose qu'il ne se trompe pas !
        static double lireDouble(int numeroCote)
        {
            double cote;
            Console.Write("Tapez la valeur du côté " + numeroCote + " : ");
            cote = double.Parse(Console.ReadLine());
            return cote;
        }
    }
}
