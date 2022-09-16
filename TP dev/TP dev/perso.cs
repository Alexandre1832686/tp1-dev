using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TP_dev
{
    public class perso
    {
        public Race race;
        public ClassePerso classePerso;
        public string raceString { get; set; }
        public string classString { get; set; }

        public string Nom { get; set; }
        public int PV { get; set; }
        public int Niveau { get; set; }
        public int XP { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
       

        public perso(Race race, ClassePerso classePerso, string intrace,string intclass, string nom)
        {

            raceString = intrace;
            classString = intclass;

            this.race = race;
            this.classePerso = classePerso;
            this.Niveau = 1;
            this.XP = 0;
            this.Nom = nom;
            this.PV = (this.Constitution - 10) / 2 + De.lancerDe(this.classePerso.Attack());
            this.MakeStats();
        }
        public perso(Race race, ClassePerso classePerso, string intrace, string intclass, string nom, int Strength_p, int Dexterity_p, int Constitution_p, int Intelignece_p, int Wisdom_p, int Charisma_p, int pv)
        {

            raceString = intrace;
            classString = intclass;

            this.race = race;
            this.classePerso = classePerso;
            this.Niveau = 1;
            this.XP = 0;
            this.Nom = nom;

            this.Strength = Strength_p;
            this.PV = pv;
            this.Dexterity = Dexterity_p;
            this.Constitution = Constitution_p;
            this.Intelligence = Intelignece_p;
            this.Wisdom = Wisdom_p; 
            this.Charisma = Charisma_p;
        }

        
        public void MakeStats()
        {
            

            int bonusStrength = 0;
            for (int i = 0; i < this.race.GetBonusRace().GetLength(1); i++)
            {
                if (this.race.GetBonusRace()[1, i] == "Strength")
                {
                    bonusStrength = int.Parse(this.race.GetBonusRace()[0, i]);
                }

            }
            int bonusDexterity = 0;
            for (int i = 0; i < this.race.GetBonusRace().GetLength(1); i++)
            {
                if (this.race.GetBonusRace()[1, i] == "Dexterity")
                {
                    bonusDexterity = int.Parse(this.race.GetBonusRace()[0, i]);
                }
            }
            int bonusConstitution = 0;
            for (int i = 0; i < this.race.GetBonusRace().GetLength(1); i++)
            {
                if (this.race.GetBonusRace()[1, i] == "Constitution")
                {
                    bonusConstitution = int.Parse(this.race.GetBonusRace()[0, i]);
                }
            }
            int bonusIntelligence = 0;
            for (int i = 0; i < this.race.GetBonusRace().GetLength(1); i++)
            {
                if (this.race.GetBonusRace()[1, i] == "Intelligence")
                {
                    bonusIntelligence = int.Parse(this.race.GetBonusRace()[0, i]);
                }
            }
            int bonusWisdom = 0;
            for (int i = 0; i < this.race.GetBonusRace().GetLength(1); i++)
            {
                if (this.race.GetBonusRace()[1, i] == "Wisdom")
                {
                    bonusWisdom = int.Parse(this.race.GetBonusRace()[0, i]);
                }
            }
            int bonusCharisma = 0;
            for (int i = 0; i < this.race.GetBonusRace().GetLength(1); i++)
            {
                if (this.race.GetBonusRace()[1, i] == "Charisma")
                {
                    bonusCharisma = int.Parse(this.race.GetBonusRace()[0, i]);
                }
            }

            
            this.Strength = LancerPourStats() + bonusStrength;
            this.Dexterity = LancerPourStats() + bonusDexterity;
            this.Constitution = LancerPourStats() + bonusConstitution;
            this.Intelligence = LancerPourStats() + bonusIntelligence;
            this.Wisdom = LancerPourStats() + bonusWisdom;
            this.Charisma = LancerPourStats() + bonusCharisma;
           

            SaveFiche(Nom, classString, raceString, XP.ToString(), Strength.ToString(), Dexterity.ToString(), Constitution.ToString(), Intelligence.ToString(), Wisdom.ToString(), Charisma.ToString(), PV);

            AfficherFiche();

            

            Console.Clear();
            Console.WriteLine("Que voulez vous faire?");
            Console.WriteLine("1- retourner au menu");
            Console.WriteLine("2- Recevoir de l'xp");
            bool verif = false;
            do
            {
                string rep = Console.ReadLine();
                verif = true;

                switch (rep)
                {
                    case "1":
                        Program.Menu(this);
                        break;
                    case "2":
                        SetXp(30);
                        break;
                    default:
                        verif = false;
                        break;

                }
            } while (verif == false);

        }

        int LancerPourStats()
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

        public void SetXp( int amount)
        {
            int[] tabXp = new int[20];
            tabXp[0] = 0;
            tabXp[1] = 300;
            tabXp[2] = 900;
            tabXp[3] = 2700;
            tabXp[4] = 6500;
            tabXp[5] = 14000;
            tabXp[6] = 23000;
            tabXp[7] = 34000;
            tabXp[8] = 48000;
            tabXp[9] = 64000;
            tabXp[10] = 85000;
            tabXp[11] = 100000;
            tabXp[12] = 120000;
            tabXp[13] = 140000;
            tabXp[14] = 165000;
            tabXp[15] = 195000;
            tabXp[16] = 225000;
            tabXp[17] = 265000;
            tabXp[18] = 305000;
            tabXp[19] = 355000;
  
            List<int[]> tabXpNiv = new List<int[]>();

            for(int i = 0; i < 20; i++)
            {
                int[] tabtemp = new int[2];
                tabtemp[1] = i + 1;
                tabtemp[0] = tabXp[i];
                tabXpNiv.Add(tabtemp);
            }

            int lvl = this.Niveau;

            if(tabXpNiv[lvl - 1][0] <= this.XP + amount)
            {
                LevelUp();
            }
            




            this.XP += amount;


            AfficherFiche();

            SaveFiche(Nom, classString, raceString, XP.ToString(), Strength.ToString(), Dexterity.ToString(), Constitution.ToString(), Intelligence.ToString(), Wisdom.ToString(), Charisma.ToString(), PV);
        }

        public static void SaveFiche(string nom, string classperso, string race, string xp, string strengh, string dexterity, string constitution, string intel, string wisdom, string charisma, int HP)
        {

            bool check = false;
            if (File.Exists("../../../perso.csv"))
            {
                check = true;
            }
            
            
            using (StreamWriter sw = new StreamWriter("../../../perso.csv", append: true))
            {
                
                if(!check)
                {
                    sw.WriteLine("Nom,"+"Class,"+"Race," +"Xp," + "Force," + "Dexterité," + "Constitution," + "Intelligence,"+ "Wisdom,"+ "Charisma" + "HP");
                }

                sw.WriteLine(nom+","+classperso+"," + race+"," + xp+"," + strengh +","+ dexterity+","+ constitution+","+ intel+","+ wisdom+","+ charisma +","+ HP);
            }
        }
        void LevelUp()
        {
            this.Niveau += 1;
            Console.Clear();
            Console.WriteLine("|******************************|");
            Console.WriteLine("|           Level Up           |");
            Console.WriteLine("|******************************|");
            int pvadd = 0;

            pvadd = De.lancerDe(this.classePerso.Attack()) + (this.Constitution-10) / 2;
            if(pvadd<1)
            {
                pvadd = 1;
            }

            this.PV += pvadd;
            bool verif = false;
            do
            {
                Console.WriteLine("Voulez vous faire :");
                Console.WriteLine("1- Augmenter une carac de 2");
                Console.WriteLine("2- augmenter 2 carac de 1");

                string rep = Console.ReadLine();
                if(rep != "1" && rep != "2")
                {
                    verif = false;

                }
                else
                {
                    verif = true;
                }

                if (rep == "1")
                {
                    Console.WriteLine("Quel Carac voulez vous augmenter");
                    Console.WriteLine("1-str");
                    Console.WriteLine("2-dex");
                    Console.WriteLine("3-int");
                    Console.WriteLine("4-con");
                    Console.WriteLine("5-wis");
                    Console.WriteLine("6-cha");

                    string rep2 = Console.ReadLine();

                    switch (rep2)
                    {
                        case "1":
                            if (this.Strength < 19)
                                this.Strength += 2;
                            else
                                verif = false;
                            break;
                        case "2":
                            if (this.Dexterity < 19)
                                this.Dexterity += 2;
                            else
                                verif = false;
                            break;
                        case "3":
                            if (this.Intelligence < 19)
                                this.Intelligence += 2;
                            else
                                verif = false;
                            break;
                        case "4":

                            if (this.Constitution < 19)
                            {
                                this.Constitution += 2;
                                if ((Math.Floor(Convert.ToDouble(this.Constitution - 10) / 2)) < (Math.Floor(Convert.ToDouble(this.Constitution - 8) / 2)))
                                {
                                    this.Constitution += Niveau;
                                }
                            }
                            else
                                verif = false;
                            break;
                        case "5":
                            if (this.Wisdom < 19)
                                this.Wisdom += 2;
                            else
                                verif = false;
                            break;
                        case "6":
                            if (this.Charisma < 19)
                                this.Charisma += 2;
                            else
                                verif = false;
                            break;
                    }
                }
                else if (rep == "2")
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine("Quel Carac voulez vous augmenter");
                        Console.WriteLine("1-str");
                        Console.WriteLine("2-dex");
                        Console.WriteLine("3-int");
                        Console.WriteLine("4-con");
                        Console.WriteLine("5-wis");
                        Console.WriteLine("6-cha");

                        string rep2 = Console.ReadLine();

                        switch (rep2)
                        {
                            case "1":
                                if (this.Strength < 20)
                                    this.Strength += 1;
                                else
                                    verif = false;
                                break;
                            case "2":
                                if (this.Dexterity < 20)
                                    this.Dexterity += 1;
                                else
                                    verif = false;
                                break;
                            case "3":
                                if (this.Intelligence < 20)
                                    this.Intelligence += 1;
                                else
                                    verif = false;
                                break;
                            case "4":
                                if (this.Constitution < 20)
                                {
                                    this.Constitution += 1;
                                    if ((Math.Floor(Convert.ToDouble(this.Constitution - 10) / 2)) < (Math.Floor(Convert.ToDouble(this.Constitution - 9) / 2)))
                                    {
                                        this.PV += Niveau;
                                    }
                                }   
                                else
                                    verif = false;
                                break;
                            case "5":
                                if (this.Wisdom < 20)
                                    this.Wisdom += 1;
                                else
                                    verif = false;
                                break;
                            case "6":
                                if (this.Charisma < 20)
                                    this.Charisma += 1;
                                else
                                    verif = false;
                                break;
                        }
                    }
                }
            } while (verif == false);
            Program.Menu(this);
        }

        public void AfficherFiche()
        {

            Console.WriteLine("|******************************|");
            Console.WriteLine("|          Statistiques        |");
            Console.WriteLine("|******************************|");
            Console.WriteLine("");
            Console.WriteLine("Nom : " + Nom);
            Console.WriteLine("");
            Console.WriteLine("");
            for (int i = 0; i < this.race.GetBonusRace().GetLength(1); i++)
            {
                Console.WriteLine("Bonus racial : " + this.race.GetBonusRace()[0, 0 + i] + " + " + this.race.GetBonusRace()[1, 0 + i]);
            }
            Console.WriteLine();
            Console.WriteLine("PV : " + this.PV);
            Console.WriteLine("\t Strength : " + this.Strength);
            Console.WriteLine("\t Dexterity : " + this.Dexterity);
            Console.WriteLine("\t Constitution : " + this.Constitution);
            Console.WriteLine("\t Intelligence : " + this.Intelligence);
            Console.WriteLine("\t Wisdom : " + this.Wisdom);
            Console.WriteLine("\t Charisma : " + this.Charisma);
            Console.ReadLine();
        }

        

    }
}
