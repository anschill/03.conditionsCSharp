using System;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string password ;

            Console.WriteLine("Quel est votre identifiant ? ");
            login = Console.ReadLine();
            Console.WriteLine("Quel est votre mot de passe ?");
            password = Console.ReadLine();

            if (password != "fichtre" || login != "sacrebleu")
            {
                Console.WriteLine("Mauvais identifiant ou mauvais mot de passe");
            }
            else
            {
                Console.WriteLine("Bienvenue dans ton cul");
            }
        }
    }
}
