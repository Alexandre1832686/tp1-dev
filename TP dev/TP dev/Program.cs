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
            Console.WriteLine("");
            Console.WriteLine("1- Dragonborn");
            Console.WriteLine("2- Dwarf"); 
            Console.WriteLine("3- Elf");
            Console.WriteLine("4- Gnome");
            Console.WriteLine("5- Half-Elf");
            Console.WriteLine("6- Halfling");
            Console.WriteLine("7- Half-Orc");
            Console.WriteLine("8- Humain");
            Console.WriteLine("9- Tiefling");


            string racedeperso = Console.ReadLine();
            switch (racedeperso)
            {
                case "1":
                    laRace = new Dragonborn();
                    break;
                case "2":
                    laRace = new Dwarf();
                    break;
                case "3":
                    laRace = new elf();
                    break;
                case "4":
                    laRace = new Gnome();
                    break;
                case "5":
                    laRace = new Half_Elf();
                    break;
                case "6":
                    laRace = new Halfling();
                    break;
                case "7":
                    laRace = new Half_Orc();
                    break;
                case "8":
                    laRace = new Humain();
                    break;
                case "9":
                    laRace = new Tiefling();
                    break;
                default:
                    laRace = new elf();
                    break;

            }

            perso monPerso = new perso(laRace, laClasse);

            

           
            


            Console.WriteLine("");
            Console.WriteLine("Coninuer?");
            Console.ReadLine();
            Console.Clear();

            Stats(monPerso);
            
        }

        private static void Stats(perso monPerso)
        {
            Console.WriteLine("|******************************|");
            Console.WriteLine("|  Remplissage des statistics  |");
            Console.WriteLine("|******************************|");

            Console.WriteLine("");

            


            for(int i = 0; i < monPerso.race.GetBonusRace().GetLength(1); i++)
            {
                Console.WriteLine("Bonus racial : " + monPerso.race.GetBonusRace()[0, 0 + i] + " + " + monPerso.race.GetBonusRace()[1, 0 + i]);

            }

            Console.WriteLine("");
            Console.WriteLine("");

            int bonusStrength =0;
            for(int i=0;i< monPerso.race.GetBonusRace().GetLength(1); i++)
            {
                if (monPerso.race.GetBonusRace()[1, i] == "Strength")
                {
                    bonusStrength = int.Parse(monPerso.race.GetBonusRace()[0, i]);
                }

            }
            int bonusDexterity = 0;
            for (int i = 0; i < monPerso.race.GetBonusRace().GetLength(1); i++)
            {
                if (monPerso.race.GetBonusRace()[1, i] == "Dexterity")
                {
                    bonusDexterity = int.Parse(monPerso.race.GetBonusRace()[0, i]);
                }
            }
            int bonusConstitution = 0;
            for (int i = 0; i < monPerso.race.GetBonusRace().GetLength(1); i++)
            {
                if (monPerso.race.GetBonusRace()[1, i] == "Constitution")
                {
                    bonusConstitution = int.Parse(monPerso.race.GetBonusRace()[0, i]);
                }
            }
            int bonusIntelligence = 0;
            for (int i = 0; i < monPerso.race.GetBonusRace().GetLength(1); i++)
            {
                if (monPerso.race.GetBonusRace()[1, i] == "Intelligence")
                {
                    bonusIntelligence = int.Parse(monPerso.race.GetBonusRace()[0, i]);
                }
            }
            int bonusWisdom = 0;
            for (int i = 0; i < monPerso.race.GetBonusRace().GetLength(1); i++)
            {
                if (monPerso.race.GetBonusRace()[1, i] == "Wisdom")
                {
                    bonusWisdom = int.Parse(monPerso.race.GetBonusRace()[0, i]);
                }
            }
            int bonusCharisma = 0;
            for (int i = 0; i < monPerso.race.GetBonusRace().GetLength(1); i++)
            {
                if (monPerso.race.GetBonusRace()[1, i] == "Charisma")
                {
                    bonusCharisma = int.Parse(monPerso.race.GetBonusRace()[0, i]);
                }
            }

            monPerso.Strength = LancerPourStats() + bonusStrength;
            monPerso.Dexterity = LancerPourStats() + bonusDexterity;
            monPerso.Constitution = LancerPourStats() + bonusConstitution;
            monPerso.Intelligence = LancerPourStats() + bonusIntelligence;
            monPerso.Wisdom = LancerPourStats() + bonusWisdom;
            monPerso.Charisma = LancerPourStats() + bonusCharisma;

            Console.WriteLine("\t PV : " + ((monPerso.Constitution -10) / 2 +" "+ De.lancerDe(8)));
            Console.WriteLine("\t Strength : " + monPerso.Strength );
            Console.WriteLine("\t Dexterity : " + monPerso.Dexterity);
            Console.WriteLine("\t Constitution : " + monPerso.Constitution);
            Console.WriteLine("\t Intelligence : " + monPerso.Intelligence);
            Console.WriteLine("\t Wisdom : " + monPerso.Wisdom);
            Console.WriteLine("\t Charisma : " + monPerso.Charisma);

            Console.ReadLine();
        }

        static int LancerPourStats()
        {

            int nb1 = De.lancerDe(6);
            int nb2 = De.lancerDe(6);
            int nb3 = De.lancerDe(6);
            int nb4 = De.lancerDe(6);

            if (nb1 < nb2 && nb1 < nb3 && nb1 < nb4)
            {
                int nb = (nb2 + nb3 + nb4);
                return nb;
            }
            else if (nb2 < nb3 && nb2 < nb4)
            {
                int nb = (nb1 + nb3 + nb4);
                return nb;
            }
            else if (nb3 < nb4)
            {
                int nb = (nb1 + nb2 + nb4);
                return nb;
            }
            else
            {
                int nb = (nb1 + nb2 + nb3);
                return nb;
            }
        }

    }

    
    
}
