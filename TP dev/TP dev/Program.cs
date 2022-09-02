using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_dev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CréerFiche();
        }

        static void CréerFiche()
        {
            ClassePerso laClasse;
            Race laRace;

            Console.WriteLine("Quel class Voulez vous?");
            string classdeperso = "barbare";//= Console.ReadLine();
            switch(classdeperso)
            {
                case "barbare":
                    laClasse = new barbare();
                    break;
                default:
                    laClasse = new barbare();
                    break;
                        
            }

            Console.WriteLine("Quel race Voulez vous?");
            string racedeperso = "test"; //= Console.ReadLine();
            switch (racedeperso)
            {
                case "elf":
                    laRace = new elf();
                    break;
                default:
                    laRace = new elf();
                    break;

            }

            perso monPerso = new perso(laRace, laClasse);

            monPerso.race.GetTest();

            Console.WriteLine(monPerso.race.GetTest().ToString());
            Console.ReadLine();
        }

    }
}
