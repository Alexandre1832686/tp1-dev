using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_dev
{
    public class perso
    {
        public Race race;
        public ClassePerso classePerso;

        public string Nom { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }


        public perso(Race race, ClassePerso classePerso)
        {
            this.race = race;
            this.classePerso = classePerso;
        }


        public void MakeStats()
        {
            Console.WriteLine("|******************************|");
            Console.WriteLine("|  Remplissage des statistics  |");
            Console.WriteLine("|******************************|");

            Console.WriteLine("");




            for (int i = 0; i < this.race.GetBonusRace().GetLength(1); i++)
            {
                Console.WriteLine("Bonus racial : " + this.race.GetBonusRace()[0, 0 + i] + " + " + this.race.GetBonusRace()[1, 0 + i]);

            }

            Console.WriteLine("");
            Console.WriteLine("");

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

            SaveFiche();

            Console.WriteLine("\t PV : " + ((this.Constitution - 10) / 2 + De.lancerDe(this.classePerso.Attack()))); // à faire************
            Console.WriteLine("\t Strength : " + this.Strength);
            Console.WriteLine("\t Dexterity : " + this.Dexterity);
            Console.WriteLine("\t Constitution : " + this.Constitution);
            Console.WriteLine("\t Intelligence : " + this.Intelligence);
            Console.WriteLine("\t Wisdom : " + this.Wisdom);
            Console.WriteLine("\t Charisma : " + this.Charisma);

            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Que voulez vous faire?");
            Console.WriteLine("1- retourner au menu");
            Console.WriteLine("2- Recevoir de l'xp");


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

        static void SaveFiche()
        {

        }

    }
}
