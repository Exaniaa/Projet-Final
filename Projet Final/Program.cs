using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final
{
    class Program
    {
        static void Main(string[] args)
        {   
            int choix = 0;
            DateTime dateRecep = new DateTime(2018, 10, 22);
            Don don1 = new Don(dateRecep, "meuble", "C345", "Dumonnet", 0622334455, "Rue du Village", "");
           
            List<Don> Archives = new List<Don>();
            List<Don> Accepte = new List<Don>();

            choix = Don.Choix(don1);
            if (choix == 1)
                Accepte.Add(don1);
            else
                Archives.Add(don1);

            Console.ReadKey();
        }
    }
}
