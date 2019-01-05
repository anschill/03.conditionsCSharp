using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5
{
    class Program
    {
        static void Main(string[] args)
        {

            NameValueCollection fujita = new NameValueCollection();  // Création d'un tableau associatif

            fujita.Add("F0", "Dégâts légers : certains dommages sont subis par les cheminées, les antennes de télévision, les bardeaux, les arbres, les enseignes et les fenêtres.");
            fujita.Add("F1", "Dégâts modérés : les automobiles sont renversées, les abris pour automobiles détruits et les arbres déracinés.");
            fujita.Add("F2", "Dégâts importants : les toits sont arrachés par le vent, les hangars et les dépendances sont démolies et les maisons mobiles sont renversées.");
            fujita.Add("F3", "Dégâts considérables : les murs extérieurs et les toits sont projetés dans les airs, les maisons et les bâtiments de métal s'effondrent ou subissent des dégâts");
            fujita.Add("F4", "Dégâts dévastateurs : même dans les habitations solides, l'essentiel des murs, sinon tous, s'effondrent ; tels des missiles, de gros objets en acier ou en béton sont projetés à grandes distances.");
            fujita.Add("F5", "Dégâts incroyables: lesmaisonssont rasées ou projetées sur de grandes distances.Les tornades F5 peuvent causer des dommages très importants à de grosses structures telles que les écoles et les motels et peuvent arracher les murs extérieurs et les toits(parfois surnommé « le doigt de Dieu ».");

            Console.WriteLine("Renseigner le type de tornade entre F0  & F5");
            String type = Console.ReadLine(); //Recherche des degats d'une tornade
            if (type == "F0")
                Console.WriteLine(fujita["F0"]);
            else if (type == "F1")
                Console.WriteLine(fujita["F1"]);
            else if (type == "F2")
                Console.WriteLine(fujita["F2"]); 
            else if (type == "F3")
                Console.WriteLine(fujita["F3"]);
            else if (type == "F4")
                Console.WriteLine(fujita["F4"]);
            else if (type == "F5")
                Console.WriteLine(fujita["F5"]);
             else
                Console.WriteLine("Ce type n'existe pas ");








        }

    }

}
