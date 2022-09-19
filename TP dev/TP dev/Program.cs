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
            Console.WriteLine("Que voulez vous faire?");
            Console.WriteLine("1- enregistrer un nouveau personnage");
            Console.WriteLine("2- Utiliser un personnage existant");

            string rep = Console.ReadLine();

            string entréNom = "";
            
            //Demander le nom du perso
            if (rep == "2")
            {
                Console.WriteLine("Quel est le nom du perso?");
                entréNom = Console.ReadLine();
            }


            switch (rep)
            {
                //Créer une fiche
                case "1":
                    CréerFiche();
                    break;

                    //télécharge un perso
                case "2":
                    perso personnage = traitementExtrene.GetPerso(entréNom);
                    
                    personnage.AfficherFiche();
                    Menu(traitementExtrene.GetPerso(entréNom));
                    break;
            }

            
        }

        /// <summary>
        /// Créer un personnage au complet
        /// </summary>
        static void CréerFiche()
        {
            ClassePerso laClasse;
            Race laRace;

            Console.WriteLine("Quel class Voulez vous?");
            Console.WriteLine("");
            Console.WriteLine("1- Barbare");
            Console.WriteLine("2- Bard");
            Console.WriteLine("3- Cleric");
            Console.WriteLine("4- Druid");
            Console.WriteLine("5- Fighter");
            Console.WriteLine("6- Monk");
            Console.WriteLine("7- Paladin");
            Console.WriteLine("8- Ranger");
            Console.WriteLine("9- Rogue");
            Console.WriteLine("10- Sorcerer");
            Console.WriteLine("11- Warlock");
            Console.WriteLine("12- Wizard");
            Console.WriteLine("");

            string classdeperso = Console.ReadLine();

            //Attributs des la classes en fonction de la réponse  
            switch(classdeperso)
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

            Console.WriteLine("");
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

            //attribut la race en fonction de la réponse 
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

            //Demande le nom du perso
            Console.WriteLine("Quel nom voulez vous donner au personnage?");
            string nom = Console.ReadLine();

            //créer le perso
            perso monPerso = new perso(laRace, laClasse, classdeperso, racedeperso, nom);

            //renvoie au menu
            Menu(monPerso);

        }

        /// <summary>
        /// Affiche le menu
        /// </summary>
        /// <param name="monPerso"></param>
        public static void Menu(perso monPerso)
        {
            Console.Clear();

            Console.WriteLine("Que voulez vous faire?");
            Console.WriteLine("1- changer de personnage");
            Console.WriteLine("2- utiliser celui-ci");
            Console.WriteLine("3- créer un nouveau personnage");
            Console.WriteLine("4- Quiter");

            string entréNom = "";
            string rep = Console.ReadLine();
            //demande le nom du perso
            if (rep == "1")
            {
                Console.WriteLine("Quel est le nom du perso?");
                entréNom = Console.ReadLine();
            }

            //switch pour chaque option
            switch (rep)
            {
                //charge un persi,affiche ses stats et retoune au menu
                case "1":
                    perso personnage = traitementExtrene.GetPerso(entréNom);
                    
                    personnage.AfficherFiche();
                    Menu(traitementExtrene.GetPerso(entréNom));
                    break;

                    //Donne de la xp
                case "2":
                    monPerso.SetXp(15);
                    break;

                    //créer un perso
                case "3":
                    CréerFiche();
                    break;

                    //ferme le programme
                case "4":
                    break;
            }
        }
    }
}
