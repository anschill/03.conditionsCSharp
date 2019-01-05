using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Rainy = true;
;
            /* if (rainy)
             {
                 Console.WriteLine("Bonjour, il pleut aujourd'hui, vous devriez prendre votre parapluie. Connard.");
             }

             else 
             {
                 Console.WriteLine("Bonjour, il ne pleut pas aujourd'hui, bonne journée.");
             }*/

            String message = Rainy ? "Slt, prends ton parapluie" : "C'est bon il pleut pas, tranquille";
            Console.WriteLine(message);
            Console.ReadKey();
        }

    }
}

