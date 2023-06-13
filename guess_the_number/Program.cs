using System;

public class Program
{
    public static void Main()
    {

        Random random = new Random();
        int randomNumber = random.Next(1, 101);
        int userGuess;
        int numGuesses = 0;

        Console.WriteLine("Bienvenue");

        do
        {
            Console.Write("Veuillez entrer un nombre entre 1 et 100 : ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out userGuess))
            {
                numGuesses++;

                if (userGuess < randomNumber)
                {
                    Console.WriteLine("Le nombre à deviner est plus grand");
                }

                else if (userGuess > randomNumber)
                {
                    Console.WriteLine("Le nombre à deviner est plus petit");
                }
                else
                {
                    Console.WriteLine("Félicitation ! Vous avez deviné le nombre correctement en " + numGuesses + "coups.");
                }

            }
            else
            {
                Console.WriteLine("Veuillez entrer un nombre valide.");
            }

        } while (userGuess != randomNumber);

        Console.WriteLine("Merci d'avoir joué !");
        while (randomNumber != 1) { } // Pour eviter que l'application se ferme quand je trouve le numero à deviner.

    }
}







/*

    1. Tout d'abord, le programme commence par inclure la directive 'using System;'. Cela permet d'utiliser les fonctionnalités de base de C# 
        qui se trouvent dans l'esapce de noms 'System'.

    2. Ensuite, la classe principale du programme est définie avec le nom 'Program'. 

    3. A l'intérieur de la classe 'Program', la méthode 'Main()' est définie. C'est la méthode d'entrée du programme, et c'est là que l'exécution 
        du programme, et c'est là que l'exécution du programme commence.

    4. A l'intérieur de la méthod 'Main()', nous commencons par créer une instance de la classe 'Random' avec la ligne 'Random random = new Random();'. 
        Cela nous permettra de générer un nombre aléatoire plus tard dans le programme.

    5. Ensuite, nous déclarons trois variables: 'randomNumber' pour stocker le nombre aléatoire généré, 'userGuess' pour stocker la valeur devinée 
        par l'utilisateur, et 'numGuess' pour compter le nombre de coups utilisés. 

    6. Le programme affiche un message de bienvenue à l'utilisateur en utilisant 'Console.WritLine()'.

    7. Ensuite, nous entrons dans une boucle 'do-while'. Cette boucle continuera à demander à l'utilisateur d'entrer un nombre jusqu'à ce qu'il 
        devine correctement le nombre aléatoire. 

    8. A l'intérieur de la boucle, le programme demande à l'utilisateur d'entrer un nombre en utilisant 'Console.Write()' et 'Console.ReadLine()'. 
        L'entrée de l'utilisateur est stockée dans la variable 'userInput'.

    9. Ensuite on va utiliser 'int.TryParse()' pour vérifier si l'entrée de l'utilisateur peut etre convertie en un nombre entier. 
        Si c'est le cas, le nombre deviné est stocké dans la variable 'userGuess' et nous procédons à l'valuation du nombre. 

    10. Si le nombre deviné est inférieur au nombre aléatoire, le programme affiche le message "Le nombre à deviner est plus grand" en utilisant 
        Console.WriteLine().

    11. Si le nombre deviné est supérieur au nombre aléatoire, le programme affiche le message "Le nombre à deviner est plus petit" en utilisant 
        Console.WriteLine().

    12. Si le nombre deviné est égal au nombre aléatoire, le programme affiche un message de félicitations avec le nombre de coups utilisés 
        en utilisant Console.WriteLine().

    13. La boucle do-while continue tant que userGuess est différent de randomNumber, c'est-à-dire tant que l'utilisateur n'a pas deviné 
        le nombre correctement.

    14. Après la boucle, le programme affiche un message de remerciement à l'utilisateur en utilisant Console.WriteLine().

    Ce programme permet à l'utilisateur de deviner un nombre entre 1 et 100, en lui fournissant des indications pour 
        l'aider à se rapprocher du résultat, et en comptant le nombre de coups utilisés.

*/