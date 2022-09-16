using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TP_dev
{
    static public class traitementExtrene
    {

        
        public static perso GetPerso( string nom)
        {
            string ligne;
            string[] stat = new string[12];
            using (StreamReader sr = new StreamReader("../../../perso.csv"))
            {
                sr.ReadLine();

                while ((ligne = sr.ReadLine()) != null)
                {
                    string[] tempstat = ligne.Split(',');

                    if (tempstat[0]==nom)
                    {
                        stat = ligne.Split(',');
                    }
                }
            }

            ClassePerso laClasse;
            Race laRace;

            switch (stat[1])
            {
                case "1":
                    laClasse = new barbare();
                    break;
                case "2":
                    laClasse = new Bard();
                    break;
                case "3":
                    laClasse = new Cleric();
                    break;
                case "4":
                    laClasse = new Druid();
                    break;
                case "5":
                    laClasse = new Fighter();
                    break;
                case "6":
                    laClasse = new Monk();
                    break;
                case "7":
                    laClasse = new Paladin();
                    break;
                case "8":
                    laClasse = new Ranger();
                    break;
                case "9":
                    laClasse = new Rogue();
                    break;
                case "10":
                    laClasse = new Sorcerer();
                    break;
                case "11":
                    laClasse = new Warlock();
                    break;
                case "12":
                    laClasse = new Wizard();
                    break;
                default:
                    laClasse = new barbare();
                    break;
            }


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

            perso personage = new perso(laRace, laClasse, racedeperso, stat[1],nom, Convert.ToInt32(stat[4]), Convert.ToInt32(stat[5]), Convert.ToInt32(stat[6]), Convert.ToInt32(stat[7]), Convert.ToInt32(stat[8]), Convert.ToInt32(stat[9]), Convert.ToInt32(stat[10]));

            return personage;
           
        }
    }
}
