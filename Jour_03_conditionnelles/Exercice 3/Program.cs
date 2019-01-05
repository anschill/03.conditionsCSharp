using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string sexe;

            Console.WriteLine("Quel âge avez-vous ?");
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Etes vous un \"homme\" ou une \"femme\" ?");
            sexe = Console.ReadLine();

            if (sexe == "homme" || sexe == "un homme")
            {
                if (age < 18 && age > 0)
                {
                    Console.WriteLine("Vous êtes un homme et vous êtes mineur");
                }
                else if (age > 18)
                {
                    Console.WriteLine("Vous êtes un homme et vous êtes majeur");
                }
                else
                    Console.WriteLine("erreur");
            }
            else if ( sexe == "femme" || sexe ==  "une femme")
            
                if (age < 18 && age > 0)
                {
                    Console.WriteLine("Vous êtes une femme et vous êtes mineure.");
                }
                else if (age > 18)
                {
                    Console.WriteLine("Vous êtes une femme et vous êtes majeure.");
                }
            else
            {
                Console.WriteLine("erreur");
            }

        }
    }
}

/* String login = "lbh", login2, mdp = "123", mdp2;
 * Console.WriteLine("Login");
 * login2 = Console.ReadLine();
 * Console.WRiteLine("mdp");
 * mdp2 = Console.ReadLine();
 * if (login.Equals(login2) && mdp == mdp2 )
 * {
 *  Console.WriteLine("Bienvenue à La Manu Le Havre !");
 * }
 * else
 *  Console.WriteLine("Mauvais identifiant ou mauvais mot de passe !");
 *  Console.ReadKey();*/