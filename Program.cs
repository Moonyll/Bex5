using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bex5
{
    class Program
    {
        static void Main(string[] args)
        {
        string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
        for (int i = 0; i < week.Length; i++) // week.Length > récupère l'indice du tableau
        Console.WriteLine(week[i]);

        }
    }
}
/* boucle while
int i = 0;
while (i> week.Lenght)
...
i++;*/
