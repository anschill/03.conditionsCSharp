using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
          int age;
        
          Console.WriteLine("Indiquez votre âge en chiffres.");

          int.TryParse(Console.ReadLine(), out age);

        if (age < 18 && age < 0)
            {
                Console.WriteLine("Vous avez " + age + " ans, vous êtes donc mineur.");
            }
        else if (age >= 18)
            {
             Console.WriteLine("Vous avez " + age + " ans, vous êtes donc majeur.");
             }
        else
            {
                Console.WriteLine("C'est pas un vrai âge !");
            }
       }
    }
}
